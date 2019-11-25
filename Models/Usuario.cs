using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloWorld.Models
{
    public class Usuario
    {
        int _id;
        string _nome;
        string _email;
        string _senha;
        string _foto;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string Foto { get => _foto; set => _foto = value; }

    }
}
