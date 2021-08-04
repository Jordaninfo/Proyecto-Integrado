using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlantillaPiv1.Entities
{
    public class Asesor
    {
        public int AsesorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int NumeroDeContacto { get; set; }
        public DateTime Nacimiento { get; set; }
        public List<Cliente> Clientes { get; set; }

        [ForeignKey("Departamento")]
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }

        public string NombreCompleto { get { return $"{Nombre} {Apellido}"; } }
        public double Edad { get { return DateTime.Now.Subtract(Nacimiento).TotalDays / 365; } }
    }

}
