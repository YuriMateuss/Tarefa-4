using System;
using System.Collections.Generic;
using System.Text;

namespace tarefa_3
{
    public class Fabricante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Sigla}";
        }
    }

}
