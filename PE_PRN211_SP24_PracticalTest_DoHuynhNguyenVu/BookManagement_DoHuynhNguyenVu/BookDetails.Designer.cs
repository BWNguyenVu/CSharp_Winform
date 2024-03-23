namespace BookManagement_DoHuynhNguyenVu
{
    partial class BookDetails
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
            cbBookCategoryId = new ComboBox();
            dtpPublicationDate = new DateTimePicker();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            txtBookId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblBookId = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbBookCategoryId);
            groupBox1.Controls.Add(dtpPublicationDate);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtBookName);
            groupBox1.Controls.Add(txtBookId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblBookId);
            groupBox1.Location = new Point(50, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(663, 675);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbBookCategoryId
            // 
            cbBookCategoryId.FormattingEnabled = true;
            cbBookCategoryId.Location = new Point(184, 478);
            cbBookCategoryId.Name = "cbBookCategoryId";
            cbBookCategoryId.Size = new Size(182, 33);
            cbBookCategoryId.TabIndex = 17;
            cbBookCategoryId.SelectedIndexChanged += cbBookCategoryId_SelectedIndexChanged;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Location = new Point(155, 228);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(300, 31);
            dtpPublicationDate.TabIndex = 16;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(144, 425);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(433, 31);
            txtAuthor.TabIndex = 14;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(144, 355);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(433, 31);
            txtPrice.TabIndex = 13;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(144, 294);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(433, 31);
            txtQuantity.TabIndex = 12;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(144, 168);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(433, 31);
            txtDescription.TabIndex = 10;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(144, 106);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(421, 31);
            txtBookName.TabIndex = 9;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(144, 59);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(159, 31);
            txtBookId.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 478);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 7;
            label9.Text = "BookCategoryId";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 425);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 6;
            label8.Text = "Author";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 355);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 5;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 294);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 4;
            label6.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 233);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 3;
            label5.Text = "PublicationDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 168);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 2;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 106);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 1;
            label3.Text = "Book Name";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(16, 51);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(76, 25);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "Book ID";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(761, 225);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(168, 67);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(761, 314);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(168, 67);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 45);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 5;
            label1.Text = "Update";
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 827);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "BookDetails";
            Text = "BookDetails";
            Load += BookDetails_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBookId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblBookId;
        private TextBox txtDescription;
        private TextBox txtBookName;
        private DateTimePicker dtpPublicationDate;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private ComboBox cbBookCategoryId;
    }
}