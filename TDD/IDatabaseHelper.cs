namespace TDD
{
    public interface IDatabaseHelper
    {
        public void SaveAnimal(Animal animal);
        public void DeleteAnimal(int id);
        public Animal GetAnimal(int id);
    }
}