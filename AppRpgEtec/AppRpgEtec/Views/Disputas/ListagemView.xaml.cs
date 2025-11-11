using AppRpgEtec.ViewModels.Disputas;

namespace AppRpgEtec.Views.Disputas;
// Luis Henrique Barreira
// Erasmo Alves Costa Neto
public partial class ListagemView : ContentPage
{
    DisputaViewModel viewModel;
    public ListagemView()
	{
		InitializeComponent();

		viewModel = new DisputaViewModel();
		BindingContext = viewModel;
	}
}