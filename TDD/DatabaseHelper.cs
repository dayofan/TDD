using System.Diagnostics;

namespace TDD
{
    public class DatabaseHelper : IDatabaseHelper
    {
        public void SaveAnimal(Animal animal)
        {
            Debug.WriteLine("=================\n\n\nAnimal saved\n\n\n================= ");
        }

        public void DeleteAnimal(int id)
        {
            Debug.WriteLine("=================\n\n\nAnimal deleted\n\n\n=================");
        }

        public Animal GetAnimal(int id)
        {
            Debug.WriteLine("=================\n\n\nAnimal found\n\n\n=================");
            return new Animal();
        }
    }
}
