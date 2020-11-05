using JohnAndHisAdvernturesVol1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnAndHisAdvernturesVol1.Models
{
    class House:IHouseFunctionality
    {
        private Human _owner;
        private List<Human> _peopleInside = new List<Human>() ;
        private Door _door;


        public Human Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }        

        public List<Human> PeopleInside
        {
            get { return _peopleInside; }
            set { _peopleInside = value; }
        }

        public Door Door
        {
            get { return _door; }
            set { _door = value; }
        }

        public void Enters(Human person)
        {
            this._peopleInside.Add(person);
        }

        public void Leaves(Human person)
        {
            Console.WriteLine($"{person.Name} leaves the house");
            this._peopleInside.Remove(person);
        }
    }
}
