using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfflineMind_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnAsk_Click(object sender, EventArgs e)
        {
            txtResposta.Text = "OfflineMind pensando... (pode demorar 20s na primeira vez)";

            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(120);

                    var json = $"{{\"model\":\"phi3\", \"prompt\":\"{txtPergunta.Text}\", \"stream\":false}}";
                    var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("http://localhost:11434/api/generate", content);
                    response.EnsureSuccessStatusCode();

                    var result = await response.Content.ReadAsStringAsync();
                    dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    txtResposta.Text = obj.response;
                }
            }
            catch (Exception ex)
            {
                txtResposta.Text = $"Erro: {ex.Message}\n\nDica: Deixe o 'ollama run phi3' rodando em outra janela.";
            }
        }
    }
}
