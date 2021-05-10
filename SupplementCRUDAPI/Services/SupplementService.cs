using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using SupplementCRUDAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace SupplementCRUDAPI.Services
{
    public class SupplementService
    {
        private readonly IMongoCollection<Promocion> _supplement;

        public SupplementService(IConfiguration config)
        {
            // Connects to MongoDB.
            var client = new MongoClient(config.GetConnectionString("Promocion"));
            // Gets the supplementDB.
            var database = client.GetDatabase("Promocion");
            //Fetches the supplement collection.
            _supplement = database.GetCollection<Promocion>("Promocion");
        }

        public async Task<List<Promocion>> Get()
        {
            //Gets all supplements. 
            return await _supplement.Find(s => true).ToListAsync();
        }

        public async Task<Promocion> Get(string id)
        {
            //Get a single supplement. 
            return await _supplement.Find(s => s.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Promocion> Create(Promocion s)
        {
            //Create a supplement.
            await _supplement.InsertOneAsync(s);
            return s;
        }

        public async Task<Promocion> Update(string id, Promocion s)
        {
            // Updates and existing supplement. 
            await _supplement.ReplaceOneAsync(su => su.Id == id, s);
            return s;
        }


        public async Task Remove(string id)
        {
            //Removes a supplement.
            await _supplement.DeleteOneAsync(su => su.Id == id);
        }

    }
}
