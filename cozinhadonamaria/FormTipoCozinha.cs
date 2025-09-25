using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    public partial class FormTipoCozinha : Form
    {
        public FormTipoCozinha()
        {
            InitializeComponent();
            btnSalvar.Click += BtnSalvar_Click;
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            var tipo = txtTipoCozinha.Text.Trim();
            if (!string.IsNullOrEmpty(tipo) && !DataStore.TiposCozinha.Contains(tipo))
            {
                DataStore.TiposCozinha.Add(tipo);
                MessageBox.Show("Tipo de cozinha salvo com sucesso!");
                txtTipoCozinha.Clear();
            }
            else
            {
                MessageBox.Show("Informe um tipo válido e não duplicado.");
            }
        }

        public string NomeTipoCozinha
        {
            get { return txtTipoCozinha.Text; }
        }
    }

    public class Ingrediente
    {
        public string Nome { get; set; } = "";
        public string Unidade { get; set; } = "";
        public decimal Quantidade { get; set; }
    }

    public class Receita
    {
        public string Nome { get; set; } = "";
        public string TipoCozinha { get; set; } = "";
        public List<Ingrediente> Ingredientes { get; set; } = new();
    }

    public static class DataStore
    {
        public static List<string> TiposCozinha { get; } = new();
        public static List<Ingrediente> Ingredientes { get; } = new();
        public static List<Receita> Receitas { get; } = new();
    }
}