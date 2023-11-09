namespace Ejercicio1_3.Views;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listemple.ItemsSource = await App.DatabasePerson.ListaPersonas();
    }

    private async void tooladd_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());

    }

    private async void listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Modelos.Persona person = (Modelos.Persona)e.CurrentSelection.FirstOrDefault();

        Update pag = new Update();
        pag.BindingContext = person;
        await Navigation.PushAsync(pag);
    }
}