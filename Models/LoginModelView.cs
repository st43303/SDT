using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SDT.Web.Models
{
    public class LoginModelView
    {
        /// <summary>
        /// Username
        /// </summary>
        [DisplayName("Uživatelské jméno")]
        [StringLength(10, ErrorMessage = "Maximální délka textu je 10 znaků")]
        [Required(ErrorMessage = "Uživatelské jméno je povinná položka")]
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [DisplayName("Heslo")]
        [StringLength(100, ErrorMessage = "Maximální délka textu je 100 znaků")]
        [Required(ErrorMessage = "Heslo je povinná položka")]
        public string Password { get; set; }
    }
}
