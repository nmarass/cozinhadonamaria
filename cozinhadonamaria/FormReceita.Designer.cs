using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    partial class FormReceita
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNomeReceita;
        private ComboBox cmbTipoCozinha;
        private Button btnAdicionarIngrediente;
        private Button btnSalvarReceita;
        private DataGridView dgvIngredientes;

        private TableLayoutPanel tlpRoot;
        private FlowLayoutPanel flwCampos;
        private FlowLayoutPanel flwBotoes;
        private Label lblNome;
        private Label lblTipo;

        private void InitializeComponent()
        {
            components = new Container();
            txtNomeReceita = new TextBox();
            cmbTipoCozinha = new ComboBox();
            btnAdicionarIngrediente = new Button();
            btnSalvarReceita = new Button();
            dgvIngredientes = new DataGridView();

            tlpRoot = new TableLayoutPanel();
            flwCampos = new FlowLayoutPanel();
            flwBotoes = new FlowLayoutPanel();
            lblNome = new Label();
            lblTipo = new Label();

            ((ISupportInitialize)dgvIngredientes).BeginInit();
            SuspendLayout();

            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 250, 246);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Receita";
            MinimumSize = new Size(800, 550);

            tlpRoot.ColumnCount = 1;
            tlpRoot.RowCount = 3;
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            flwCampos.Dock = DockStyle.Fill;
            flwCampos.Padding = new Padding(16, 16, 16, 8);
            flwCampos.AutoSize = true;
            flwCampos.WrapContents = true;
            flwCampos.BackColor = Color.FromArgb(255, 245, 230);

            lblNome.Text = "Nome:";
            lblNome.AutoSize = true;
            lblNome.Margin = new Padding(8, 12, 4, 8);

            txtNomeReceita.Name = "txtNomeReceita";
            txtNomeReceita.Width = 320;
            txtNomeReceita.Margin = new Padding(4, 8, 16, 8);
            txtNomeReceita.BorderStyle = BorderStyle.FixedSingle;
            txtNomeReceita.Font = new Font("Segoe UI", 10F);

            lblTipo.Text = "Tipo de Cozinha:";
            lblTipo.AutoSize = true;
            lblTipo.Margin = new Padding(8, 12, 4, 8);

            cmbTipoCozinha.Name = "cmbTipoCozinha";
            cmbTipoCozinha.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoCozinha.Width = 220;
            cmbTipoCozinha.Margin = new Padding(4, 8, 16, 8);

            flwBotoes.Dock = DockStyle.Fill;
            flwBotoes.Padding = new Padding(16, 8, 16, 8);
            flwBotoes.AutoSize = true;
            flwBotoes.FlowDirection = FlowDirection.RightToLeft;

            btnSalvarReceita.Name = "btnSalvarReceita";
            btnSalvarReceita.Text = "Salvar Receita";
            btnSalvarReceita.Width = 150;
            btnSalvarReceita.Height = 38;
            btnSalvarReceita.Margin = new Padding(8);
            btnSalvarReceita.FlatStyle = FlatStyle.Flat;
            btnSalvarReceita.FlatAppearance.BorderSize = 0;
            btnSalvarReceita.BackColor = Color.FromArgb(76, 175, 80);
            btnSalvarReceita.ForeColor = Color.White;

            btnAdicionarIngrediente.Name = "btnAdicionarIngrediente";
            btnAdicionarIngrediente.Text = "Adicionar Ingrediente";
            btnAdicionarIngrediente.Width = 190;
            btnAdicionarIngrediente.Height = 38;
            btnAdicionarIngrediente.Margin = new Padding(8);
            btnAdicionarIngrediente.FlatStyle = FlatStyle.Flat;
            btnAdicionarIngrediente.FlatAppearance.BorderSize = 0;
            btnAdicionarIngrediente.BackColor = Color.FromArgb(100, 181, 246);
            btnAdicionarIngrediente.ForeColor = Color.White;

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
            dgvIngredientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 236, 220);
            dgvIngredientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            flwCampos.Controls.Add(lblNome);
            flwCampos.Controls.Add(txtNomeReceita);
            flwCampos.Controls.Add(lblTipo);
            flwCampos.Controls.Add(cmbTipoCozinha);

            flwBotoes.Controls.Add(btnSalvarReceita);
            flwBotoes.Controls.Add(btnAdicionarIngrediente);

            tlpRoot.Controls.Add(flwCampos, 0, 0);
            tlpRoot.Controls.Add(flwBotoes, 0, 1);
            tlpRoot.Controls.Add(dgvIngredientes, 0, 2);

            Controls.Add(tlpRoot);

            Name = "FormReceita";
            ClientSize = new Size(900, 600);

            ((ISupportInitialize)dgvIngredientes).EndInit();
            ResumeLayout(false);
        }
    }
}