using System;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace cozinhadonamaria
{
    public class FormVideoReceita : Form
    {
        private ComboBox cmbReceitas = new();
        private Button btnBuscar = new();
        private WebView2 web = new();
        private FlowLayoutPanel barra = new();

        public FormVideoReceita()
        {
            Text = "Vídeos de Receita";
            Width = 1000;
            Height = 700;
            StartPosition = FormStartPosition.CenterScreen;

            barra.Dock = DockStyle.Top;
            barra.Height = 60;
            barra.Padding = new Padding(12, 10, 12, 8);
            barra.FlowDirection = FlowDirection.LeftToRight;
            barra.WrapContents = false;
            barra.AutoSize = false;

            cmbReceitas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReceitas.Width = 420;
            cmbReceitas.Margin = new Padding(0, 0, 12, 0);
            cmbReceitas.Height = 36;
            AtualizarListaReceitas();
            barra.Controls.Add(cmbReceitas);

            btnBuscar.Text = "Buscar no YouTube";
            btnBuscar.Width = 170;
            btnBuscar.Height = 36;
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Click += BtnBuscar_Click;
            barra.Controls.Add(btnBuscar);

            web.Dock = DockStyle.Fill;

            Controls.Add(web);
            Controls.Add(barra);

            Activated += (_, __) => AtualizarListaReceitas();
        }

        private void AtualizarListaReceitas()
        {
            var nomes = DataStore.Receitas.Select(r => r.Nome).Where(n => !string.IsNullOrWhiteSpace(n)).Distinct().OrderBy(n => n).ToList();
            var atual = cmbReceitas.SelectedItem as string;
            cmbReceitas.DataSource = null;
            cmbReceitas.DataSource = nomes;
            if (!string.IsNullOrEmpty(atual) && nomes.Contains(atual))
                cmbReceitas.SelectedItem = atual;
        }

        private void InitializeComponent()
        {
        }

        private async void BtnBuscar_Click(object? sender, EventArgs e)
        {
            if (cmbReceitas.SelectedItem is not string nome || string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Selecione uma receita.");
                return;
            }
            if (web.CoreWebView2 == null)
                await web.EnsureCoreWebView2Async();

            var query = HttpUtility.UrlEncode(nome + " receita");
            var url = $"https://www.youtube.com/results?search_query={query}";
            if (web.CoreWebView2 != null)
                web.CoreWebView2.Navigate(url);
            else
                MessageBox.Show("O navegador não foi inicializado corretamente.");
        }
    }
}
