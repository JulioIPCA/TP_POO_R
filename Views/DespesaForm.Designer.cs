namespace TP_POO_R.Views
{
    partial class DespesaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            btnAdicionar = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(31, 149);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(870, 369);
            dataGridView.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(680, 116);
            btnAdicionar.Margin = new Padding(4, 3, 4, 3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(88, 27);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(794, 116);
            btnRemover.Margin = new Padding(4, 3, 4, 3);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(88, 27);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // DespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 532);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(dataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DespesaForm";
            Text = "Gerenciar Despesas";
            Load += DespesaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }
    }
}
