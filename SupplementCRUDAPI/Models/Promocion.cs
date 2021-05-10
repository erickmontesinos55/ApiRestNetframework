using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplementCRUDAPI.Models
{

    public class Promocion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("MediodDePago")]
        public IEnumerable<string> MediosDePago { get; private set; }
        [BsonElement("Bancos")]
        public IEnumerable<string> Bancos { get; private set; }
        [BsonElement("CategoriasProductos")]
        public IEnumerable<string> CategoriasProductos { get; private set; }
        [BsonElement("MaximaCantidadDeCuotas")]
        public int? MaximaCantidadDeCuotas { get; private set; }
        [BsonElement("ValorInteresCuotas")]
        public decimal? ValorInteresCuotas { get; private set; }
        [BsonElement("PorcentajeDeDescuento")]
        public decimal? PorcentajeDeDescuento { get; private set; }
        [BsonElement("FechaInicio")]
        public DateTime? FechaInicio { get; private set; }
        [BsonElement("FechaFin")]
        public DateTime? FechaFin { get; private set; }
        [BsonElement("Activo")]
        public bool Activo { get; private set; }
        [BsonElement("FechaCreacion")]
        public DateTime FechaCreacion { get; private set; }
        [BsonElement("FechaModificacion")]
        public DateTime? FechaModificacion { get; private set; }

    }
}

