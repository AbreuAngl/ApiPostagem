using ApiPostagens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiPostagens.Services
{
    public class PostagensServices
    {
        async public Task<List<Postagem>> GetPostagens()
        {
            List<Postagem> postagens = new List<Postagem>();
            string URI = "https://jsonplaceholder.typicode.com/posts";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync(URI);

            if (responseMessage.IsSuccessStatusCode)
            {
                string conteudo = await responseMessage.Content.ReadAsStringAsync();
                postagens = JsonConvert.DeserializeObject<List<Postagem>>(conteudo);


            }
            return (postagens);
        }
    }
}
