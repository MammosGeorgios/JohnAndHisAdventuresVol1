using JohnAndHisAdvernturesVol1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnAndHisAdvernturesVol1.ConsoleLogic
{
    class StoryMethods
    {
        public StoryMethods()
        {
        }

        public void Story()
        {
            // initializing objects
            Human john = new Human("Johny");
            Human anna = new Human("Annie");
            Door frontDoor = new Door();
            House johnHouse = new House();

            // initializing scenario
            johnHouse.Owner = john;
            johnHouse.Door = frontDoor;
            johnHouse.Enters(john);

            //scenario

            johnHouse.Door.Knock(anna);
            johnHouse.Door.Answer(john);
            johnHouse.Door.Open();
            johnHouse.Leaves(john);
            johnHouse.Door.Close();





            

            
        }
    }
}
