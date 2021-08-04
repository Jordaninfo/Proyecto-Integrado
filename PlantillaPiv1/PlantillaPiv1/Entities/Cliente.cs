using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlantillaPiv1.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int NumeroDeContacto { get; set; }
        public DateTime Nacimiento { get; set; }

        [ForeignKey("Plan")]
        public int PlanId { get; set; }
        public Plan Plan { get; set; }

        [ForeignKey("Asesor")]
        public int AsesorId { get; set; }
        public Asesor Asesor { get; set; }

        [ForeignKey("Contrato")]
        public int ContratoId { get; set; }
        public Contrato Contrato { get; set; }

        public string NombreCompleto { get { return $"{Nombre} {Apellido}"; } }
    }
}
