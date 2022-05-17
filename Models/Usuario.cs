using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCCURSO.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "É necessario digitar no mínimo 5, e no máximo 10 caracteres")]
        public string Nome { get; set; }
        
        public string Observacao { get; set; }

        [Range(18, 70, ErrorMessage = "O limite de idade e de 18 a 70 anos")]
        public int Idade { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um email válido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "É necessario digitar no mínimo 5, e no máximo 15 caracteres")]
        [Required(ErrorMessage = "O Login é obrigatório")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este login já existe")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatório")]
        public int Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas são diferentes")]
        public int ConfirmarSenha { get; set; }

    }   
}