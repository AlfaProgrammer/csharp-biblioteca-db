using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Biblioteca.Persona
{
    internal class User : Persona
    {
        //protected string email;
        //protected string password;
        //protected uint phoneNumber;
        public User(string firstName, string lastName) : base(firstName, lastName) { }
    }
}
