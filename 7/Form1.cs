using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = Convert.ToString(textBox1.Text); // ввод строки
            string n = "";

            for (int i = 0; i < t.Length; i++)
            {

                if (t[i] == 't')
                    n+="t";
            }

            label1.Text = "" + n;
            /*Дана строка. Напечатать все её буквы t.*/
        }
    }
}
