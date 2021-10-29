using System;
using System.Collections.Generic;

namespace TrackerLibrary.models
{
    public class TeamModel
    {
        public int id { get; set; }

        public String TeamName { get; set; }

        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

    }
}
