
namespace Animals
{
    public interface IAnimalService
    {
        Animal GetAnimalById(int id);
        List<Animal> GetSpeciesForType(AnimalType type);
    }
}