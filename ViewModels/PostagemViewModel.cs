using ApiPostagens.Models;
using ApiPostagens.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ApiPostagens.ViewModels
{
    public partial class PostagensViewModel : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        int userid;
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string body;
        public ICommand CarregarPostagensCommand => new Command(async () => CarregarPostagens());

        public async void CarregarPostagens()
        {
            List<Postagem> Listar = new List<Postagem>();
            Listar = await new PostagensServices().GetPostagens();
            Id = Listar[0].Id;
            Title = Listar[0].Title;
            Body = Listar[0].Body;
        }

            
    }
}
