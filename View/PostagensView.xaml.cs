using ApiPostagens.ViewModels;

namespace ApiPostagens.View;

public partial class PostagensView : ContentView
{
	public PostagensView()
	{
		InitializeComponent();
		this.BindingContext = new PostagensViewModel();
	}
}