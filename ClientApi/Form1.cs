using ClientApi.DTOS.Primos;
using System.Text.Json;
using System.Text;
using static System.Windows.Forms.Design.AxImporter;

namespace ClientApi
{
    public partial class Form1 : Form
    {
        HttpClient _client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //procurar que el puerto del localhost del api sea igual a este.
            _client.BaseAddress = new Uri("https://localhost:7109/api/");
        }

        private async void BtnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMax.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad de numeros primos que quiere.");
                return;
            }
            if (string.IsNullOrEmpty(TxtNumInicial.Text))
            {
                MessageBox.Show("Debe ingresar desde que numero quiere comenzar a buscar.");
                return;
            }
            if (string.IsNullOrEmpty(TxtUser.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del usuario.");
                return;
            }
            GetPrimosParamsDTO dto = new(
                InitialValue: Convert.ToInt32(TxtNumInicial.Text),
                MaxValue: Convert.ToInt32(TxtMax.Text),
                UserName: TxtUser.Text);

            var json = JsonSerializer.Serialize(dto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var response = await _client.PostAsync("Primos/", data);

            var values = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Ocurrio un error al buscar los numeros primos. {values}");
                return;
            }
            var deserialize = JsonSerializer.Deserialize<GetPrimosDTO>(values);
            lblResponse.Text = $"Los {dto.MaxValue} numeros primos a partir de {dto.InitialValue} son: {string.Join(",", deserialize.Primos)}";


        }

        private async void BtnPersistence_Click(object sender, EventArgs e)
        {

            using var response = await _client.GetAsync("Persistence");

            var values = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ocurrio un error al buscar la persistencia.");
                return;
            }

            var deserialize = JsonSerializer.Deserialize<List<GetPersistenceDTO>>(values);
            dtgPersistence.DataSource = deserialize;
            dtgPersistence.Refresh();

        }
    }
}