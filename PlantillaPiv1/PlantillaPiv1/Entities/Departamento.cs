using System.Collections.Generic;

namespace PlantillaPiv1.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public List<Asesor> Asesores { get; set; }
    }
}
