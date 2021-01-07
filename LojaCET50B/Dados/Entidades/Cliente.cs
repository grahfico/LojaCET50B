using System;
using System.ComponentModel.DataAnnotations;

namespace LojaCET50B.Dados.Entidades
{
    public class Cliente
    {

        public int Id { get; set; }


        public string Nome { get; set; }


        public string Apelido { get; set; }


        public int NIF { get; set; }


        [Display(Name = "Data de Nascimento")]
        public DateTime dataNascimento { get; set; }

    }
}
