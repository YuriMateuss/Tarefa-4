using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace tarefa_3
{
    static class NVeiculo
    {
        private static List<Veiculo> veiculos = new List<Veiculo>();
        public static void Inserir(Veiculo v)
        {
            Abrir();
            int id = 0;
            foreach (Veiculo obj in veiculos)
                if (obj.GetId() > id) id = obj.GetId();
            v.SetId(id + 1);
            veiculos.Add(v);
            Salvar();
        }
        public static List<Veiculo> Listar()
        {
            Abrir();
            return veiculos;
        }
        public static void Atualizar(Veiculo v)
        {
            Abrir();
            foreach (Veiculo obj in veiculos)
                if (obj.GetId() == v.GetId())
                {
                    obj.SetId(v.GetId());
                    obj.Nome = v.Nome;
                    obj.IdFabricante = v.IdFabricante;
                }
            Salvar();
        }
        public static void Excluir(Veiculo v)
        {
            Abrir();
            Veiculo x = null;
            foreach (Veiculo obj in veiculos)
                if (obj.GetId() == v.GetId()) x = obj;
            if (x != null) veiculos.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Veiculo>));
                f = new StreamReader("./veiculos.xml");
                veiculos = (List<Veiculo>)xml.Deserialize(f);
            }
            catch
            {
                veiculos = new List<Veiculo>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Fabricante>));
            StreamWriter f = new StreamWriter("./veiculos.xml", false);
            xml.Serialize(f, veiculos);
            f.Close();
        }
    }
}