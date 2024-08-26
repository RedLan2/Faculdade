using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Estacionamento.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public bool Ativo { get; set; }

        [JsonIgnore]
        [NotMapped]
         public virtual ICollection<Veiculo>? Veiculo { get; set; }

    }
}