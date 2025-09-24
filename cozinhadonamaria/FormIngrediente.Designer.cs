namespace cozinhadonamaria
{
    partial class FormIngrediente
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNome;
        private ComboBox cmbUnidade;
        private NumericUpDown numQuantidade;
        private Button btnSalvar;

        private void InitializeComponent()
        {
            this.txtNome = new TextBox();
            this.cmbUnidade = new ComboBox();
            this.numQuantidade = new NumericUpDown();
            this.btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome do Ingrediente";
            this.txtNome.Size = new System.Drawing.Size(200, 23);
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbUnidade.Items.AddRange(new object[] { "Gramas", "Mililitros", "Unidades" });
            this.cmbUnidade.Location = new System.Drawing.Point(20, 60);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(120, 23);
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(160, 60);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(60, 23);
            this.numQuantidade.Maximum = decimal.MaxValue; // Permite valor praticamente ilimitado
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(20, 100);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 30);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormIngrediente
            // 
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbUnidade);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FormIngrediente";
            this.Text = "Cadastrar Ingrediente";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}