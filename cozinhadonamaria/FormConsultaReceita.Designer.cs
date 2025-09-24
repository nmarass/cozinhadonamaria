namespace cozinhadonamaria
{
    partial class FormConsultaReceita
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

        private TextBox txtBusca;
        private Button btnBuscar;
        private DataGridView dgvReceitas;
        private Button btnVisualizar;

        private void InitializeComponent()
        {
            this.txtBusca = new TextBox();
            this.btnBuscar = new Button();
            this.dgvReceitas = new DataGridView();
            this.btnVisualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(20, 20);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Buscar Receita";
            this.txtBusca.Size = new System.Drawing.Size(200, 23);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(230, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 23);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvReceitas
            // 
            this.dgvReceitas.Location = new System.Drawing.Point(20, 60);
            this.dgvReceitas.Name = "dgvReceitas";
            this.dgvReceitas.Size = new System.Drawing.Size(400, 200);
            this.dgvReceitas.ReadOnly = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(20, 270);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(120, 30);
            this.btnVisualizar.Text = "Visualizar Detalhes";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // FormConsultaReceita
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvReceitas);
            this.Controls.Add(this.btnVisualizar);
            this.Name = "FormConsultaReceita";
            this.Text = "Consultar Receita";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}