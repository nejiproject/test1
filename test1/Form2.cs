﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;




namespace test1
{
    public partial class Form2 : Form
    {
      

        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.TextRootNode = textBox1.Text.ToString();
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

   
    }
}