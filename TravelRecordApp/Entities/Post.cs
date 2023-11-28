using System;
using System.Collections.Generic;
using System.Text;

using MongoDB.Bson.Serialization.Attributes;

namespace TravelRecordApp.Entities
{
    public class Post
    {
        public int Id { get; set; }

        public string UserExperience { get; set; }
    }
}
