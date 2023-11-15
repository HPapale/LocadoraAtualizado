using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace WindowsFormLocadora
{
    internal class ClienteResponse
    {
    }
    public class ClasseCliente
    {
        public int codigo { get; set; }

        public string nome { get; set; }

        public string cpf { get; set; }

        public string telefone { get; set; }

        public string endereco { get; set; }

    }

   
}

