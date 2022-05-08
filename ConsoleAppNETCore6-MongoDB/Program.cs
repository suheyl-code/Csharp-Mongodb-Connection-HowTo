
using MongoDB.Driver;

string connectionString = "mongodb://127.0.0.1:27017";
string databaseName = "sample_db";
string collectionName = "people";

var client = new MongoClient(connectionString);
var db = client.GetDatabase(databaseName);
var collection = db.GetCollection<PersonModel>(collectionName);

/// Creating and adding one record to collection
//var person = new PersonModel { FirstName = "Alex", LastName = "Johnson" };
//await collection.InsertOneAsync(person);

/// Reading elements from database collection
var results = await collection.FindAsync(_ => true);
foreach (var result in results.ToList())
{
    Console.WriteLine($"{result.Id}: {result.FirstName} {result.LastName}");
}
