namespace MAUI1;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("ESTOY HACIENDO PRUEBAS", "Hola como estas, todo estara bien", "OKY");
    }
}