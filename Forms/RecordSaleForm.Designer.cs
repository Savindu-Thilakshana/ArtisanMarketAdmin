namespace ArtisanMarketAdmin.Forms
{
    partial class RecordSaleForm
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
            cmbProduct = new ComboBox();
            lblUnitPrice = new Label();
            lblStock = new Label();
            txtQuantity = new TextBox();
            btnRecordSale = new Button();
            btnCancel = new Button();
            SuspendLayout();
     
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 0;
            label1.Text = "Product";
         
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 70);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 1;
            label2.Text = "Unit Price:";
         
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 116);
            label3.Name = "label3";
            label3.Size = new Size(164, 28);
            label3.TabIndex = 2;
            label3.Text = "Available Stock:";
            
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 166);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(242, 23);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(189, 28);
            cmbProduct.TabIndex = 4;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(242, 70);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(0, 20);
            lblUnitPrice.TabIndex = 5;
          
            lblStock.AutoSize = true;
            lblStock.Location = new Point(242, 116);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(0, 20);
            lblStock.TabIndex = 6;
          
            txtQuantity.Location = new Point(242, 170);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(189, 27);
            txtQuantity.TabIndex = 7;
             
            btnRecordSale.BackColor = Color.Olive;
            btnRecordSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecordSale.ForeColor = Color.White;
            btnRecordSale.Location = new Point(129, 268);
            btnRecordSale.Name = "btnRecordSale";
            btnRecordSale.Size = new Size(94, 29);
            btnRecordSale.TabIndex = 8;
            btnRecordSale.Text = "Record Sale";
            btnRecordSale.UseVisualStyleBackColor = false;
            btnRecordSale.Click += btnRecordSale_Click;
            
            btnCancel.BackColor = Color.Olive;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(312, 268);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
           
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 247, 241);
            ClientSize = new Size(534, 322);
            Controls.Add(btnCancel);
            Controls.Add(btnRecordSale);
            Controls.Add(txtQuantity);
            Controls.Add(lblStock);
            Controls.Add(lblUnitPrice);
            Controls.Add(cmbProduct);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RecordSaleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Record a Sale";
            Load += RecordSaleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbProduct;
        private Label lblUnitPrice;
        private Label lblStock;
        private TextBox txtQuantity;
        private Button btnRecordSale;
        private Button btnCancel;
    }
}