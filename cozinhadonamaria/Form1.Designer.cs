namespace cozinhadonamaria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button btnIngrediente;
        private Button btnTipoCozinha;
        private Button btnReceita;
        private Button btnConsultaReceita;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngrediente = new Button();
            this.btnTipoCozinha = new Button();
            this.btnReceita = new Button();
            this.btnConsultaReceita = new Button();
            this.SuspendLayout();
            // 
            // btnIngrediente
            // 
            this.btnIngrediente.Location = new System.Drawing.Point(30, 30);
            this.btnIngrediente.Name = "btnIngrediente";
            this.btnIngrediente.Size = new System.Drawing.Size(200, 40);
            this.btnIngrediente.Text = "Cadastrar Ingrediente";
            this.btnIngrediente.UseVisualStyleBackColor = true;
            // 
            // btnTipoCozinha
            // 
            this.btnTipoCozinha.Location = new System.Drawing.Point(30, 80);
            this.btnTipoCozinha.Name = "btnTipoCozinha";
            this.btnTipoCozinha.Size = new System.Drawing.Size(200, 40);
            this.btnTipoCozinha.Text = "Tipo de Cozinha";
            this.btnTipoCozinha.UseVisualStyleBackColor = true;
            // 
            // btnReceita
            // 
            this.btnReceita.Location = new System.Drawing.Point(30, 130);
            this.btnReceita.Name = "btnReceita";
            this.btnReceita.Size = new System.Drawing.Size(200, 40);
            this.btnReceita.Text = "Cadastrar Receita";
            this.btnReceita.UseVisualStyleBackColor = true;
            // 
            // btnConsultaReceita
            // 
            this.btnConsultaReceita.Location = new System.Drawing.Point(30, 180);
            this.btnConsultaReceita.Name = "btnConsultaReceita";
            this.btnConsultaReceita.Size = new System.Drawing.Size(200, 40);
            this.btnConsultaReceita.Text = "Consultar Receita";
            this.btnConsultaReceita.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngrediente);
            this.Controls.Add(this.btnTipoCozinha);
            this.Controls.Add(this.btnReceita);
            this.Controls.Add(this.btnConsultaReceita);
            this.Name = "Form1";
            this.Text = "Cozinha da Dona Maria";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
