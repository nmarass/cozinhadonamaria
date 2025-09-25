using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnIngrediente;
        private Button btnTipoCozinha;
        private Button btnReceita;
        private Button btnConsultaReceita;
        private Button btnVideoReceita;

        private TableLayoutPanel tlpRoot;
        private TableLayoutPanel tlpCenter;
        private FlowLayoutPanel flwMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            btnIngrediente = new Button();
            btnTipoCozinha = new Button();
            btnReceita = new Button();
            btnConsultaReceita = new Button();
            btnVideoReceita = new Button();
            tlpRoot = new TableLayoutPanel();
            tlpCenter = new TableLayoutPanel();
            flwMenu = new FlowLayoutPanel();
            SuspendLayout();
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 252);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cozinha da Dona Maria";
            MinimumSize = new Size(800, 500);
            ClientSize = new Size(900, 600);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.ColumnCount = 1;
            tlpRoot.RowCount = 1;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Controls.Add(tlpRoot);
            tlpCenter.Dock = DockStyle.Fill;
            tlpCenter.ColumnCount = 3;
            tlpCenter.RowCount = 3;
            tlpCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCenter.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCenter.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRoot.Controls.Add(tlpCenter, 0, 0);
            flwMenu.FlowDirection = FlowDirection.TopDown;
            flwMenu.WrapContents = false;
            flwMenu.AutoSize = true;
            flwMenu.Padding = new Padding(12);
            flwMenu.Margin = new Padding(12);
            flwMenu.BackColor = Color.FromArgb(235, 244, 252);
            flwMenu.BorderStyle = BorderStyle.None;
            tlpCenter.Controls.Add(flwMenu, 1, 1);
            btnIngrediente.Name = "btnIngrediente";
            btnIngrediente.Text = "Cadastrar Ingrediente";
            btnIngrediente.Width = 260;
            btnIngrediente.Height = 46;
            btnIngrediente.Margin = new Padding(12);
            btnIngrediente.FlatStyle = FlatStyle.Flat;
            btnIngrediente.FlatAppearance.BorderSize = 0;
            btnIngrediente.BackColor = Color.FromArgb(100, 181, 246);
            btnIngrediente.ForeColor = Color.White;
            btnIngrediente.Font = new Font(new FontFamily("Segoe UI"), 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnTipoCozinha.Name = "btnTipoCozinha";
            btnTipoCozinha.Text = "Tipo de Cozinha";
            btnTipoCozinha.Width = 260;
            btnTipoCozinha.Height = 46;
            btnTipoCozinha.Margin = new Padding(12);
            btnTipoCozinha.FlatStyle = FlatStyle.Flat;
            btnTipoCozinha.FlatAppearance.BorderSize = 0;
            btnTipoCozinha.BackColor = Color.FromArgb(255, 213, 79);
            btnTipoCozinha.ForeColor = Color.Black;
            btnTipoCozinha.Font = new Font(new FontFamily("Segoe UI"), 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnReceita.Name = "btnReceita";
            btnReceita.Text = "Cadastrar Receita";
            btnReceita.Width = 260;
            btnReceita.Height = 46;
            btnReceita.Margin = new Padding(12);
            btnReceita.FlatStyle = FlatStyle.Flat;
            btnReceita.FlatAppearance.BorderSize = 0;
            btnReceita.BackColor = Color.FromArgb(129, 199, 132);
            btnReceita.ForeColor = Color.White;
            btnReceita.Font = new Font(new FontFamily("Segoe UI"), 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultaReceita.Name = "btnConsultaReceita";
            btnConsultaReceita.Text = "Consultar Receita";
            btnConsultaReceita.Width = 260;
            btnConsultaReceita.Height = 46;
            btnConsultaReceita.Margin = new Padding(12);
            btnConsultaReceita.FlatStyle = FlatStyle.Flat;
            btnConsultaReceita.FlatAppearance.BorderSize = 0;
            btnConsultaReceita.BackColor = Color.FromArgb(186, 104, 200);
            btnConsultaReceita.ForeColor = Color.White;
            btnConsultaReceita.Font = new Font(new FontFamily("Segoe UI"), 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnVideoReceita.Name = "btnVideoReceita";
            btnVideoReceita.Text = "Vídeos de Receita";
            btnVideoReceita.Width = 260;
            btnVideoReceita.Height = 46;
            btnVideoReceita.Margin = new Padding(12);
            btnVideoReceita.FlatStyle = FlatStyle.Flat;
            btnVideoReceita.FlatAppearance.BorderSize = 0;
            btnVideoReceita.BackColor = Color.FromArgb(255, 138, 101);
            btnVideoReceita.ForeColor = Color.White;
            btnVideoReceita.Font = new Font(new FontFamily("Segoe UI"), 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            flwMenu.Controls.Add(btnIngrediente);
            flwMenu.Controls.Add(btnTipoCozinha);
            flwMenu.Controls.Add(btnReceita);
            flwMenu.Controls.Add(btnConsultaReceita);
            flwMenu.Controls.Add(btnVideoReceita);
            Name = "Form1";
            ResumeLayout(false);
        }
    }
}
