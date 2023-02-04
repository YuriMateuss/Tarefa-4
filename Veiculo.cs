using System;
using System.Collections.Generic;
using System.Text;

namespace tarefa_3
{
    public class VeiculoWindow
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdFabricante { get; set; }
        public override string ToString()
        {
            return $"{GetId()} - {Nome} - {IdFabricante}";
        }

        private object GetId()
        {
            throw new NotImplementedException();
        }
    }

}
