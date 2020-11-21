using System;

namespace TDD
{
    public class MyClass
    {
        private IDatabaseHelper _databaseHelper;

        public MyClass(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public string ReverseString(string text)
        {
            int length = text.Length;
            string reversedString = "";

            for (int i = length; i > 0; i--)
            {
                reversedString += text[i-1];
            }

            return reversedString;
        }

        public void SetNoOfLegs(Animal animal)
        {
            if (animal.Type == "dog") animal.NoOfLegs = 4;
        }

        public Animal SetAnimalName(int id, string name)
        {
            var animal = _databaseHelper.GetAnimal(id);

            animal.Name = name;

            if (id == 2)
            {
                _databaseHelper.SaveAnimal(animal);
            }

            return animal;
        }
    }
}
