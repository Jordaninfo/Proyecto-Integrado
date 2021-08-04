using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlantillaPiv1.Entities
{
    public class Contrato
    {
        public int ContratoId { get; set; }
        public Plan NombrePlan { get; set; }
        public Cliente NombreCliente { get; set; }
        public DateTime FechaDeActivacion { get; set; }
        public Asesor Asesor { get; set; }

        public double TiempoDeContrato { get { return DateTime.Now.Subtract(FechaDeActivacion).TotalDays / 365; } }

    }
}
