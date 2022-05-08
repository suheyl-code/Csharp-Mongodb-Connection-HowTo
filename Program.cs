using System;

namespace ConsoleAppNETCore5_MongoDB
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");

            /// Adding Record to Table
            //var person = new PersonModel()
            //{
            //    FirstName = "Alp",
            //    LastName = "Çorumlu",
            //    PrimaryAddress = new AddressModel()
            //    {
            //        Street = "Kuçukçekmece",
            //        City = "Istanbul",
            //        Country = "Turkey"
            //    }
            //};
            //db.InsertRecord<PersonModel>("People", person);
            //Console.ReadLine();


            /// Getting all records
            //var returnedRecords = db.LoadRecords<PersonModel>("People");
            //foreach (var item in returnedRecords)
            //{
            //    Console.WriteLine($"{item.Id}: {item.FirstName} {item.LastName}");
            //    if (item.PrimaryAddress != null)
            //    {
            //        Console.WriteLine($"{item.PrimaryAddress.Street}/{item.PrimaryAddress.City}/{item.PrimaryAddress.Country}");
            //    }
            //    Console.WriteLine();
            //}


            /// Getting all records on different Types of T
            //var returnedRecord = db.LoadRecords<NameModel>("People");
            //foreach (var item in returnedRecord)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //    Console.WriteLine();
            //}

            /// Getting one record
            //var oneRecord = db.LoadRecordById<PersonModel>("People", new Guid("9bf87b0c-35ed-48f7-98a4-cb5a219a4e31"));
            //Console.WriteLine(oneRecord.ToString());


            /// Upsert
            //var oneRecord = db.LoadRecordById<PersonModel>("People", new Guid("9bf87b0c-35ed-48f7-98a4-cb5a219a4e31"));
            //oneRecord.DateOfBirth = new DateTime(1985, 05, 09, 0,0,0, DateTimeKind.Utc);
            //db.UpsertRecord<PersonModel>("Users", oneRecord.Id, oneRecord);


            /// Delete One Record
            //db.DeleteRecord<PersonModel>("People", new Guid("c409334a-61bd-44c9-8fd6-1b1502003918"));


        }
    }
}
