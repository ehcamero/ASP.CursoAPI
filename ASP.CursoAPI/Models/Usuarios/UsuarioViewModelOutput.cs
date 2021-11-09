using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.CursoAPI.Models.Usuarios
{
    public class UsuarioViewModelOutput
    {
        [Required(ErrorMessage = "O campo Codigo é obrigatório")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O campo Login é obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Email { get; set; }
    }
}
