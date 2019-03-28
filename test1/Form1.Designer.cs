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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeList = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeList});
            this.treeList1.Location = new System.Drawing.Point(17, 12);
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
            "Тимлид"}, 3);
            this.treeList1.AppendNode(new object[] {
            "Senior"}, 3);
            this.treeList1.AppendNode(new object[] {
            "Middle"}, 3);
            this.treeList1.AppendNode(new object[] {
            "Junior"}, 3);
            this.treeList1.AppendNode(new object[] {
            "Отдел продаж"}, -1, 3);
            this.treeList1.AppendNode(new object[] {
            "Кассиры"}, 8);
            this.treeList1.AppendNode(new object[] {
            "Продавцы в зале"}, 8);
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
            this.button1.Location = new System.Drawing.Point(17, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить родительское поле";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 591);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(346, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(346, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить дочернее поле";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 626);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "test project";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

