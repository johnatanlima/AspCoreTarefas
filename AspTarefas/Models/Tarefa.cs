using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspTarefas.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime Inicio { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Fim { get; set; }

        public string Importancia { get; set; }

        // testar depois [DataType(DataType.Upload)]
        public byte[] Foto {get; set;}
    }
}
