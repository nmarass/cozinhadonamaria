using System;
using System.Linq;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    public partial class FormConsultaReceita : Form
    {
        public FormConsultaReceita()
        {
            InitializeComponent();
            ConfigurarGrid();

            btnBuscar.Click += BtnBuscar_Click;
            btnVisualizar.Click += BtnVisualizar_Click;
            Load += (_, __) => CarregarReceitas();
        }

        private void ConfigurarGrid()
        {
            dgvReceitas.AutoGenerateColumns = false;
            dgvReceitas.MultiSelect = false;
            dgvReceitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceitas.ReadOnly = true;
            dgvReceitas.RowHeadersVisible = false;

            dgvReceitas.Columns.Clear();
            dgvReceitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNome",
                HeaderText = "Nome",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvReceitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTipo",
                HeaderText = "Tipo de Cozinha",
                Width = 150
            });
            dgvReceitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQtdIng",
                HeaderText = "Ingredientes",
                Width = 110
            });
        }

        private void CarregarReceitas(string termo = "")
        {
            dgvReceitas.Rows.Clear();

            var receitas = DataStore.Receitas ?? new System.Collections.Generic.List<Receita>();
            var filtro = termo?.Trim() ?? string.Empty;

            var lista = string.IsNullOrWhiteSpace(filtro)
                ? receitas
                : receitas.Where(r =>
                      (!string.IsNullOrEmpty(r.Nome) && r.Nome.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0) ||
                      (!string.IsNullOrEmpty(r.TipoCozinha) && r.TipoCozinha.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0) ||
                      (r.Ingredientes != null && r.Ingredientes.Any(i => !string.IsNullOrEmpty(i.Nome) && i.Nome.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0))
                  ).ToList();

            foreach (var r in lista)
            {
                var rowIndex = dgvReceitas.Rows.Add(r.Nome, r.TipoCozinha, r.Ingredientes?.Count ?? 0);
                dgvReceitas.Rows[rowIndex].Tag = r;
            }
        }

        private void BtnBuscar_Click(object? sender, EventArgs e)
        {
            CarregarReceitas(txtBusca.Text);
        }

        private void BtnVisualizar_Click(object? sender, EventArgs e)
        {
            if (dgvReceitas.CurrentRow?.Tag is not Receita receita)
            {
                MessageBox.Show("Selecione uma receita para visualizar.");
                return;
            }

            MostrarDetalhes(receita);
        }

        private void MostrarDetalhes(Receita receita)
        {
            using var dlg = new Form
            {
                Text = $"Receita - {receita.Nome}",
                StartPosition = FormStartPosition.CenterParent,
                Size = new System.Drawing.Size(480, 420),
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            var lblNome = new Label { Text = $"Nome: {receita.Nome}", Left = 20, Top = 20, AutoSize = true };
            var lblTipo = new Label { Text = $"Tipo de Cozinha: {receita.TipoCozinha}", Left = 20, Top = 45, AutoSize = true };

            var grid = new DataGridView
            {
                Left = 20,
                Top = 80,
                Width = 420,
                Height = 260,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                RowHeadersVisible = false,
                AutoGenerateColumns = false
            };
            grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNomeIng", HeaderText = "Ingrediente", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQtd", HeaderText = "Quantidade", Width = 110 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "colUnd", HeaderText = "Unidade", Width = 110 });

            grid.Rows.Clear();
            foreach (var ing in receita.Ingredientes ?? Enumerable.Empty<Ingrediente>())
            {
                grid.Rows.Add(ing.Nome, ing.Quantidade, ing.Unidade);
            }

            var btnFechar = new Button { Text = "Fechar", DialogResult = DialogResult.OK, Left = 360, Top = 350, Width = 80 };

            dlg.Controls.Add(lblNome);
            dlg.Controls.Add(lblTipo);
            dlg.Controls.Add(grid);
            dlg.Controls.Add(btnFechar);
            dlg.AcceptButton = btnFechar;

            dlg.ShowDialog(this);
        }
    }
}