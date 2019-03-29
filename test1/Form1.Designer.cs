namespace test1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeList = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.database1DataSet = new test1.Database1DataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new test1.Database1DataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new test1.Database1DataSetTableAdapters.TableAdapterManager();
            this.tableGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.database1DataSet1 = new test1.Database1DataSet();
            this.tableTableAdapter1 = new test1.Database1DataSetTableAdapters.TableTableAdapter();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colФИО = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colДатарождения = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colПроффесия = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colЗП = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colПол = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeList});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.Location = new System.Drawing.Point(17, 36);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "Отдел менеджеров"}, -1, 1);
            this.treeList1.AppendNode(new object[] {
            "Старшие менеджеры"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Младшие менеджеры"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Отдел программистов"}, -1, 2);
            this.treeList1.AppendNode(new object[] {
            "Senior"}, 3);
            this.treeList1.AppendNode(new object[] {
            "Middle"}, 3);
            this.treeList1.AppendNode(new object[] {
            "Junior"}, 3);
            this.treeList1.EndUnboundLoad();
            this.treeList1.Size = new System.Drawing.Size(346, 401);
            this.treeList1.TabIndex = 0;
            // 
            // treeList
            // 
            this.treeList.Caption = "Подразделения";
            this.treeList.FieldName = "treeList";
            this.treeList.Name = "treeList";
            this.treeList.Visible = true;
            this.treeList.VisibleIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить родительское поле";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(346, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(346, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить дочернее поле";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = test1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableGridControl
            // 
            this.tableGridControl.DataMember = "Table";
            this.tableGridControl.DataSource = this.database1DataSet1;
            gridLevelNode1.RelationName = "Level1";
            this.tableGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.tableGridControl.Location = new System.Drawing.Point(388, 36);
            this.tableGridControl.MainView = this.gridView1;
            this.tableGridControl.Name = "tableGridControl";
            this.tableGridControl.Size = new System.Drawing.Size(917, 488);
            this.tableGridControl.TabIndex = 4;
            this.tableGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colФИО,
            this.colДатарождения,
            this.colПроффесия,
            this.colЗП,
            this.colПол});
            this.gridView1.GridControl = this.tableGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colФИО
            // 
            this.colФИО.FieldName = "ФИО";
            this.colФИО.Name = "colФИО";
            this.colФИО.Visible = true;
            this.colФИО.VisibleIndex = 1;
            // 
            // colДатарождения
            // 
            this.colДатарождения.FieldName = "Дата рождения";
            this.colДатарождения.Name = "colДатарождения";
            this.colДатарождения.Visible = true;
            this.colДатарождения.VisibleIndex = 2;
            // 
            // colПроффесия
            // 
            this.colПроффесия.FieldName = "Проффесия";
            this.colПроффесия.Name = "colПроффесия";
            this.colПроффесия.Visible = true;
            this.colПроффесия.VisibleIndex = 3;
            // 
            // colЗП
            // 
            this.colЗП.FieldName = "ЗП";
            this.colЗП.Name = "colЗП";
            this.colЗП.Visible = true;
            this.colЗП.VisibleIndex = 4;
            // 
            // colПол
            // 
            this.colПол.FieldName = "Пол";
            this.colПол.Name = "colПол";
            this.colПол.Visible = true;
            this.colПол.VisibleIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 548);
            this.Controls.Add(this.tableGridControl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "test project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl tableGridControl;
        private Database1DataSet database1DataSet1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colФИО;
        private DevExpress.XtraGrid.Columns.GridColumn colДатарождения;
        private DevExpress.XtraGrid.Columns.GridColumn colПроффесия;
        private DevExpress.XtraGrid.Columns.GridColumn colЗП;
        private DevExpress.XtraGrid.Columns.GridColumn colПол;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter1;
    }
}

