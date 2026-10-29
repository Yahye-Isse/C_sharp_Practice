using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files_Rev_CA242_CA244
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Example of Creating new file ,Writing the file

            //Import Class 
            StreamWriter Output_file;
            StreamWriter Output_file1;

            //Use Three Process the file
            //Open The file - Creating new file
            Output_file = File.CreateText("Index.txt");
            Output_file1 = File.CreateText("Home.doc");

            //Process the file - Writing The file 
            Output_file.Write("Welcome to CA242");
            Output_file.Write("C# Is hard then Other Progamming language");
            Output_file1.WriteLine("Welcome to CA244");
            Output_file1.WriteLine("Data Sturcture is very hard");

            //Close The file 
            Output_file.Close();
            Output_file1.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Example of Creating new file ,Writing the file

            //Import Class 
           
            StreamWriter Output_file1;

            //Use Three Process the file
            //Open The file - Creating new file
           
            Output_file1 = File.CreateText(@"C:\Users\Yahye-Ali-Isse\Downloads\saved_files\Php.txt");
         
            //Process the file - Writing The file 


            Output_file1.WriteLine("Welcome to CA244");
            Output_file1.WriteLine("Data Sturcture is very hard");

            //Close The file 
       
            Output_file1.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Example of Append the file ,Writing the file

            //Import Class 

            StreamWriter Output_file1;

            //Use Three Process the file
            //Open The file - Append The file

            Output_file1 = File.AppendText(@"C:\Users\Yahye-Ali-Isse\Downloads\saved_files\Php.txt");

            //Process the file - Writing The file 


            Output_file1.WriteLine("Name : Yahye Ali Isse");
            Output_file1.WriteLine("Age : 40");

            //Close The file 

            Output_file1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Example Reading The file 
            //Import Class 
            StreamReader Reads;
            //open The file- Reading The file
            Reads = File.OpenText(@"C:\Users\Yahye-Ali-Isse\Downloads\saved_files\Php.txt");

            // Process the file - reading the file
            //Creating variable to store the reading items
            string lines;

            //Loops Reading All Files items 
            while(Reads.EndOfStream== false) //true
            {
                //Assign the variable
                lines = Reads.ReadLine();

                //assign listbox
                listBox1.Items.Add(lines);

            }
           

            //the Close the file 
            Reads.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Import Class
            StreamReader Reads;

            //open The file 
            Reads = File.OpenText(@"C:\Users\Yahye-Ali-Isse\Downloads\saved_files\Php.txt");

            char lines;
            while(Reads.EndOfStream==false)
            {
                lines = (char)Reads.Read();

                listBox1.Items.Add(lines);
            }
       

            //close the file
            Reads.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Import Class
            StreamReader Reads;

            //open The file 
            Reads = File.OpenText(@"C:\Users\Yahye-Ali-Isse\Downloads\saved_files\Php.txt");

            //Proces the file- using Read To end
            string lines;
            lines = Reads.ReadToEnd();
            listBox1.Items.Add(lines);

            //close the file
            Reads.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Not needed to import class 
            string lines;


            lines = File.ReadAllText(@"C:\Users\Yahye-Ali-Isse\Downloads\saved_files\Php.txt");
            listBox1.Items.Add(lines);
            //Not Needed The Process the file 
            //Not need CLose The file 
            
        }
    }
}
