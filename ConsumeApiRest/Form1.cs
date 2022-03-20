using ConsumeApiRest.Models;
using ConsumeApiRest.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace ConsumeApiRest
{
    public partial class Form1 : Form
    {
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
    }
}
