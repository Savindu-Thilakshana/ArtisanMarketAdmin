namespace ArtisanMarketAdmin.Forms
{
    partial class AddItemForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            cmbCategory = new ComboBox();
            cmbArtisan = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
           
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(27, 71);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Price:";
            
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(27, 117);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Stock:";
           
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(27, 161);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(27, 209);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Artisan:";
            
            txtName.Location = new Point(131, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 27);
            txtName.TabIndex = 5;
           
            txtPrice.Location = new Point(131, 71);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(246, 27);
            txtPrice.TabIndex = 6;
            
            txtStock.Location = new Point(131, 117);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(246, 27);
            txtStock.TabIndex = 7;
            
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Home Decor", "Clothing", "Jewelry", "Pottery", "Woodwork" });
            cmbCategory.Location = new Point(131, 158);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(184, 28);
            cmbCategory.TabIndex = 8;
           
            cmbArtisan.FormattingEnabled = true;
            cmbArtisan.Location = new Point(131, 209);
            cmbArtisan.Name = "cmbArtisan";
            cmbArtisan.Size = new Size(184, 28);
            cmbArtisan.TabIndex = 9;
           
            btnSave.BackColor = Color.Olive;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(64, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
           
            btnCancel.BackColor = Color.Olive;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(188, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
             
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "AddItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Craft Item";
            Load += AddItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private ComboBox cmbCategory;
        private ComboBox cmbArtisan;
        private Button btnSave;
        private Button btnCancel;
    }
}