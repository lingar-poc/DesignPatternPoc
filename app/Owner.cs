﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public class Owner
    {
        private string firstName;
        private string lastName;

        public Owner(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string GetFirstName() { return this.firstName; }
        public string GetLastName() { return this.lastName; }

        public override string ToString()
        {
            return $"Owner:[firstName={firstName}, lastName={lastName}";
        }
    }
}
