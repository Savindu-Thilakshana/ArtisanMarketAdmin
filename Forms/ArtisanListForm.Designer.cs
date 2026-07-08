namespace ArtisanMarketAdmin.Forms
{
    partial class ArtisanListForm
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
            dgvArtisans = new DataGridView();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArtisans).BeginInit();
            SuspendLayout();
            
            dgvArtisans.AllowUserToAddRows = false;
            dgvArtisans.AllowUserToDeleteRows = false;
            dgvArtisans.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArtisans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtisans.Location = new Point(12, 22);
            dgvArtisans.Name = "dgvArtisans";
            dgvArtisans.ReadOnly = true;
            dgvArtisans.RowHeadersVisible = false;
            dgvArtisans.RowHeadersWidth = 51;
            dgvArtisans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtisans.Size = new Size(658, 314);
            dgvArtisans.TabIndex = 0;
           
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.BackColor = Color.Olive;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(551, 362);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
           
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 403);
            Controls.Add(btnRefresh);
            Controls.Add(dgvArtisans);
            Name = "ArtisanListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registered Artisans";
            Load += ArtisanListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArtisans).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvArtisans;
        private Button btnRefresh;
    }
}