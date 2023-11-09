using Xamarin.Essentials;
namespace Ejercicio1_3.Views;

public partial class Update : ContentPage
{
	public Update()
	{
		InitializeComponent();
	}
    private async void btnsalvarr_Clicked(object sender, EventArgs e)
    {
        var person = new Modelos.Persona
        {
            Id = Convert.ToInt32(txtid.Text),
            nombre = txtnombre.Text,
            apellidos = txtapellido.Text,
            edad = Int32.Parse(txtedad.Text),
            correo = txtcorreo.Text,
            direccion = txtdireccion.Text
        };

        var result = await App.DatabasePerson.StorePersonas(person); ;

        if (result > 0)
            await DisplayAlert("Empleado Ingresado", "Correctamente", "OK");
        else
            await DisplayAlert("Error", "No Ingresado", "OK");

    }

    private async void btneliminarr_Clicked(object sender, EventArgs e)
    {
        var person = new Modelos.Persona
        {
            Id = Convert.ToInt32(txtid.Text),
            nombre = txtnombre.Text,
            apellidos = txtapellido.Text,
            edad = Int32.Parse(txtedad.Text),
            correo = txtcorreo.Text,
            direccion = txtdireccion.Text
        };

        var result = await App.DatabasePerson.DeletePersonas(person); ;

        if (result > 0)
            await DisplayAlert("Empleado Eliminado", "Correctamente", "OK");
        else
            await DisplayAlert("Error", "No Eliminado", "OK");

    }
}
