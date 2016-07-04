using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BinCalc : Form
    {
        public BinCalc()
        {
            InitializeComponent();
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void werw4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            //Button has changed
            //Check all button values
            int summa = 0;
            foreach (var button in Controls.OfType<CheckBox>().Cast<CheckBox>())
            {
                if (button.Checked == true)
                {
                    int buttonNumber = int.Parse(button.Text);
                    summa = buttonNumber + summa;
                }
            }
            textBox1.Text = summa.ToString();
        


        }

        private void BinCalc_Load(object sender, EventArgs e)
        {

        }
    }
}
