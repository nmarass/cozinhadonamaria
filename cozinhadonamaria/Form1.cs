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
        }



        // O erro CS0121 geralmente ocorre quando h� m�ltiplas defini��es de construtores com a mesma assinatura
        // ou duplicidade de arquivos parciais, ou problemas de build (arquivos duplicados no projeto).
        // Para corrigir, verifique se existe apenas uma defini��o do construtor FormIngrediente().
        // Se houver arquivos duplicados ou conflitos de build, remova-os do projeto.

        // N�o � necess�rio alterar este arquivo Form1.cs diretamente, mas sim garantir que s� exista UM construtor
        // p�blico sem par�metros em FormIngrediente. Se voc� tiver mais de um arquivo .cs para FormIngrediente,
        // verifique e remova duplicatas do construtor.

        // Exemplo de construtor correto em FormIngrediente.cs:
        public FormIngrediente()
        {
            InitializeComponent();
        }

        private void BtnTipoCozinha_Click(object? sender, EventArgs e)
        {
            var form = new FormTipoCozinha();
            form.Show();
        }

        // Exemplo: Passe o valor de um formul�rio para outro
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
