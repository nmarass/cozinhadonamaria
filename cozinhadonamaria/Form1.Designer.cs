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

            void EstilizarBotao(Button b, Color back, Color fore)
            {
                b.Width = 260;
                b.Height = 46;
                b.Margin = new Padding(12);
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = back;
                b.ForeColor = fore;
                b.Font = new Font(new FontFamily("Segoe UI"), 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            }

            btnIngrediente.Name = "btnIngrediente";
            btnIngrediente.Text = "Cadastrar Ingrediente";
            EstilizarBotao(btnIngrediente, Color.FromArgb(100, 181, 246), Color.White);

            btnTipoCozinha.Name = "btnTipoCozinha";
            btnTipoCozinha.Text = "Tipo de Cozinha";
            EstilizarBotao(btnTipoCozinha, Color.FromArgb(255, 213, 79), Color.Black);

            btnReceita.Name = "btnReceita";
            btnReceita.Text = "Cadastrar Receita";
            EstilizarBotao(btnReceita, Color.FromArgb(129, 199, 132), Color.White);

            btnConsultaReceita.Name = "btnConsultaReceita";
            btnConsultaReceita.Text = "Consultar Receita";
            EstilizarBotao(btnConsultaReceita, Color.FromArgb(186, 104, 200), Color.White);

            btnVideoReceita.Name = "btnVideoReceita";
            btnVideoReceita.Text = "Vídeos de Receita";
            EstilizarBotao(btnVideoReceita, Color.FromArgb(255, 138, 101), Color.White);

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
