namespace Animals;

public partial class ListPage : ContentPage
{
	public ListPage(IAnimalService animalService)
	{
		InitializeComponent();

		var currentRoute = Shell.Current.CurrentState.Location.ToString();
		IEnumerable<Animal> animals;

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
	}
}