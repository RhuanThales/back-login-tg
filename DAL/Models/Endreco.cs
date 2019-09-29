using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace back_usuarios_tg.DAL.Models
{
    public class Endereco
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Rua")]
        public string Rua { get; set; }

        [BsonElement("Bairro")]
        public string Bairro { get; set; }

        [BsonElement("CEP")]
        public string CEP { get; set; }

        [BsonElement("Cidade")]
        public string Cidade { get; set; }

        [BsonElement("Estado")]
        public string Estado { get; set; }
    }
}