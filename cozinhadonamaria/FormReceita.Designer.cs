namespace cozinhadonamaria
{
    partial class FormReceita
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpa os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private TextBox txtNomeReceita;
        private ComboBox cmbTipoCozinha;
        private DataGridView dgvIngredientes;
        private Button btnAdicionarIngrediente;
        private Button btnSalvarReceita;

        private void InitializeComponent()
        {
            txtNomeReceita = new TextBox();
            cmbTipoCozinha = new ComboBox();
            dgvIngredientes = new DataGridView();
            btnAdicionarIngrediente = new Button();
            btnSalvarReceita = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).BeginInit();
            SuspendLayout();
            // 
            // txtNomeReceita
            // 
            txtNomeReceita.Location = new Point(20, 21);
            txtNomeReceita.Name = "txtNomeReceita";
            txtNomeReceita.PlaceholderText = "Nome da Receita";
            txtNomeReceita.Size = new Size(300, 27);
            txtNomeReceita.TabIndex = 0;
            // 
            // cmbTipoCozinha
            // 
            cmbTipoCozinha.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoCozinha.Location = new Point(340, 21);
            cmbTipoCozinha.Name = "cmbTipoCozinha";
            cmbTipoCozinha.Size = new Size(200, 28);
            cmbTipoCozinha.TabIndex = 1;
            // 
            // dgvIngredientes
            // 
            dgvIngredientes.AllowUserToAddRows = false;
            dgvIngredientes.AllowUserToDeleteRows = false;
            dgvIngredientes.ColumnHeadersHeight = 29;
            dgvIngredientes.Location = new Point(20, 67);
            dgvIngredientes.Name = "dgvIngredientes";
            dgvIngredientes.RowHeadersWidth = 51;
            dgvIngredientes.Size = new Size(400, 150);
            dgvIngredientes.TabIndex = 2;
            // 
            // btnAdicionarIngrediente
            // 
            btnAdicionarIngrediente.Location = new Point(426, 67);
            btnAdicionarIngrediente.Name = "btnAdicionarIngrediente";
            btnAdicionarIngrediente.Size = new Size(120, 30);
            btnAdicionarIngrediente.TabIndex = 3;
            btnAdicionarIngrediente.Text = "Adicionar Ingrediente";
            btnAdicionarIngrediente.UseVisualStyleBackColor = true;
            // 
            // btnSalvarReceita
            // 
            btnSalvarReceita.Location = new Point(20, 223);
            btnSalvarReceita.Name = "btnSalvarReceita";
            btnSalvarReceita.Size = new Size(200, 30);
            btnSalvarReceita.TabIndex = 4;
            btnSalvarReceita.Text = "Salvar Receita";
            btnSalvarReceita.UseVisualStyleBackColor = true;
            // 
            // FormReceita
            // 
            this.AutoScaleMode = AutoScaleMode.None; // Adicione esta linha para evitar redimensionamento automático
            this.ClientSize = new Size(600, 400);
            this.Controls.Add(txtNomeReceita);
            this.Controls.Add(cmbTipoCozinha);
            this.Controls.Add(dgvIngredientes);
            this.Controls.Add(btnAdicionarIngrediente);
            this.Controls.Add(btnSalvarReceita);
            this.MinimumSize = new Size(618, 447);
            this.Name = "FormReceita";
            this.Text = "Cadastrar Receita";
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}