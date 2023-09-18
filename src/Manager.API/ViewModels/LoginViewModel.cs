using System.ComponentModel.DataAnnotations;

namespace Manager.API.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="O login não pode ser vazio.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "a senha não pode ser vazio.")]
        public string Password { get; set; }
    }
}
