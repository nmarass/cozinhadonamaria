using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    public partial class FormReceita : Form
    {
        // Exemplo: Receba dados de outro formulário via construtor
        private string tipoCozinhaSelecionado;

        public FormReceita(string tipoCozinha)
        {
            InitializeComponent();
            tipoCozinhaSelecionado = tipoCozinha;
            // Use tipoCozinhaSelecionado conforme necessário
        }

        public FormReceita()
        {
            InitializeComponent();
            tipoCozinhaSelecionado = string.Empty; // Valor padrão para evitar CS8618
            btnAdicionarIngrediente.Click += BtnAdicionarIngrediente_Click;
            btnSalvarReceita.Click += BtnSalvarReceita_Click;
            cmbTipoCozinha.DataSource = DataStore.TiposCozinha;
        }

        private List<Ingrediente> ingredientesReceita = new();

        private void BtnAdicionarIngrediente_Click(object? sender, EventArgs e)
        {
            // Exemplo: Adiciona ingrediente selecionado da lista global
            if (DataStore.Ingredientes.Count > 0)
            {
                var ingrediente = DataStore.Ingredientes[0]; // Substitua por seleção real
                ingredientesReceita.Add(ingrediente);
                dgvIngredientes.Rows.Add(ingrediente.Nome, ingrediente.Quantidade, ingrediente.Unidade);
            }
            else
            {
                MessageBox.Show("Cadastre ingredientes primeiro.");
            }
        }

        private void BtnSalvarReceita_Click(object? sender, EventArgs e)
        {
            var nome = txtNomeReceita.Text.Trim();
            var tipo = cmbTipoCozinha.Text;

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(tipo) && ingredientesReceita.Count > 0)
            {
                DataStore.Receitas.Add(new Receita
                {
                    Nome = nome,
                    TipoCozinha = tipo,
                    Ingredientes = new List<Ingrediente>(ingredientesReceita)
                });
                MessageBox.Show("Receita salva com sucesso!");
                txtNomeReceita.Clear();
                ingredientesReceita.Clear();
                dgvIngredientes.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos e adicione pelo menos um ingrediente.");
            }
        }
    }
}