//Aqui testing de Attribute
//Primero armar el proyecto desde cero
using System;
using System.Reflection;

namespace  SeniorC
{
    class TestAttribute
    {
        public void GetAnyText(){
            Console.WriteLine("\nI am in Main");
                AnimalTypeTestClass testClass = new AnimalTypeTestClass();
                Type type = testClass.GetType();
                // Iterate through all the methods of the class.
                foreach(MethodInfo mInfo in type.GetMethods()) {
                    // Iterate through all the Attributes for each method.
                    foreach (Attribute attr in
                        Attribute.GetCustomAttributes(mInfo)) {
                        // Check for the AnimalType attribute.
                        if (attr.GetType() == typeof(AnimalTypeAttribute))
                            Console.WriteLine(
                                "Method {0} has a pet {1} attribute.",
                                mInfo.Name, ((AnimalTypeAttribute)attr).Pet);
                    }
                }
        }

        // An enumeration of animals. Start at 1 (0 = uninitialized).
        public enum Animal {
            // Pets.
            Dog = 1,
            Cat,
            Bird=2,
        }

        // A custom attribute to allow a target to have a pet.
        public class AnimalTypeAttribute : Attribute {
            // The constructor is called when the attribute is set.
            public AnimalTypeAttribute(Animal pet) {
                thePet = pet;
            }

            // Keep a variable internally ...
            protected Animal thePet;

            // .. and show a copy to the outside world.
            //Lo siguiente puede ser también? Rta: no porque la variable ThePet no se muestra
            //public Animal Pet {get; set;}
            public Animal Pet {
                get { return thePet; }
                set { thePet = value; }
            }
        }

        // A test class where each method has its own pet.
        class AnimalTypeTestClass {
            [AnimalType(Animal.Dog)]
            public void DogMethod() {
                Console.WriteLine("\nsay wow");
            }

            [AnimalType(Animal.Cat)]
            public void CatMethod() {
                Console.WriteLine("\nSay Miau");
            }

            [AnimalType(Animal.Bird)]
            public void BirdMethod() {
                Console.WriteLine("\nSay Twit");
            }
        }

        
    }
}