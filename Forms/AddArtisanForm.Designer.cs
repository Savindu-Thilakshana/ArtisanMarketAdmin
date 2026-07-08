namespace ArtisanMarketAdmin.Forms
{
    partial class AddArtisanForm
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
           
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
           
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(24, 123);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Contact:";
            
            txtName.Location = new Point(128, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 27);
            txtName.TabIndex = 3;
           
            txtEmail.Location = new Point(128, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 27);
            txtEmail.TabIndex = 4;
           
            txtContact.Location = new Point(128, 120);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(216, 27);
            txtContact.TabIndex = 5;
            
            btnSave.BackColor = Color.Olive;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(69, 202);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Register";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            
            btnCancel.BackColor = Color.Olive;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(191, 202);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 247, 241);
            ClientSize = new Size(382, 253);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddArtisanForm";
            Text = "Register New Artisan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtContact;
        private Button btnSave;
        private Button btnCancel;
    }
}