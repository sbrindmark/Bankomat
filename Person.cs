using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class Person
    {
        private string name //private field
        {
            get { return name; }
            set { name = value; }
        }
        private string password;

        //Read only property
        public string Name { get; }

       
    }
   
}
