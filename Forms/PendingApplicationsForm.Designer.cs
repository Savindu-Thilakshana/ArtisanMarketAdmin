namespace ArtisanMarketAdmin.Forms
{
    partial class PendingApplicationsForm
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
            dgvPending = new DataGridView();
            btnApprove = new Button();
            btnReject = new Button();
            btnRegisterNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPending).BeginInit();
            SuspendLayout();
           
            dgvPending.AllowUserToAddRows = false;
            dgvPending.AllowUserToDeleteRows = false;
            dgvPending.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPending.Location = new Point(12, 32);
            dgvPending.Name = "dgvPending";
            dgvPending.ReadOnly = true;
            dgvPending.RowHeadersVisible = false;
            dgvPending.RowHeadersWidth = 51;
            dgvPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPending.Size = new Size(658, 303);
            dgvPending.TabIndex = 0;
           
            btnApprove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnApprove.BackColor = Color.Olive;
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(41, 362);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(94, 29);
            btnApprove.TabIndex = 1;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
           
            btnReject.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReject.BackColor = Color.Olive;
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(186, 362);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(94, 29);
            btnReject.TabIndex = 2;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
           
            btnRegisterNew.BackColor = Color.Olive;
            btnRegisterNew.ForeColor = Color.White;
            btnRegisterNew.Location = new Point(465, 362);
            btnRegisterNew.Name = "btnRegisterNew";
            btnRegisterNew.Size = new Size(188, 29);
            btnRegisterNew.TabIndex = 3;
            btnRegisterNew.Text = "Register New Artisan";
            btnRegisterNew.UseVisualStyleBackColor = false;
            btnRegisterNew.Click += btnRegisterNew_Click;
           
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 247, 241);
            ClientSize = new Size(682, 403);
            Controls.Add(btnRegisterNew);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(dgvPending);
            Name = "PendingApplicationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pending Artisan Applications";
            Load += PendingApplicationsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPending).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPending;
        private Button btnApprove;
        private Button btnReject;
        private Button btnRegisterNew;
    }
}