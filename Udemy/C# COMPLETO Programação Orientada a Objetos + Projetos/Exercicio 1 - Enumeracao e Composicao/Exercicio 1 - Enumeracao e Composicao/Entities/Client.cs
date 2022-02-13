using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1___Enumeracao_e_Composicao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birth { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birth)
        {
            Name = name;
            Email = email;
            Birth = birth;
        }
    }
}
