using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier of the person.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the name of the person.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents the last name of the person.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        ///  Represents the email of the person.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents the phone number of the person.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
