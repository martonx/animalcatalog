namespace Animals;

public partial class ListPage : ContentPage
{
    List<Animal> animals = new();

    public ListPage(IAnimalService animalService)
	{
		InitializeComponent();

		var currentRoute = Shell.Current.CurrentState.Location.ToString();
		

		switch (currentRoute)
		{
			case "//CatPage":
				animals = animalService.GetSpeciesForType(AnimalType.Cat);
				break;
            case "//DogPage":
                animals = animalService.GetSpeciesForType(AnimalType.Dog);
                break;
            default:
				break;
		}

		AnimalList.ItemsSource = animals;
    }

    private async void OnDetailsClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var item = (Animal)button.BindingContext;
        var id = item.Id;

        var animal = animals.Single(a => a.Id == id);

            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "Animal", animal }
            };

        await Shell.Current.GoToAsync($"Details", navigationParameter);
    }
}