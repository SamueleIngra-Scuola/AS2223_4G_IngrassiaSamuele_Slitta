using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Gift
    {
        public string name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string colour {
            get
            {
                return colour;
            }

            set
            {
                colour = value;
            }
        }

        public double weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public double volume
        {
            get
            {
                return volume;
            }

            set
            {
                volume = value;
            }
        }

        public Gift() { }

        public Gift(string name, string color, double weight, double volume) 
        {
            this.name = name;
            this.colour = color;
            this.weight = weight;
            this.volume = volume;
        }

    }
}
