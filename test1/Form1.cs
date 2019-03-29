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
    public partial class Form1 : Form
    {
        public static string TextRootNode = null;
        public static string TextChildrenNode = null;
        public static string rootNode2 = null;

        TreeListNode rootNode;

        public Form1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            tableTableAdapter1.Fill(database1DataSet1.Table);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            treeList1.BeginUnboundLoad();
            rootNode = treeList1.AppendNode(new object[] { TextRootNode }, null, null);
            treeList1.EndUnboundLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.ShowDialog();
            treeList1.BeginUnboundLoad();
            treeList1.AppendNode(new object[] { TextChildrenNode }, rootNode);
            treeList1.EndUnboundLoad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeList1.BeginUnboundLoad();
            treeList1.DeleteSelectedNodes();
            treeList1.EndUnboundLoad();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4();
            newForm4.ShowDialog();
        }
    }
}
