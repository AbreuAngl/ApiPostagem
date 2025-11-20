using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPostagens.ViewModels
{
    public class PostagemViewModel : ObservableObject
    {
        [ObservableProperty]
        public int id;
        int id;
        string title;
        string body;
    }
}
