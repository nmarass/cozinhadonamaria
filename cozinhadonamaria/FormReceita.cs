using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    public partial class FormReceita : Form
    {
        private string tipoCozinhaSelecionado = string.Empty;
        private List<Ingrediente> ingredientesReceita = new();

        public FormReceita(string tipoCozinha)
        {
            InitializeComponent();
            tipoCozinhaSelecionado = tipoCozinha;
            Inicializar();
        }

        public FormReceita()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            ConfigurarGrid();
            btnAdicionarIngrediente.Click += BtnAdicionarIngrediente_Click;
            btnSalvarReceita.Click += BtnSalvarReceita_Click;
            AtualizarTiposCozinha();
            this.Activated += (_, __) => AtualizarTiposCozinha();
        }

        private void ConfigurarGrid()
        {
            dgvIngredientes.AutoGenerateColumns = false;
            dgvIngredientes.Columns.Clear();
            dgvIngredientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNome", HeaderText = "Nome" });
            dgvIngredientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQuantidade", HeaderText = "Quantidade" });
            dgvIngredientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "colUnidade", HeaderText = "Unidade" });
        }

        private void AtualizarTiposCozinha()
        {
            var atual = cmbTipoCozinha.SelectedItem as string;
            cmbTipoCozinha.DataSource = null;
            cmbTipoCozinha.DataSource = DataStore.TiposCozinha;
            if (!string.IsNullOrEmpty(atual) && DataStore.TiposCozinha.Contains(atual))
                cmbTipoCozinha.SelectedItem = atual;
        }

        private void BtnAdicionarIngrediente_Click(object? sender, EventArgs e)
        {
            if (DataStore.Ingredientes.Count == 0)
            {
                using var frm = new FormIngrediente();
                frm.ShowDialog(this);
            }

            if (DataStore.Ingredientes.Count == 0)
            {
                MessageBox.Show("Cadastre ingredientes primeiro.");
                return;
            }

            var selecionados = SelecionarIngredientes();
            if (selecionados.Count == 0) return;

            foreach (var ingBase in selecionados)
            {
                var info = SolicitarQuantidadeUnidade(ingBase);
                if (info == null) continue;

                var ingReceita = new Ingrediente
                {
                    Nome = ingBase.Nome,
                    Quantidade = info.Value.Quantidade,
                    Unidade = info.Value.Unidade
                };

                ingredientesReceita.Add(ingReceita);
                dgvIngredientes.Rows.Add(ingReceita.Nome, ingReceita.Quantidade, ingReceita.Unidade);
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

        private class IngredienteListItem
        {
            public Ingrediente Item { get; }
            public IngredienteListItem(Ingrediente item) => Item = item;
            public override string ToString() => Item.Nome;
        }

        private List<Ingrediente> SelecionarIngredientes()
        {
            using var dlg = new Form
            {
                Text = "Selecionar Ingredientes",
                StartPosition = FormStartPosition.CenterParent,
                Size = new System.Drawing.Size(400, 400),
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            var list = new CheckedListBox
            {
                Dock = DockStyle.Top,
                Height = 300,
                CheckOnClick = true
            };
            foreach (var ing in DataStore.Ingredientes)
            {
                list.Items.Add(new IngredienteListItem(ing));
            }

            var btnOk = new Button { Text = "Confirmar", DialogResult = DialogResult.OK, Anchor = AnchorStyles.Bottom | AnchorStyles.Right, Left = 200, Top = 320, Width = 80 };
            var btnCancel = new Button { Text = "Cancelar", DialogResult = DialogResult.Cancel, Anchor = AnchorStyles.Bottom | AnchorStyles.Right, Left = 290, Top = 320, Width = 80 };

            dlg.Controls.Add(list);
            dlg.Controls.Add(btnOk);
            dlg.Controls.Add(btnCancel);
            dlg.AcceptButton = btnOk;
            dlg.CancelButton = btnCancel;

            var result = dlg.ShowDialog(this);
            var selecionados = new List<Ingrediente>();
            if (result == DialogResult.OK)
            {
                foreach (var obj in list.CheckedItems)
                {
                    if (obj is IngredienteListItem li)
                        selecionados.Add(li.Item);
                }
            }
            return selecionados;
        }

        private (decimal Quantidade, string Unidade)? SolicitarQuantidadeUnidade(Ingrediente ing)
        {
            using var dlg = new Form
            {
                Text = $"Quantidade/Unidade - {ing.Nome}",
                StartPosition = FormStartPosition.CenterParent,
                Size = new System.Drawing.Size(360, 180),
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            var lblQtd = new Label { Text = "Quantidade:", Left = 20, Top = 20, AutoSize = true };
            var numQtd = new NumericUpDown
            {
                Left = 120,
                Top = 16,
                Width = 100,
                DecimalPlaces = 2,
                Minimum = 0,
                Maximum = 100000
            };
            var lblUnd = new Label { Text = "Unidade:", Left = 20, Top = 60, AutoSize = true };
            var cmbUnd = new ComboBox
            {
                Left = 120,
                Top = 56,
                Width = 120,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbUnd.Items.AddRange(new object[] { "Gramas", "Mililitros", "Unidades" });
            if (cmbUnd.Items.Count > 0) cmbUnd.SelectedIndex = 0;

            var btnOk = new Button { Text = "Confirmar", DialogResult = DialogResult.OK, Left = 180, Top = 100, Width = 70 };
            var btnCancel = new Button { Text = "Cancelar", DialogResult = DialogResult.Cancel, Left = 260, Top = 100, Width = 80 };

            dlg.Controls.Add(lblQtd);
            dlg.Controls.Add(numQtd);
            dlg.Controls.Add(lblUnd);
            dlg.Controls.Add(cmbUnd);
            dlg.Controls.Add(btnOk);
            dlg.Controls.Add(btnCancel);
            dlg.AcceptButton = btnOk;
            dlg.CancelButton = btnCancel;

            var result = dlg.ShowDialog(this);
            return result == DialogResult.OK
                ? (numQtd.Value, cmbUnd.Text)
                : null;
        }
    }
}