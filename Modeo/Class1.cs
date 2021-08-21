using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeo
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Date1 { get; set; }

        public string GetFullName()
        {
            return string.Concat(FirstName, " ", LastName);
        }

        private int GetAge()
        {
            int result = 0;
            DateTime now = DateTime.Today;
            result = DateTime.Today.Year - Date1.Year;
            return result;
        }

        public string GetMessage()
        {
            string result = "Menor Edad";
            if (GetAge() > 18)
                result = "Mayor Edad";
            return result;
        }




    }
}
