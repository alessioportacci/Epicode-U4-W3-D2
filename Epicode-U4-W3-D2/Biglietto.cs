using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Epicode_U4_W3_D2
{
    public class Biglietto
    {
        Utente Cliente { get; set; }
        bool Ridotto { get; set; }
        int Sala { get; set; }

        public Biglietto(string nome, string cognome, bool ridotto, int sala)
        {
            Cliente = new Utente(nome, cognome);
            Ridotto = ridotto;
            Sala = sala;
        }

    }

    class Utente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Utente(string nome, string cognome) 
        { 
            Nome = nome;
            Cognome= cognome;
        }
    }
}