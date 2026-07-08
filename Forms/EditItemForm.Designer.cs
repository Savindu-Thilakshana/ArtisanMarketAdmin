namespace ArtisanMarketAdmin.Forms
{
    partial class EditItemForm
    {
       
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

      
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnSave = new Button();
            cmbArtisan = new ComboBox();
            cmbCategory = new ComboBox();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
          
            btnCancel.BackColor = Color.Olive;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(187, 254);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
          
            btnSave.BackColor = Color.Olive;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(63, 254);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
           
            cmbArtisan.FormattingEnabled = true;
            cmbArtisan.Location = new Point(130, 201);
            cmbArtisan.Name = "cmbArtisan";
            cmbArtisan.Size = new Size(184, 28);
            cmbArtisan.TabIndex = 21;
           
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Home Decor", "Clothing", "Jewelry", "Pottery", "Woodwork" });
            cmbCategory.Location = new Point(130, 150);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(184, 28);
            cmbCategory.TabIndex = 20;
           
            txtStock.Location = new Point(130, 109);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(246, 27);
            txtStock.TabIndex = 19;
           
            txtPrice.Location = new Point(130, 63);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(246, 27);
            txtPrice.TabIndex = 18;
            
            txtName.Location = new Point(130, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 27);
            txtName.TabIndex = 17;
          
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(26, 201);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 16;
            label5.Text = "Artisan:";
            
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(26, 153);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 15;
            label4.Text = "Category:";
           
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(26, 109);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 14;
            label3.Text = "Stock:";
         
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 63);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 13;
            label2.Text = "Price:";
           
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 12;
            label1.Text = "Name:";
           
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 247, 241);
            ClientSize = new Size(402, 303);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbArtisan);
            Controls.Add(cmbCategory);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EditItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Item";
            Load += EditItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private ComboBox cmbArtisan;
        private ComboBox cmbCategory;
        private TextBox txtStock;
        private TextBox txtPrice;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}