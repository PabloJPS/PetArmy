﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetArmy.Models
{
    public class UsersLocation
    {

        public string UID { get; set; }
        public string Title { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }

        public UsersLocation()
        {
        }

        public UsersLocation(string uID, string title, double latitude, double longitude, string description)
        {
            UID = uID;
            Title = title;
            Latitude = latitude;
            Longitude = longitude;
            Description = description;
        }
    }
}
