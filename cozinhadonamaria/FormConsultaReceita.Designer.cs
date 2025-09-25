using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    partial class FormConsultaReceita
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtBusca;
        private Button btnBuscar;
        private DataGridView dgvReceitas;
        private Button btnVisualizar;

        private TableLayoutPanel tlpRoot;
        private FlowLayoutPanel flwBusca;
        private FlowLayoutPanel flwRodape;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            txtBusca = new TextBox();
            btnBuscar = new Button();
            dgvReceitas = new DataGridView();
            btnVisualizar = new Button();

            tlpRoot = new TableLayoutPanel();
            flwBusca = new FlowLayoutPanel();
            flwRodape = new FlowLayoutPanel();

            ((ISupportInitialize)dgvReceitas).BeginInit();
            SuspendLayout();

            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 252, 248);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Receita";
            MinimumSize = new Size(800, 550);

            tlpRoot.ColumnCount = 1;
            tlpRoot.RowCount = 3;
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            flwBusca.Dock = DockStyle.Fill;
            flwBusca.Padding = new Padding(16, 16, 16, 8);
            flwBusca.AutoSize = true;
            flwBusca.WrapContents = false;
            flwBusca.BackColor = Color.FromArgb(232, 245, 233);

            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Buscar Receita";
            txtBusca.Width = 360;
            txtBusca.Margin = new Padding(8);
            txtBusca.BorderStyle = BorderStyle.FixedSingle;
            txtBusca.Font = new Font("Segoe UI", 10F);

            btnBuscar.Name = "btnBuscar";
            btnBuscar.Text = "Buscar";
            btnBuscar.Width = 110;
            btnBuscar.Height = 36;
            btnBuscar.Margin = new Padding(8);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.BackColor = Color.FromArgb(100, 181, 246);
            btnBuscar.ForeColor = Color.White;

            dgvReceitas.Name = "dgvReceitas";
            dgvReceitas.Dock = DockStyle.Fill;
            dgvReceitas.ReadOnly = true;
            dgvReceitas.MultiSelect = false;
            dgvReceitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceitas.RowHeadersVisible = false;
            dgvReceitas.BackgroundColor = Color.White;
            dgvReceitas.BorderStyle = BorderStyle.None;
            dgvReceitas.EnableHeadersVisualStyles = false;
            dgvReceitas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 244, 226);
            dgvReceitas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            flwRodape.Dock = DockStyle.Fill;
            flwRodape.Padding = new Padding(16, 8, 16, 16);
            flwRodape.AutoSize = true;
            flwRodape.FlowDirection = FlowDirection.RightToLeft;

            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Text = "Visualizar Detalhes";
            btnVisualizar.Width = 160;
            btnVisualizar.Height = 38;
            btnVisualizar.Margin = new Padding(8);
            btnVisualizar.FlatStyle = FlatStyle.Flat;
            btnVisualizar.FlatAppearance.BorderSize = 0;
            btnVisualizar.BackColor = Color.FromArgb(76, 175, 80);
            btnVisualizar.ForeColor = Color.White;

            flwBusca.Controls.Add(txtBusca);
            flwBusca.Controls.Add(btnBuscar);

            flwRodape.Controls.Add(btnVisualizar);

            tlpRoot.Controls.Add(flwBusca, 0, 0);
            tlpRoot.Controls.Add(dgvReceitas, 0, 1);
            tlpRoot.Controls.Add(flwRodape, 0, 2);

            Controls.Add(tlpRoot);

            Name = "FormConsultaReceita";
            ClientSize = new Size(900, 600);

            ((ISupportInitialize)dgvReceitas).EndInit();
            ResumeLayout(false);
        }
    }
}