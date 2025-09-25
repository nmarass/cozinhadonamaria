using System;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnIngrediente.Click += BtnIngrediente_Click;
            btnTipoCozinha.Click += BtnTipoCozinha_Click;
            btnReceita.Click += BtnReceita_Click;
            btnConsultaReceita.Click += BtnConsultaReceita_Click;
            btnVideoReceita.Click += BtnVideoReceita_Click;
        }

        private void BtnVideoReceita_Click(object? sender, EventArgs e)
        {
            var form = new FormVideoReceita();
            form.Show();
        }

        private void BtnTipoCozinha_Click(object? sender, EventArgs e)
        {
            var form = new FormTipoCozinha();
            form.Show();
        }

        private void BtnReceita_Click(object? sender, EventArgs e)
        {
            var formReceita = new FormReceita();
            formReceita.Show();
        }

        private void BtnConsultaReceita_Click(object? sender, EventArgs e)
        {
            var form = new FormConsultaReceita();
            form.Show();
        }

        private void BtnIngrediente_Click(object? sender, EventArgs e)
        {
            var formIngrediente = new FormIngrediente();
            formIngrediente.Show();
        }
    }
}
