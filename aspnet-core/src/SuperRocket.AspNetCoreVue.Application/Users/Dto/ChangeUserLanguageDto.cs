using System.ComponentModel.DataAnnotations;

namespace SuperRocket.AspNetCoreVue.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}