using System;

namespace DemoEF.DAL.Entidade
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }
    }
}
