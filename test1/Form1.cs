using System;
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


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            treeList1.BeginUnboundLoad();
            TreeListNode rootNode = treeList1.AppendNode(new object[] { TextRootNode }, null, null);
            treeList1.AppendNode(new object[] { TextChildrenNode }, rootNode);
            treeList1.EndUnboundLoad();
        }



    }
}
