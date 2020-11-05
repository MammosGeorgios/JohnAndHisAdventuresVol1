using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace JohnAndHisAdvernturesVol1.Models
{
    class Door:IDoorFunctionality
    {
        string _bellType;

        public string BellType
        {
            get { return this._bellType; }
            set { this._bellType = value; }
        }

        public void Answer(Human owner)
        {
            Console.WriteLine($"{owner.Name} answers the door.");
        }

        public void Close()
        {
            Console.WriteLine("Door Closes");
        }

        public void Knock(Human visitor)
        {
            Console.WriteLine($"{visitor.Name} knocks the door.");
        }

        public void Open()
        {
            Console.WriteLine("Door Opens");
        }
    }
}
