namespace test1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label проффесияLabel;
            System.Windows.Forms.Label зПLabel;
            System.Windows.Forms.Label полLabel;
            this.database1DataSet = new test1.Database1DataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new test1.Database1DataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new test1.Database1DataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.фИОTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.дата_рожденияTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.проффесияTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.зПTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.полTextEdit = new DevExpress.XtraEditors.TextEdit();
            idLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            проффесияLabel = new System.Windows.Forms.Label();
            зПLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фИОTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дата_рожденияTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проффесияTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зПTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.полTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(25, 25);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 13;
            idLabel.Text = "Id:";
            // 
            // idSpinEdit
            // 
            this.idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tableBindingSource, "Id", true));
            this.idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idSpinEdit.Location = new System.Drawing.Point(120, 22);
            this.idSpinEdit.Name = "idSpinEdit";
            this.idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.idSpinEdit.TabIndex = 14;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(25, 51);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 15;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextEdit
            // 
            this.фИОTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tableBindingSource, "ФИО", true));
            this.фИОTextEdit.Location = new System.Drawing.Point(120, 48);
            this.фИОTextEdit.Name = "фИОTextEdit";
            this.фИОTextEdit.Size = new System.Drawing.Size(100, 20);
            this.фИОTextEdit.TabIndex = 16;
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(25, 77);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 17;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // дата_рожденияTextEdit
            // 
            this.дата_рожденияTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tableBindingSource, "Дата рождения", true));
            this.дата_рожденияTextEdit.Location = new System.Drawing.Point(120, 74);
            this.дата_рожденияTextEdit.Name = "дата_рожденияTextEdit";
            this.дата_рожденияTextEdit.Size = new System.Drawing.Size(100, 20);
            this.дата_рожденияTextEdit.TabIndex = 18;
            // 
            // проффесияLabel
            // 
            проффесияLabel.AutoSize = true;
            проффесияLabel.Location = new System.Drawing.Point(25, 103);
            проффесияLabel.Name = "проффесияLabel";
            проффесияLabel.Size = new System.Drawing.Size(70, 13);
            проффесияLabel.TabIndex = 19;
            проффесияLabel.Text = "Проффесия:";
            // 
            // проффесияTextEdit
            // 
            this.проффесияTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tableBindingSource, "Проффесия", true));
            this.проффесияTextEdit.Location = new System.Drawing.Point(120, 100);
            this.проффесияTextEdit.Name = "проффесияTextEdit";
            this.проффесияTextEdit.Size = new System.Drawing.Size(100, 20);
            this.проффесияTextEdit.TabIndex = 20;
            // 
            // зПLabel
            // 
            зПLabel.AutoSize = true;
            зПLabel.Location = new System.Drawing.Point(25, 129);
            зПLabel.Name = "зПLabel";
            зПLabel.Size = new System.Drawing.Size(25, 13);
            зПLabel.TabIndex = 21;
            зПLabel.Text = "ЗП:";
            // 
            // зПTextEdit
            // 
            this.зПTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tableBindingSource, "ЗП", true));
            this.зПTextEdit.Location = new System.Drawing.Point(120, 126);
            this.зПTextEdit.Name = "зПTextEdit";
            this.зПTextEdit.Size = new System.Drawing.Size(100, 20);
            this.зПTextEdit.TabIndex = 22;
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(25, 155);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 23;
            полLabel.Text = "Пол:";
            // 
            // полTextEdit
            // 
            this.полTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tableBindingSource, "Пол", true));
            this.полTextEdit.Location = new System.Drawing.Point(120, 152);
            this.полTextEdit.Name = "полTextEdit";
            this.полTextEdit.Size = new System.Drawing.Size(100, 20);
            this.полTextEdit.TabIndex = 24;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 349);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idSpinEdit);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextEdit);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияTextEdit);
            this.Controls.Add(проффесияLabel);
            this.Controls.Add(this.проффесияTextEdit);
            this.Controls.Add(зПLabel);
            this.Controls.Add(this.зПTextEdit);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextEdit);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form4";
            this.Text = "add node for table";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фИОTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дата_рожденияTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проффесияTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зПTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.полTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SpinEdit idSpinEdit;
        private DevExpress.XtraEditors.TextEdit фИОTextEdit;
        private DevExpress.XtraEditors.TextEdit дата_рожденияTextEdit;
        private DevExpress.XtraEditors.TextEdit проффесияTextEdit;
        private DevExpress.XtraEditors.TextEdit зПTextEdit;
        private DevExpress.XtraEditors.TextEdit полTextEdit;
    }
}