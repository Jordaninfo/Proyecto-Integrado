using System.Collections.Generic;

namespace PlantillaPiv1.Entities
{
    public class Plan
    {
        public int PlanId { get; set; }
        public string Nombre { get; set; }
        public int Minutos { get; set; }
        public int Gigas { get; set; }
        public int Sms { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
