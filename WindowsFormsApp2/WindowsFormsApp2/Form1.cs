using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text +" "+ dateTimePicker3.Text+" "+dateTimePicker2.Text +" "+ dateTimePicker1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        // private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //comboBox4.DataSource = Enumerable.Range(1950, 100).ToList;
        //comboBox4.SelectedIndex = comboBox4.Items.IndexOf(2000);
        //}


    }
}