using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship {

    public class CoordSet : ISet<CoordPair> {

        protected BitVector fields = new BitVector(100);

        public int Count { get; private set; }
        public bool IsReadOnly { get { return false; } }

        public CoordSet(IEnumerable<CoordPair> source) {
            var set = source as CoordSet;
            if (set != null) {
                fields = set.fields.Copy();
                Count = set.Count;
            } else {
                foreach (CoordPair item in source) {
                    Add(item);
                }
            }
        }

        public CoordSet() { }

        public bool Add(CoordPair item) {
            if (Contains(item)) return false;

            fields[item.Index] = true;
            Count++;

            return true;
        }

        public void Add(CoordSet items) {
            fields.Or(items.fields);
            Count = fields.PopulationCount();
        }

        public bool Remove(CoordPair item) {
            if (Contains(item)) {
                fields[item.Index] = false;
                Count--;
                return true;
            }
            return false;
        }

        public void Clear() {
            fields.SetAll(false);
            Count = 0;
        }

        public bool Contains(CoordPair item) {
            return fields[item.Index];
        }

        public void ExceptWith(IEnumerable<CoordPair> other) {
            var otherSet = other as CoordSet;
            if (otherSet == null) otherSet = new CoordSet(other);

            fields.XOr(BitVector.And(fields, otherSet.fields));
            Count = fields.PopulationCount();
        }

        public void IntersectWith(IEnumerable<CoordPair> other) {
            var otherSet = other as CoordSet;
            if (otherSet == null) otherSet = new CoordSet(other);

            fields.And(otherSet.fields);
            Count = fields.PopulationCount();
        }

        public bool IsProperSubsetOf(IEnumerable<CoordPair> other) {
            var otherSet = other as CoordSet;

            if (otherSet == null) {
                var otherCollection = other as ICollection<CoordPair>;

                if (otherCollection != null && Count == 0 && otherCollection.Count > 0) return true;
                otherSet = new CoordSet(other);
            }

            if (Count == 0 && otherSet.Count > 0) return true;
            return BitVector.Or(otherSet.fields, fields).Equals(otherSet.fields) && otherSet.Count > Count;
        }

        public bool IsProperSupersetOf(IEnumerable<CoordPair> other) {
            var otherSet = other as CoordSet;

            if (otherSet == null) {
                var otherCollection = other as ICollection<CoordPair>;

                if (otherCollection != null && otherCollection.Count == 0 && Count > 0) return true;
                otherSet = new CoordSet(other);
            }

            if (otherSet.Count == 0 && Count > 0) return true;
            return BitVector.Or(fields, otherSet.fields).Equals(fields) && Count > otherSet.Count;
        }

        public bool IsSubsetOf(IEnumerable<CoordPair> other) {
            if (Count == 0) return true;
            var otherSet = other as CoordSet;
            if (otherSet == null) otherSet = new CoordSet(other);

            return BitVector.Or(otherSet.fields, fields).Equals(otherSet.fields);
        }

        public bool IsSupersetOf(IEnumerable<CoordPair> other) {
            var OtherSet = other as CoordSet;

            if (OtherSet == null) {
                var otherCollection = other as ICollection<CoordPair>;

                if (otherCollection != null && otherCollection.Count == 0) return true;
                OtherSet = new CoordSet(other);
            }

            if (OtherSet.Count == 0) return true;

            return BitVector.Or(fields, OtherSet.fields).Equals(fields);
        }

        public bool Overlaps(IEnumerable<CoordPair> other) {
            var otherSet = other as CoordSet;
            if (otherSet == null) otherSet = new CoordSet(other);

            return BitVector.And(fields, otherSet.fields).PopulationCount() > 0;
        }

        public void SymmetricExceptWith(IEnumerable<CoordPair> other) {
            var otherSet = other as CoordSet;
            if (otherSet == null) otherSet = new CoordSet(other);

            fields.XOr(otherSet.fields);
            Count = fields.PopulationCount();
        }

        public void UnionWith(IEnumerable<CoordPair> other) {
            var otherSet = other as CoordSet;
            if (otherSet == null) otherSet = new CoordSet(other);

            fields.Or(otherSet.fields);
            Count = fields.PopulationCount();
        }

        public bool SetEquals(IEnumerable<CoordPair> other) {
            var otherSet = other as CoordSet;
            if (otherSet == null) otherSet = new CoordSet(other);

            if (otherSet.Count != Count) return false;
            return otherSet.fields.Equals(fields);
        }

        void ICollection<CoordPair>.Add(CoordPair item) {
            Add(item);
        }

        public IEnumerator<CoordPair> GetEnumerator() {
            int counter = 0;
            for (int i = 0; counter < Count; i++) {
                if (fields[i]) {
                    counter++;
                    yield return new CoordPair(i);
                }
            }
        }

        //Átlagba kissé gyorsabb mintha foreach-el mennénk végig. A sorozatot felbontjuk 16 bites blokkokra,
        //és ha egy blokk értéke nulla akkor tudjuk hogy a blokk üres és inkább átugorjuk.
        public unsafe CoordPair[] GetAllCoords() {
            CoordPair[] coords = new CoordPair[Count];

            fixed (ulong* p = fields.StorageBlocks) {
                short* block = (short*)p;
                int bitIndex = 0;
                int counter = 0;

                while (counter < Count) {
                    if (*block == 0) {
                        block++;
                        bitIndex += 16;
                        continue;
                    }
                    //forciklus liberális használata
                    for (int i = Math.Min(bitIndex + 16, 100); bitIndex < i; bitIndex++) {
                        if (fields[bitIndex]) {
                            coords[counter++] = new CoordPair(bitIndex);
                        }
                    }
                    block++;
                }
            }

            return coords;
        }

        public void CopyTo(CoordPair[] array, int arrayIndex) {
            Array.Copy(GetAllCoords(), 0, array, arrayIndex, Count);
        }

        public void Fill() {
            fields.FillStorage(ulong.MaxValue);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }


}
