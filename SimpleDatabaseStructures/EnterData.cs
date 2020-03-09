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
    public partial class EnterData : Form
    {
        public EnterData()
        {
            InitializeComponent();
        }

        private void EnterData_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetTextBoxData()
        {
            return textBox1.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
