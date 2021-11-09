using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.CursoAPI.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "O campo Login é obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        public string Senha { get; set; }
    }
}
