using ConsumeApiRest.Models;
using ConsumeApiRest.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace ConsumeApiRest
{
    public partial class Form1 : Form
    {
        public string token { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApiRest_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://181.114.96.226:8005/ventas1.0.2/");

            var request = httpClient.GetAsync("api/personal/6158203/parametros").Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var dataResponse = JsonConvert.DeserializeObject<ParametroResponse>(resultString);

                foreach (Parametro p in dataResponse.parametroList)
                {
                    Console.WriteLine("ENTIDAD: " + p.entidad + " --- CODIGO: " + p.codigo + " --- DESCRIPCION: " + p.descripcion);
                }

                Console.WriteLine(dataResponse.parametroList.Count);
            }
        }

        private void btnApiRest2_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://181.114.96.226:8005/ventas1.0.2/");

            var request = httpClient.GetAsync("api/personal/6158203/parametros").Result;

            Console.WriteLine("INICIO");
            List<Parametro> listado = new List<Parametro>();
            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                JObject joResponse = JObject.Parse(resultString);
                JArray array = (JArray)joResponse["result"];

                listado = array.ToObject<List<Parametro>>();

                foreach (Parametro p in listado)
                {
                    Console.WriteLine("ENTIDAD: " + p.entidad + " --- CODIGO: " + p.codigo + " --- DESCRIPCION: " + p.descripcion);
                }
                //Console.WriteLine(resultString);
            }
            Console.WriteLine("TAMAÑO DE LISTADO: " + listado.Count);
        }

        private void btnRestSharp_Click(object sender, EventArgs e)
        {
            string baseURL = "http://181.114.96.226:8005/ventas1.0.2/";
            string apiURL = baseURL + "api/personal/6158203/parametros";
            IRestClient restClient = new RestClient(apiURL);
            IRestRequest restRequest = new RestRequest();
            IRestResponse restResponse = restClient.Get(restRequest);

            if (restResponse.StatusCode == HttpStatusCode.OK)
            {
                var resultString = restResponse.Content;
                var dataResponse = JsonConvert.DeserializeObject<ParametroResponse>(resultString);

                foreach (Parametro p in dataResponse.parametroList)
                {
                    Console.WriteLine("ENTIDAD: " + p.entidad + " --- CODIGO: " + p.codigo + " --- DESCRIPCION: " + p.descripcion);
                }

                Console.WriteLine(dataResponse.parametroList.Count);
            }
        }

        private void restSharpAwait_Click(object sender, EventArgs e)
        {
            string baseURL = "http://181.114.96.226:8005/ventas1.0.2/";
            string apiURL = baseURL + "api/personal/6158203/parametros";
            IRestClient restClient = new RestClient(apiURL);
            IRestRequest restRequest = new RestRequest();
            restRequest.AddHeader("Accept", "application/json");
            IRestResponse<ParametroResponse> restResponse = restClient.Get<ParametroResponse>(restRequest);

            if (restResponse.StatusCode == HttpStatusCode.OK)
            {
                //var resultString = restResponse.Content;
                //var dataResponse = JsonConvert.DeserializeObject<ParametroResponse>(resultString);

                /*foreach (Parametro p in restResponse)
                {
                    Console.WriteLine("ENTIDAD: " + p.entidad + " --- CODIGO: " + p.codigo + " --- DESCRIPCION: " + p.descripcion);
                }

                Console.WriteLine(dataResponse.parametroList.Count);*/
            }
        }

        private void btnApiRestHeader_Click(object sender, EventArgs e)
        {
            string url = "http://jsonplaceholder.typicode.com/posts";
            var client = new RestClient(url);
            var request = new RestRequest();
            var body = new Post { body = "This is my body", title = "This is my title", userId = 2 };

            request.AddJsonBody(body);
            var response = client.Post(request);

            Console.WriteLine(response.StatusCode.ToString() + "      " + response.Content.ToString());
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var body = new Login { email = "admin@admin.com", password = "sifac123456" };

            string urlBase = "https://pilotolaqfagal.sifac.nwc.com.bo";
            var client = new RestClient(urlBase);
            var request = new RestRequest("/api/v2/login", Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddJsonBody(body);
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var response = client.Post(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var resultString = response.Content;
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(resultString);
                token = apiResponse.data.tokenType + " " + apiResponse.data.accessToken;
            }
            else
            {

            }

            Console.WriteLine(response.StatusCode.ToString() + "      " + response.Content.ToString());
        }
    }

    public class Post
    {
        public string body { get; set; }
        public string title { get; set; }
        public int userId { get; set; }
    }

    public class Login
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
