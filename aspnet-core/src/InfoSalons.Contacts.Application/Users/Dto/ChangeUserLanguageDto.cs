using System.ComponentModel.DataAnnotations;

namespace InfoSalons.Contacts.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}