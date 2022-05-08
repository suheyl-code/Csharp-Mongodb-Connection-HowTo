using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ConsoleAppNETCore5_MongoDB
{
    public class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel PrimaryAddress { get; set; }
       
        [BsonElement("dob")]
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} [{PrimaryAddress.Street}/{PrimaryAddress.City}/{PrimaryAddress.Country}]";
        }
    }
}
