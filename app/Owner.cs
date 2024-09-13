using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.bank_app
{
    public class Owner
    {
        private string firstName;
        private string lastName;

        public Owner(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public string GetFirstName() { return this.FirstName; }
        public string GetLastName() { return this.LastName; }

        public override string ToString()
        {
            return $"Owner:[firstName={FirstName}, lastName={LastName}";
        }
    }
}
