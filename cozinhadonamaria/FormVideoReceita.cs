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
        private TableLayoutPanel barra = new();

        public FormVideoReceita()
        {
            Text = "Vídeos de Receita";
            Width = 1000;
            Height = 700;
            StartPosition = FormStartPosition.CenterScreen;

            barra.Dock = DockStyle.Top;
            barra.AutoSize = true;
            barra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            barra.Padding = new Padding(12, 10, 12, 10);
            barra.ColumnCount = 2;
            barra.RowCount = 1;
            barra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            barra.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            barra.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            cmbReceitas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReceitas.Margin = new Padding(0, 0, 12, 0);
            cmbReceitas.Height = 36;
            cmbReceitas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbReceitas.Width = 400; // largura inicial, depois será ajustada pelo layout
            AtualizarListaReceitas();

            btnBuscar.Text = "Buscar no YouTube";
            btnBuscar.AutoSize = true;
            btnBuscar.Height = 36;
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            btnBuscar.Click += BtnBuscar_Click;

            barra.Controls.Add(cmbReceitas, 0, 0);
            barra.Controls.Add(btnBuscar, 1, 0);

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
