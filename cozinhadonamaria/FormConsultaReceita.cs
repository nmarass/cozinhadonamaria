using System;
using System.Windows.Forms;

namespace cozinhadonamaria
{
    public partial class FormConsultaReceita : Form
    {
        public FormConsultaReceita()
        {
            InitializeComponent();

            // Associa os eventos aos bot�es
            btnBuscar.Click += BtnBuscar_Click;
            btnVisualizar.Click += BtnVisualizar_Click;
        }

        private void BtnBuscar_Click(object? sender, EventArgs e)
        {
            // Exemplo: buscar receitas pelo texto digitado
            string termoBusca = txtBusca.Text.Trim();
            // Aqui voc� pode implementar a l�gica de busca e preencher o dgvReceitas
            MessageBox.Show($"Buscar por: {termoBusca}");
        }

        private void BtnVisualizar_Click(object? sender, EventArgs e)
        {
            // Exemplo: visualizar detalhes da receita selecionada
            if (dgvReceitas.CurrentRow != null)
            {
                // Aqui voc� pode abrir um novo formul�rio ou exibir detalhes
                MessageBox.Show("Visualizar detalhes da receita selecionada.");
            }
            else
            {
                MessageBox.Show("Selecione uma receita para visualizar.");
            }
        }
    }
}