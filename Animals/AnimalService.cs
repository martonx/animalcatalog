namespace Animals;

public class AnimalService : IAnimalService
{
    private List<Animal> animals = new List<Animal>
    {
        new Animal {
            Id = 1,
            Type = AnimalType.Cat,
            Species = "Perzsa macska",
            ImageUrl = "https://th.bing.com/th/id/OIP.ndyfVdc8U7MM_G02pQ4aKgHaHa?rs=1&pid=ImgDetMain",
            Description = "Ez egy perzsa macska leírás"
        },
        new Animal {
            Id = 2,
            Type = AnimalType.Cat,
            Species = "Sziámi macska",
            ImageUrl = "https://www.zooplus.hu/magazin/wp-content/uploads/2017/03/siamkatze-1024x680.jpg",
            Description = "Ez egy sziámi macska leírás"
        },
    };

    public IEnumerable<Animal> GetSpeciesForType(AnimalType type)
    {
        return animals.Where(a => a.Type == type);
    }

    public Animal GetAnimalById(int id)
    {
        return animals.Single(a => a.Id == id);
    }
}
