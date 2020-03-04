using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzIMDB
{
    public class Film
    {
        public int Id { get; set; }
        public string FilmAd { get; set; }
        public int? Puan { get; set; }
        public Image Foto { get; set; }
        public override string ToString()
        {
            return FilmAd;
        }
    }
}
