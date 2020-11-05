using JohnAndHisAdvernturesVol1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnAndHisAdvernturesVol1.Interfaces
{
    interface IHouseFunctionality
    {

        void Enters(Human person);
        void Leaves(Human person);
    }
}
