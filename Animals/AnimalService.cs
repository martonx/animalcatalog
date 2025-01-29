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
        new Animal {
            Id = 3,
            Type = AnimalType.Dog,
            Species = "Német juhász",
            ImageUrl = "https://dogx.hu/wp-content/uploads/2023/03/Nemet-juhaszkutya-fajtaleiras.jpg",
            Description = "Ez egy német juhász leírás"
        },
        new Animal {
            Id = 4,
            Type = AnimalType.Dog,
            Species = "Csivava",
            ImageUrl = "https://kutyakaland.hu/wp-content/uploads/csivava2.jpg",
            Description = "Ez egy csivava leírás"
        },
    };

    public List<Animal> GetSpeciesForType(AnimalType type)
    {
        return animals.Where(a => a.Type == type).ToList();
    }

    public Animal GetAnimalById(int id)
    {
        return animals.Single(a => a.Id == id);
    }
}
