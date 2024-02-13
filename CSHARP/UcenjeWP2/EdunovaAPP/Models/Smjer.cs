using System.ComponentModel.DataAnnotations;

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

    }
}
