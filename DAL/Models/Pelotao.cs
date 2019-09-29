using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace back_usuarios_tg.DAL.Models
{
    public class Pelotao
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("Nome")]
        public string Nome { get; set; }

         [BsonElement("Numero")]
        public int Numero { get; set; }

         [BsonElement("Comandante")]
        public string Comandante { get; set; }

        [BsonElement("Monitor")]
        public string Monitor { get; set; }
    }
}