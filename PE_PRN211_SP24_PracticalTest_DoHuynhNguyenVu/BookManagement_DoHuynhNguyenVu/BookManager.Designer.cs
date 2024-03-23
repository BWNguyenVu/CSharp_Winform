namespace BookManagement_DoHuynhNguyenVu
{
    partial class BookManager
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            lblDescription = new Label();
            lblBookName = new Label();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            dgvTable = new DataGridView();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblDescription);
            groupBox1.Controls.Add(lblBookName);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtBookName);
            groupBox1.Location = new Point(60, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(925, 211);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(663, 51);
            button1.Name = "button1";
            button1.Size = new Size(138, 98);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(38, 124);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(38, 71);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(105, 25);
            lblBookName.TabIndex = 2;
            lblBookName.Text = "Book Name";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(274, 118);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(304, 31);
            txtDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(274, 55);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(304, 31);
            txtBookName.TabIndex = 0;
            // 
            // dgvTable
            // 
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new Point(60, 375);
            dgvTable.Name = "dgvTable";
            dgvTable.RowHeadersWidth = 62;
            dgvTable.Size = new Size(920, 266);
            dgvTable.TabIndex = 1;
            dgvTable.CellContentClick += dgvTable_CellContentClick;
            dgvTable.Click += dgvTable_SelectionChanged;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1005, 376);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(240, 67);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1005, 574);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(240, 67);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1005, 473);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(240, 67);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // BookManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 771);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(dgvTable);
            Controls.Add(groupBox1);
            Name = "BookManager";
            Text = "BookManager";
            Load += BookManager_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label lblDescription;
        private Label lblBookName;
        private TextBox txtDescription;
        private TextBox txtBookName;
        private DataGridView dgvTable;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
    }
}