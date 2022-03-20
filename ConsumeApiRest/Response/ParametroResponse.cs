using ConsumeApiRest.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ConsumeApiRest.Response
{
    class ParametroResponse
    {
        public string codRespuesta { get; set; }

        public string msgRespuesta { get; set; }

        [JsonProperty("result")]
        public List<Parametro> parametroList { get; set; }
    }
}
