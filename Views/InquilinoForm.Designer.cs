namespace TP_POO_R.Views
{
    partial class InquilinoForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemover;
        private System.Windows.Forms.DataGridView dataGridView;

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
            btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
            btnRemover = new MaterialSkin.Controls.MaterialRaisedButton();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Depth = 0;
            btnAdicionar.Location = new Point(377, 79);
            btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Primary = true;
            btnAdicionar.Size = new Size(100, 36);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Depth = 0;
            btnRemover.Location = new Point(522, 79);
            btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemover.Name = "btnRemover";
            btnRemover.Primary = true;
            btnRemover.Size = new Size(100, 36);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // dataGridView
            // 
            dataGridView.Location = new Point(41, 139);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(612, 300);
            dataGridView.TabIndex = 2;
            // 
            // InquilinoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 488);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(dataGridView);
            Name = "InquilinoForm";
            Text = "Gestão de Inquilinos";
            Load += InquilinoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }
        #endregion
    }
}
