using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SDT.Web.Models
{
    /// <summary>
    /// Project view model
    /// </summary>
    public class ProjectViewModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [DisplayName("Název projektu")]
        [Required(ErrorMessage = "Název projektu je povinná položka")]
        [StringLength(50, ErrorMessage = "Maximální délka je 50 znaků")]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [DisplayName("Popis projektu")]
        [Required(ErrorMessage = "Popis projektu je povinná položka")]
        [StringLength(400, ErrorMessage = "Maximální délka je 400 znaků")]
        public string Description { get; set; }

        /// <summary>
        /// Author id
        /// </summary>
        [DisplayName("Autor projektu")]
        public int AuthorId { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        [DisplayName("Datum vytvoření projektu")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [DisplayName("Zkratka projektu")]
        [Required(ErrorMessage = "Zkratka projektu je povinná položka")]
        [StringLength(20, ErrorMessage = "Maximální délka je 20 znaků")]
        public string Code { get; set; }

        /// <summary>
        /// WIP
        /// </summary>
        [DisplayName("Hodnota WIP")]
        [Required(ErrorMessage = "Hodnota WIP je povinná položka")]
        [Range(1, int.MaxValue, ErrorMessage = "Minimální možná hodnota je 1")]
        public int WIP { get; set; }

        public string DescriptionPreview
        {
            get
            {
                if (Description.Length <= 50)
                {
                    return Description;
                }

                return Description.Substring(0, 50) + "...";
            }
        }
    }
}
