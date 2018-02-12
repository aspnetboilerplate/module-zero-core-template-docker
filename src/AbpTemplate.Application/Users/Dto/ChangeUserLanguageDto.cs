using System.ComponentModel.DataAnnotations;

namespace AbpTemplate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}