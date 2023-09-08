
using OwnInterfaces;

Chair officeChair = new Chair("Brown","Plastic");
Chair gamingChair = new Chair("Red", "Wood");

Car damagedCar = new Car(80f, "Blue");

damagedCar.DestroyablesNearby.Add(officeChair);
damagedCar.DestroyablesNearby.Add(gamingChair);

damagedCar.Destroy();

Console.ReadKey();