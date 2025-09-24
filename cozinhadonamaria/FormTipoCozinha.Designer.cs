namespace cozinhadonamaria
{
    partial class FormTipoCozinha
    {
        private TextBox txtTipoCozinha;
        private Button btnSalvar;

        private void InitializeComponent()
        {
            txtTipoCozinha = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtTipoCozinha
            // 
            txtTipoCozinha.Location = new Point(12, 12);
            txtTipoCozinha.Name = "txtTipoCozinha";
            txtTipoCozinha.PlaceholderText = "Tipo de Cozinha";
            txtTipoCozinha.Size = new Size(200, 27);
            txtTipoCozinha.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 45);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(200, 30);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormTipoCozinha
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(829, 442);
            Controls.Add(txtTipoCozinha);
            Controls.Add(btnSalvar);
            Name = "FormTipoCozinha";
            Text = "Cadastro de Tipo de Cozinha";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}