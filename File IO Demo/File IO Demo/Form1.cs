using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_IO_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             StreamReader reader = null;
            try
            {
                openFileDialog1.InitialDirectory = "D:\\Files";
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName!= null&&openFileDialog1.FileName.Contains(".txt"))
                {
                    reader = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = reader.ReadToEnd();
                }
                    
            }
            
            
            catch(FileNotFoundException e1)
            {
                MessageBox.Show(e1.Message, "Error");
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writer = null;
            try
            {
                saveFileDialog1.InitialDirectory = @"D:\Files";
                saveFileDialog1.ShowDialog();
                if(saveFileDialog1.FileName!=null)
                {
                    writer = new StreamWriter(saveFileDialog1.FileName);
                    writer.Write(textBox1.Text);
                }
               
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }

        }
    }
}
