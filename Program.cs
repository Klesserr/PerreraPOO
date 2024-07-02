
namespace PerreraPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prueba();// Instanciamos métodos de las diferentes clases
            Prueba2();//Creamos listas y adoptamos a un animal
            
        }
        public static void Prueba()
        {
            Dog d1 = new Dog("Pastor", "Pastor Aleman", 2, "calmado", 4, 2, StatusAnimal.Adoptado, "1");
            d1.Sleep();
            d1.Bark();
            d1.Play();
            d1.Play();
            Console.WriteLine(d1.GetInformation());
            EmergencyVeterinaryEmployee eve = new EmergencyVeterinaryEmployee("1", "Juan", "caninos");
            if(d1.Energy == 0 || d1.Energy == 1)
            {
                EmergencyVeterinaryEmployee.AttendEmergency(d1);
                Console.WriteLine($"Después de la operación el perro tiene {d1.Energy} de energia");
            }
            Carer c1 = new Carer("2", "Paco");
            c1.FeedDog(d1);
            Console.WriteLine(d1.GetInformation());
            c1.WalkDog(d1);
            Console.WriteLine(d1.GetInformation());

            Veterinary v = new Veterinary("3", "Luis", "exóticos");
            v.InspectAnimal(d1);

        }
        public static void Prueba2()
        {
            //Creamos 3 instancias de Perro
            Dog d1 = new Dog("Collie", "BorderCollie", 6, "calmado", 5, 13.2, StatusAnimal.NoAdoptado, "1");
            Dog d2 = new Dog("Rex", "Pastor Aleman", 4, "agresivo", 5, 8.3, StatusAnimal.NoAdoptado, "2");
            Dog d3 = new Dog("Shiba", "ShibaInu", 9, "calmado", 3, 9.4, StatusAnimal.NoAdoptado, "3");

            //Creamos 5 empleados, 2 Veterinarios,1 de Emergencias, 1 cuidador y 1 de mantenimiento
            Veterinary v1 = new Veterinary("1", "Ana", "exóticos");
            Veterinary v2 = new Veterinary("2", "Marcos", "acuáticos");
            EmergencyVeterinaryEmployee ev1 = new EmergencyVeterinaryEmployee("3", "Lara", "caninos");
            Carer c1 = new Carer("4", "Paco");
            MaintenanceEmployee me1 = new MaintenanceEmployee("5", "Julián");

            //Creamos 4 listas donde vamos a agregar cada una de las clases creadas.
            List<Dog> listDogs = new List<Dog>();
            listDogs.Add(d3); listDogs.Add(d2); listDogs.Add(d1);
            //Nueva lista vacia de perros
            List<Dog> listEmptyDogs = new List<Dog>();

            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(v1); listEmployees.Add(v2); listEmployees.Add(ev1); listEmployees.Add(c1); listEmployees.Add(me1);
            //Creamos 1 adoptante
            AdoptAnimal adopt = new AdoptAnimal("Carla", "Calle Joan Alcover", 721628192, listEmptyDogs);

            List<AdoptAnimal> listAdoptAnimals = new List<AdoptAnimal>();
            listAdoptAnimals.Add(adopt);

            //Creamos la clase Perrera y empezamos con su funcionalidad.
            ProcessKennel perrera = new ProcessKennel(listDogs, listEmployees, listAdoptAnimals);

            List<Dog> listDogsAviables = perrera.AvaiableDogs();
            perrera.SeeDogs(listDogsAviables);
            perrera.SeeEmployees(listEmployees);
            perrera.SeeAdopts(listAdoptAnimals);

            perrera.RegisterAdopt(adopt, d3);
            perrera.RegisterAdopt(adopt, d2);
            Console.WriteLine($"DATOS DEL PERRO ADOPTADO Y DE SU DUEÑO: ");
            foreach (var i in adopt.AdoptDogsList)
            {
                Console.WriteLine(i.GetInformation());
                Console.WriteLine(adopt.GetInfoAdopt());
                Console.WriteLine("--");
            };

            perrera.ReturnTheDog(adopt, d3);
            Console.WriteLine($"INFORMACION DE LOS PERROS NO ADOPTADOS EN PERRERA: ");
            foreach(var i in listDogs)
            {
                if(i.IsAdopted == StatusAnimal.NoAdoptado)
                {

                Console.WriteLine(i.GetInformation());
                }
            }
            ///*Eliminamos los perros del listado de perros de la clase Perrera*/
            //perrera.RemoveDog(d3);
            //perrera.RemoveDog(d2);

            //Console.WriteLine($"ENSEÑAMOS EL LISTADO DE PERROS DIPONIBLES DESPUES DE SER ADOPTADOS");
            //foreach (var i in listDogs)
            //{
            //    Console.WriteLine(i.GetInformation());
            //    Console.WriteLine("--");
            //};
        }
    }
}
