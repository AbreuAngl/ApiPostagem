using ApiPostagens.Models;
using ApiPostagens.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPostagens.ViewModels
{
    public class PostagensViewModel : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        int userid;
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string body;

        public async void CarregarPostagens()
        {
            List<Postagem> Listar = new List<Postagem>();
            Listar = await new PostagensServices().GetPostagens();
        }
    }
}
