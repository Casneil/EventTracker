using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{   /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Person first name.
        /// </summary>
        public string FirstName{ get; set; }
        /// <summary>
        /// Person last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Person email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Person mobile number.
        /// </summary>
        public string cellphoneNumber { get; set; }
    }
}
