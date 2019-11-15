using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGEasy
{
    public partial class Chapt9Prob3 : Form
    {
        public Chapt9Prob3()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string XPositionLabel = XPositionBox.Text;
            string YPositionLabel = YPositionBox.Text;
            int xcoord = Convert.ToInt32(XPositionLabel);
            int ycoord = Convert.ToInt32(YPositionLabel);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(xcoord, ycoord);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void XPositionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YPositionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void XPositionBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void YPositionBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void YPositionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
