using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Tool161;
using System.Reflection;
using System.IO;

namespace DataSafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, EventArgs e)
        {
            try
            {
                string path=@"C:\Windows\WindowColin.txt";
                if(File.Exists(path))
                {
                    string text = File.ReadAllText(path);
                    int num = Convert.ToInt32(text);
                    if(num<5)
                    {
                        num++;
                        File.WriteAllText(path, Convert.ToString(num));
                    }
                    else
                    {
                        MessageBox.Show("(:");
                        Application.Exit();
                    }
                }
                else
                {
                    string num = "1";
                    File.WriteAllText(path, num);
                }
               
            }
            catch
            {

            }
        }
    }
}
