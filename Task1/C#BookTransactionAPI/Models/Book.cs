using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTransactionAPI.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    namespace BookTransactionAPI.Models
    {
        public class Book
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }

            [BsonElement("Name")]
            public string BookName { get; set; }

            public decimal Price { get; set; }

            public string Category { get; set; }

            public string Author { get; set; }
        }
    }
}
