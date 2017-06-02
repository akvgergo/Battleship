using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship {
    public class CustomPanel : Panel {

        public CustomPanel() {
            DoubleBuffered = true;
        }
    }

    public class CustomFLPanel : FlowLayoutPanel {

        public CustomFLPanel() {
            DoubleBuffered = true;
        }
    }
}
