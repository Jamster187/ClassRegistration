﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRegistry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classRegistryDataSet.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.classRegistryDataSet.Cart);
            // TODO: This line of code loads data into the 'classRegistryDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.classRegistryDataSet.Courses);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
