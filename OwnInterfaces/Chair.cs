using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OwnInterfaces
{
    class Chair : Forniture,IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair(string color,string material) 
        {
            Color = color;
            Material = material;
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy() 
        {
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Spawning chair parts");
        }
    }
}
