using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace back_usuarios_tg.DAL.Models
{
    public class Religiao
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("Descricao")]
        public string Descricao { get; set; }
    }
}
