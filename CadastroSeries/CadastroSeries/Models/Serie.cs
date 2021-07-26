using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroSeries.Models
{
    public class Serie
    {
        public int SerieId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }

    }
}
