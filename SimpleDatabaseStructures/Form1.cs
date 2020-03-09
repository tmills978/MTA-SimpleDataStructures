using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDatabaseStructures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int total = 0;
            int number = Convert.ToInt32(comboBox1.Text);
            int[] marks = new int[number];
            while (i < number)
            {
                EnterData myEnterData = new EnterData();
                myEnterData.ShowDialog();
                marks[i] = Convert.ToInt32(myEnterData.GetTextBoxData());
                total = total + marks[i];
                i++;
            }
            label2.Text = "Average mark is " + (total / marks.Length).ToString();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
