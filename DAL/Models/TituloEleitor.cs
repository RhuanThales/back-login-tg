using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace back_usuarios_tg.DAL.Models
{
    public class TituloEleitor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("Secao")]
        public string Secao { get; set; }

        [BsonElement("Zona")]
        public string Zona { get; set; }
    }
}