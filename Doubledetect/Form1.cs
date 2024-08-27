using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubledetect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
          
            int[] ints = new int[3];
         
            ints[0] = (int)numericUpDown1.Value;
            ints[1] = (int)numericUpDown2.Value;
            ints[2] = (int)numericUpDown3.Value;
       
            if (detectDuplicates(ints))
            {
                MessageBox.Show("Det finns dubletter!");
            }
            else
            {
                MessageBox.Show("Alla tal är unika!");
            }
        }

        private bool detectDuplicates(int[] intarray)
        {
            for (int i = 0; i < intarray.Length; i++)
            {
      
                for (int A = i + 1; A < intarray.Length; A++)
                {
                  
                    if (intarray[i] == intarray[A])
                    {
                        return true;
                    }
                }
            }
           
            return false;

        }

        private void button1_Click_21(object sender, EventArgs e)
        {

        }
    }
}
