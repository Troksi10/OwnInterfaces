using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnInterfaces
{
    class Car : Vehicle,IDestroyable
    {
        public string DestructionSound {  get; set; }

        public List<IDestroyable> DestroyablesNearby;
        public Car(float speed,string color) : base(speed,color)
        {
            DestructionSound = "CarExplosion.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy() 
        {
            Console.WriteLine("Playing destruction sound {0}",DestructionSound);
            Console.WriteLine("Create Fire");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }


    }
}
