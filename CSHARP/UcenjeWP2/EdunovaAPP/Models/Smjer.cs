using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaAPP.Models
{
    /// <summary>
    /// ovo mi je POCO KOJI JE MAPIRAN NA BAZU
    /// </summary>
    public class Smjer:Entitet

    {
        ///<summary>
        ///Naziv u bazi
        ///<summary>
        [Required(ErrorMessage ="Naziv obavezno")]
        public string? Naziv { get; set; }

        /// <summary>
        /// trajanje u satima
        /// </summary>

        
        [Range(30,500,ErrorMessage ="{0} mora biti između {1} i {2}")]
        [Column("brojsati")]
        public int? Trajanje { get; set; }


        [Range(0, 1000, ErrorMessage ="Vrijednost {0} mora biti između {1} i {2}")]
        public decimal? Cijena { get; set; }


         public bool? Verificiran { get; set; }
    }
}
