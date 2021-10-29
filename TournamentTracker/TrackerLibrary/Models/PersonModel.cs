using System;

namespace TrackerLibrary.models
{
    public class PersonModel
    {
        /// <summary>
        /// <list type="'identifiant de la personne"
        /// </summary>
        /// <value>The identifier.</value>
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EMailAddress { get; set; }

        public string CellPhoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
