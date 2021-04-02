using System;

namespace EduvisualDomain.Models
{
    public class ReservaEquipamento
    {
        public int IdReserva { get; set; }
        public string NomeFuncionario { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int QuantidadeEquipamento { get; set; }
        public Equipamento Equipamento { get; set; }
        public bool StatusReserva { get; set; }
    }
}