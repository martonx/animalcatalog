namespace Animals;

[QueryProperty(nameof(CurrentAnimal), "Animal")]
public partial class DetailsPage : ContentPage
{
    Animal animal;
    public Animal CurrentAnimal
    {
        get => animal;
        set
        {
            animal = value;
            OnPropertyChanged();
        }
    }

    public DetailsPage()
	{
		InitializeComponent();
        BindingContext = this;
    }
}