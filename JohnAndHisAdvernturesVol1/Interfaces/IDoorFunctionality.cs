using JohnAndHisAdvernturesVol1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnAndHisAdvernturesVol1
{
    interface IDoorFunctionality
    {

        void Knock(Human visitor);
        void Answer(Human owner);
        void Open();
        void Close();
    }
}
