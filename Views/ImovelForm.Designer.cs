namespace TP_POO_R.Views
{
    partial class ImovelForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemover;

        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
            btnRemover = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(191, 159);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(776, 396);
            dataGridView.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Depth = 0;
            btnAdicionar.Location = new Point(653, 83);
            btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Primary = true;
            btnAdicionar.Size = new Size(129, 43);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Depth = 0;
            btnRemover.Location = new Point(837, 83);
            btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemover.Name = "btnRemover";
            btnRemover.Primary = true;
            btnRemover.Size = new Size(130, 43);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // ImovelForm
            // 
            ClientSize = new Size(1088, 579);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(dataGridView);
            Name = "ImovelForm";
            Load += ImovelForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }
    }
}
