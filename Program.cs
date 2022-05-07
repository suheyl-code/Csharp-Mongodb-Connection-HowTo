using System;

namespace ConsoleAppNETCore5_MongoDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");

            // Adding Record to Table
            //var person = new PersonModel()
            //{
            //    FirstName = "Mehmet",
            //    LastName = "Çorumlu",
            //    PrimaryAddress = new AddressModel()
            //    {
            //        Street = "Kuçukçekmece",
            //        City = "Istanbul",
            //        Country = "Turkey"
            //    }
            //};

            //db.InsertRecord<PersonModel>("Users", person);
            //Console.ReadLine();

            // Getting all records
            //var returnedRecords = db.LoadRecords<PersonModel>("Users");
            //foreach (var item in returnedRecords)
            //{
            //    Console.WriteLine($"{item.Id}: {item.FirstName} {item.LastName}");
            //    if(item.PrimaryAddress != null)
            //    {
            //        Console.WriteLine($"{item.PrimaryAddress.Street}/{item.PrimaryAddress.City}/{item.PrimaryAddress.Country}");
            //    }
            //    Console.WriteLine();
            //}

            // Getting one record
            var oneRecord = db.LoadOneRecord<PersonModel>("Users", new Guid("9bf87b0c-35ed-48f7-98a4-cb5a219a4e31"));
            Console.WriteLine(oneRecord.ToString());
        }
    }
}
