using System.ComponentModel.DataAnnotations;

namespace MyFirstBoilerPlate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}