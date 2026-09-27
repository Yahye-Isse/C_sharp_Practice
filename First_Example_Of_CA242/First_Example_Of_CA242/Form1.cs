using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Example_Of_CA242
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Names;
            double Comm;
            double salary;
            double net_salary;
            Names = textBox1.Text;
     
            try
            {
                //Parse method - conversition string to numerics 
                //syntax datatype.parse(string)
                Comm = double.Parse(textBox2.Text);
                salary = double.Parse(textBox3.Text);

                net_salary = salary / Comm;

                label1.Text = net_salary.ToString("p");
            }
            catch(Exception Ex)
            {
                MessageBox.Show("walaal data waa qalad");
                
            }
           

            

            
           
        }
    }
}
