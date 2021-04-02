using System;

namespace EduvisualDomain.Models
{
    public class Funcionario : Usuario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Metrial { get; set; }
        public DateTime DataDeCadastro { get; set; }
    }
}