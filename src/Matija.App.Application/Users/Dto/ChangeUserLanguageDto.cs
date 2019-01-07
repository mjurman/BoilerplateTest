using System.ComponentModel.DataAnnotations;

namespace Matija.App.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}