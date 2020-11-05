using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace JohnAndHisAdvernturesVol1.Models
{
    class Human
    {       

        private string _name;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Human(string name)
        {
            _name = name;
        }

    }
}
