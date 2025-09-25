using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    partial class FormIngrediente
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNome;
        private Button btnSalvarIng;
        private Button btnEditarIng;
        private Button btnExcluirIng;
        private DataGridView dgvIngredientes;

        private TableLayoutPanel tlpRoot;
        private FlowLayoutPanel flwCampos;
        private FlowLayoutPanel flwBotoes;

        private void InitializeComponent()
        {
            components = new Container();
            txtNome = new TextBox();
            btnSalvarIng = new Button();
            btnEditarIng = new Button();
            btnExcluirIng = new Button();
            dgvIngredientes = new DataGridView();
            tlpRoot = new TableLayoutPanel();
            flwCampos = new FlowLayoutPanel();
            flwBotoes = new FlowLayoutPanel();

            ((ISupportInitialize)dgvIngredientes).BeginInit();
            SuspendLayout();

            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 248, 252);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Ingrediente";
            MinimumSize = new Size(600, 450);

            tlpRoot.ColumnCount = 1;
            tlpRoot.RowCount = 3;
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.BackColor = Color.Transparent;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            flwCampos.Dock = DockStyle.Fill;
            flwCampos.Padding = new Padding(16, 16, 16, 8);
            flwCampos.AutoSize = true;
            flwCampos.WrapContents = true;
            flwCampos.BackColor = Color.FromArgb(234, 244, 252);

            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome do Ingrediente";
            txtNome.Width = 420;
            txtNome.Margin = new Padding(8);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            flwBotoes.Dock = DockStyle.Fill;
            flwBotoes.Padding = new Padding(16, 8, 16, 8);
            flwBotoes.AutoSize = true;
            flwBotoes.FlowDirection = FlowDirection.RightToLeft;
            flwBotoes.BackColor = Color.Transparent;

            btnExcluirIng.Name = "btnExcluirIng";
            btnExcluirIng.Text = "Excluir seleção";
            btnExcluirIng.Width = 140;
            btnExcluirIng.Height = 36;
            btnExcluirIng.Margin = new Padding(8);
            btnExcluirIng.FlatStyle = FlatStyle.Flat;
            btnExcluirIng.FlatAppearance.BorderSize = 0;
            btnExcluirIng.BackColor = Color.FromArgb(244, 108, 117);
            btnExcluirIng.ForeColor = Color.White;

            btnEditarIng.Name = "btnEditarIng";
            btnEditarIng.Text = "Editar seleção";
            btnEditarIng.Width = 140;
            btnEditarIng.Height = 36;
            btnEditarIng.Margin = new Padding(8);
            btnEditarIng.FlatStyle = FlatStyle.Flat;
            btnEditarIng.FlatAppearance.BorderSize = 0;
            btnEditarIng.BackColor = Color.FromArgb(255, 193, 7);
            btnEditarIng.ForeColor = Color.Black;

            btnSalvarIng.Name = "btnSalvarIng";
            btnSalvarIng.Text = "Salvar";
            btnSalvarIng.Width = 120;
            btnSalvarIng.Height = 36;
            btnSalvarIng.Margin = new Padding(8);
            btnSalvarIng.FlatStyle = FlatStyle.Flat;
            btnSalvarIng.FlatAppearance.BorderSize = 0;
            btnSalvarIng.BackColor = Color.FromArgb(76, 175, 80);
            btnSalvarIng.ForeColor = Color.White;

            dgvIngredientes.Name = "dgvIngredientes";
            dgvIngredientes.AllowUserToAddRows = false;
            dgvIngredientes.AllowUserToDeleteRows = false;
            dgvIngredientes.ReadOnly = true;
            dgvIngredientes.MultiSelect = false;
            dgvIngredientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredientes.RowHeadersVisible = false;
            dgvIngredientes.Dock = DockStyle.Fill;
            dgvIngredientes.BackgroundColor = Color.White;
            dgvIngredientes.BorderStyle = BorderStyle.None;
            dgvIngredientes.EnableHeadersVisualStyles = false;
            dgvIngredientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(222, 235, 247);
            dgvIngredientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            flwCampos.Controls.Add(txtNome);
            flwBotoes.Controls.Add(btnExcluirIng);
            flwBotoes.Controls.Add(btnEditarIng);
            flwBotoes.Controls.Add(btnSalvarIng);

            tlpRoot.Controls.Add(flwCampos, 0, 0);
            tlpRoot.Controls.Add(flwBotoes, 0, 1);
            tlpRoot.Controls.Add(dgvIngredientes, 0, 2);

            Controls.Add(tlpRoot);

            Name = "FormIngrediente";
            ClientSize = new Size(700, 500);

            ((ISupportInitialize)dgvIngredientes).EndInit();
            ResumeLayout(false);
        }
    }
}