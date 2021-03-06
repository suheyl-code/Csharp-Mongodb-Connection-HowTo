using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace ConsoleAppNETCore5_MongoDB
{
    public class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string dataBase)
        {
            var client = new MongoClient();
            db = client.GetDatabase(dataBase);
        }

        /// <summary>
        /// Insert one record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <param name="record"></param>
        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        /// <summary>
        /// Loading all records, needs Enumeration to check all elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns>List<typeparamref name="T"/></returns>
        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        /// <summary>
        /// Loads one record based on its GUID ID
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <param name="id"></param>
        /// <returns>T</returns>
        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        /// <summary>
        /// Upsert: Update or Insert
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <param name="id"></param>
        /// <param name="record"></param>
        public void UpsertRecord<T>(string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);
            var result = collection.ReplaceOne(new BsonDocument("_id", id),
                record,
                new UpdateOptions { IsUpsert = true });
        }

        /// <summary>
        /// Delete One Record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <param name="id"></param>
        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
