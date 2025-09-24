using System;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    public partial class FormIngrediente : Form
    {
        public FormIngrediente()
        {
            InitializeComponent();
            // Remova a linha abaixo se o evento já estiver associado pelo designer
            // btnSalvar.Click += BtnSalvar_Click;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text.Trim();
            var unidade = cmbUnidade.Text;
            var quantidade = numQuantidade.Value;

            if (!string.IsNullOrEmpty(nome))
            {
                DataStore.Ingredientes.Add(new Ingrediente
                {
                    Nome = nome,
                    Unidade = unidade,
                    Quantidade = quantidade
                });
                MessageBox.Show("Ingrediente salvo com sucesso!");
                txtNome.Clear();
                numQuantidade.Value = 0;
                cmbUnidade.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Informe um nome válido para o ingrediente.");
            }
        }
    }
}