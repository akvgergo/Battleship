using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship {

    /// <summary>
    /// Egy kompakt bitsorozat. Használhatnék System.Collections.BitArray-t is, de ez egy kicsivel jobb mert:
    /// -64 bit: gyorsabb bitműveletek (Not, XOr, SetAll, stb.)
    /// -Publikus a hátsó sorozat, vagyis nem kell sem reflekció, sem pedig másolgatás CopyTo()-val ha saját
    /// műveleteket szeretnék
    /// -Generikus interfész implementálás, ami nekem nem feltétlen előnyös, de útálok mindent amibe 1.1-es interfészek vannak
    /// Ezeket leszámítva sokban hasonlít a hagyományos BitArray-ra
    /// </summary>
    public class BitVector : IEnumerable<bool> {

        public int Length { get; private set; }
        public ulong[] StorageBlocks;

        public const int BlockSize = 64;

        public bool this[int index] {
            get { return GetValue(index); }
            set { SetValue(index, value); }
        }

        public BitVector(int length, bool defaultValue = false) {
            StorageBlocks = new ulong[GetStorageLength(length)];
            Length = length;

            if (defaultValue) FillStorage(ulong.MaxValue);
            TrimBits();
        }

        //Nagyon remélem hogy nem fog kelleni
        public unsafe BitVector(BitArray source) {
            StorageBlocks = new ulong[GetStorageLength(source.Length)];
            Length = source.Length;
            int[] srcArray = new int[(source.Length - 1) / 32 + 1];
            source.CopyTo(srcArray, 0);

            fixed (ulong* p_copy = StorageBlocks)
            fixed (int* intp_src = srcArray) {
                ulong* ulongp_src = (ulong*)intp_src;
                ulong* ulongp_copy = p_copy;

                for (int i = 0; i < StorageBlocks.Length; i++) {
                    *ulongp_copy++ = *ulongp_src++;
                }
            }
        }

        protected BitVector(ulong[] source, int length) {
            StorageBlocks = source;
            Length = length;
            TrimBits();
        }

        public void SetAll(bool value) {
            if (value) {
                FillStorage(ulong.MaxValue);
                TrimBits();
            } else FillStorage(ulong.MinValue);
        }

        public bool GetValue(int index) {
            if (index >= Length || index < 0) throw new IndexOutOfRangeException("index");
            return (StorageBlocks[index / BlockSize] & (1UL << (index % BlockSize))) != 0;
        }

        public void SetValue(int index, bool value) {
            if (index >= Length || index < 0) throw new IndexOutOfRangeException("index");
            if (value) {
                StorageBlocks[index / BlockSize] |= (1UL << (index % BlockSize));
            } else {
                StorageBlocks[index / BlockSize] &= ~(1UL << (index % BlockSize));
            }
        }

        public void Resize(int length, bool clear = false) {
            if (clear) {
                StorageBlocks = new ulong[GetStorageLength(length)];
                Length = length;
                return;
            }

            ulong[] New = new ulong[GetStorageLength(length)];
            if (length < Length) {
                Array.Copy(StorageBlocks, New, New.Length);
                TrimBits();
            } else {
                TrimBits();
                Array.Copy(StorageBlocks, New, New.Length);
            }

            StorageBlocks = New;
            Length = length;
        }

        public void FillStorage(ulong value) {
            for (int i = 0; i < StorageBlocks.Length; i++) {
                StorageBlocks[i] = value;
            }
            TrimBits();
        }

        //A bit műveletek után a felesleges bitek értéke megváltozhat.
        //Hibák elkerülése érdekében ezt a metódust nem árt hívni azután hogy a StorageBlocks-al műveleteket hajtunk végre.
        public void TrimBits() {
            StorageBlocks[StorageBlocks.Length - 1] &= ((1UL << (Length % BlockSize)) - 1);
        }

        static int GetStorageLength(int length) {
            return (length - 1) / BlockSize + 1;
        }

        public IEnumerator<bool> GetEnumerator() {
            for (int i = 0; i < Length; i++) {
                yield return GetValue(i);
            }
        }
        //Hagyományos bitműveletek
        public BitVector And(BitVector value) {
            int length = Math.Min(StorageBlocks.Length, value.StorageBlocks.Length);
            int i;

            for (i = 0; i < length; i++) {
                StorageBlocks[i] &= value.StorageBlocks[i];
            }

            while (i < StorageBlocks.Length) {
                StorageBlocks[i] = 0;
                i++;
            }

            TrimBits();
            return this;
        }

        public BitVector Or(BitVector value) {
            int length = Math.Min(StorageBlocks.Length, value.StorageBlocks.Length);
            for (int i = 0; i < length; i++) {
                StorageBlocks[i] |= value.StorageBlocks[i];
            }
            TrimBits();
            return this;
        }

        public BitVector Not() {
            for (int i = 0; i < StorageBlocks.Length; i++) {
                StorageBlocks[i] = ~StorageBlocks[i];
            }
            TrimBits();
            return this;
        }

        public BitVector XOr(BitVector value) {
            int length = Math.Min(StorageBlocks.Length, value.StorageBlocks.Length);
            for (int i = 0; i < length; i++) {
                StorageBlocks[i] ^= value.StorageBlocks[i];
            }
            TrimBits();
            return this;
        }

        public int PopulationCount() {
            int count = 0;
            for (int i = 0; i < StorageBlocks.Length; i++) {
                count += Util.Popcnt(StorageBlocks[i]);
            }
            return count;
        }

        public BitVector Copy() {
            ulong[] copy = new ulong[StorageBlocks.Length];
            Array.Copy(StorageBlocks, copy, copy.Length);
            return new BitVector(copy, Length);
        }

        public bool Equals(BitVector other) {
            if (Length != other.Length) return false;
            for (int i = 0; i < StorageBlocks.Length; i++) {
                if (StorageBlocks[i] != other.StorageBlocks[i]) return false;
            }
            return true;
        }
        //olyan bitműveletek amik nem módosítják az egyik kiinduló halmazt sem.
        public static BitVector And(BitVector left, BitVector right) {
            BitVector shorter = left.Length < right.Length ? left : right;
            BitVector bv = new BitVector(shorter.Length);

            for (int i = 0; i < shorter.StorageBlocks.Length; i++) 
                bv.StorageBlocks[i] = left.StorageBlocks[i] & right.StorageBlocks[i];

            return bv;
        }

        public static BitVector Or(BitVector left, BitVector right) {
            BitVector longer = left.Length > right.Length ? left : right;
            BitVector shorter = left.Length < right.Length ? left : right;
            BitVector bv = new BitVector(longer.Length);
            int i;

            for (i = 0; i < shorter.StorageBlocks.Length; i++)
                bv.StorageBlocks[i] = left.StorageBlocks[i] | right.StorageBlocks[i];
            for (; i < longer.StorageBlocks.Length; i++) 
                bv.StorageBlocks[i] = longer.StorageBlocks[i];

            return bv;
        }

        public static BitVector Not(BitVector source) {
            BitVector bv = source.Copy();
            bv.Not();
            return bv;
        }

        public static BitVector XOr(BitVector left, BitVector right) {
            BitVector longer = left.Length > right.Length ? left : right;
            BitVector shorter = left.Length < right.Length ? left : right;
            BitVector bv = new BitVector(longer.Length);
            int i;

            for (i = 0; i < shorter.StorageBlocks.Length; i++)
                bv.StorageBlocks[i] = left.StorageBlocks[i] ^ right.StorageBlocks[i];
            for (; i < longer.StorageBlocks.Length; i++) {
                bv.StorageBlocks[i] = longer.StorageBlocks[i];
            }

            return bv;
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
