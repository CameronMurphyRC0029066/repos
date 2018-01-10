using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace int_and_double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int i1 = 3 * 4;
            int i2 = 12 / 4;
            int i3 = 15 / 4;
            int i4 = 15 % 4;
            int i5 = 2 + 3 *;
            int i6 = 2 + (3 * 4) / (2 - 4);
            double d1 = 3.1 * 2.3;
            double d2 = 1.0 / 3.0;
            double d3 = 1 / 3;
        }
    }
}
