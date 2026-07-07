namespace ArtisanMarketAdmin.Forms
{
    partial class ItemListForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtSearchName = new TextBox();
            btnSearch = new Button();
            dgvItems = new DataGridView();
            btnAddNew = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            productBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
           
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(64, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Search:";
          
            txtSearchName.Location = new Point(126, 46);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(165, 27);
            txtSearchName.TabIndex = 1;
           
            btnSearch.BackColor = Color.Coral;
            btnSearch.Location = new Point(329, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = " Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
           
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(12, 111);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(758, 272);
            dgvItems.TabIndex = 4;
             
            btnAddNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNew.BackColor = Color.Olive;
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Location = new Point(35, 401);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(155, 40);
            btnAddNew.TabIndex = 5;
            btnAddNew.Text = "Add New Item";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
             
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.BackColor = Color.Olive;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(196, 401);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(155, 40);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit Selected";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
           
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.Olive;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(357, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
           
            productBindingSource.DataSource = typeof(Models.Product);
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 247, 241);
            ClientSize = new Size(782, 453);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAddNew);
            Controls.Add(dgvItems);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchName);
            Controls.Add(label1);
            Name = "ItemListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Items";
            Load += ItemListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearchName;
        private Button btnSearch;
        private DataGridView dgvItems;
        private Button btnAddNew;
        private Button btnEdit;
        private Button btnDelete;
        private BindingSource productBindingSource;
    }
}