using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05CarFactory
{
    internal class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorCount { get; set; }
        public int SerialNumber { get; set; }
        public DateTime ProductionDate { get; set; }
    
    public Cars(string brand, string model, string color, int doorCount, int serialNumber)
        {
            Brand = brand;
            Model = model;
            Color = color;
            DoorCount = doorCount;
            SerialNumber = serialNumber;
            ProductionDate = DateTime.Now; 
        }

    }
}

