using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnInterfaces
{
    class Forniture
    {
        public string Color { get; set; }

        public string Material { get; set; }

        public Forniture() 
        {
        
        }

        public Forniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }

}
