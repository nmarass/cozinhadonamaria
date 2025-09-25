using System;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    public partial class FormIngrediente : Form
    {
        private int? indexEmEdicao = null;

        public FormIngrediente()
        {
            InitializeComponent();
            btnSalvarIng.Click += BtnSalvarIng_Click;
            btnEditarIng.Click += BtnEditarIng_Click;
            btnExcluirIng.Click += BtnExcluirIng_Click;
            Load += (_, __) => PopularGrid();
        }

        private void PopularGrid()
        {
            dgvIngredientes.AutoGenerateColumns = false;
            dgvIngredientes.Columns.Clear();
            dgvIngredientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNome",
                HeaderText = "Nome",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvIngredientes.Rows.Clear();
            foreach (var ing in DataStore.Ingredientes)
            {
                dgvIngredientes.Rows.Add(ing.Nome);
            }
        }

        private void BtnSalvarIng_Click(object? sender, EventArgs e)
        {
            var nome = txtNome.Text.Trim();

            if (!string.IsNullOrEmpty(nome))
            {
                if (indexEmEdicao.HasValue && indexEmEdicao.Value >= 0 && indexEmEdicao.Value < DataStore.Ingredientes.Count)
                {
                    var ing = DataStore.Ingredientes[indexEmEdicao.Value];
                    ing.Nome = nome;
                    indexEmEdicao = null;
                }
                else
                {
                    DataStore.Ingredientes.Add(new Ingrediente
                    {
                        Nome = nome
                    });
                }

                MessageBox.Show("Ingrediente salvo com sucesso!");
                txtNome.Clear();
                PopularGrid();
            }
            else
            {
                MessageBox.Show("Informe um nome válido para o ingrediente.");
            }
        }

        private void BtnEditarIng_Click(object? sender, EventArgs e)
        {
            if (dgvIngredientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um ingrediente para editar.");
                return;
            }
            var idx = dgvIngredientes.CurrentRow.Index;
            if (idx < 0 || idx >= DataStore.Ingredientes.Count) return;

            var ing = DataStore.Ingredientes[idx];
            txtNome.Text = ing.Nome;
            indexEmEdicao = idx;
        }

        private void BtnExcluirIng_Click(object? sender, EventArgs e)
        {
            if (dgvIngredientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um ingrediente para excluir.");
                return;
            }
            var idx = dgvIngredientes.CurrentRow.Index;
            if (idx < 0 || idx >= DataStore.Ingredientes.Count) return;

            if (MessageBox.Show("Confirma a exclusão do ingrediente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataStore.Ingredientes.RemoveAt(idx);
                indexEmEdicao = null;
                PopularGrid();
            }
        }
    }
}