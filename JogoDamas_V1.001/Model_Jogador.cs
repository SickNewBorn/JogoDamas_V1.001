using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDamas_V1._001
{
    public class Model_Jogador
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int Num { get; private set; }
        public string Nacionalidade { get; private set; }
        public int Jogos { get; private set; }
        public int Vitorias { get; private set; }
        public int Derrotas { get; private set; }
        public int Abandono { get; private set; }
        public int Empate { get; private set; }
        public float Percent_Vit { get; private set; }
        public float Percent_Der { get; private set; }
        public float Percent_Aband { get; private set; }
        public float Percent_Emp { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }//é necessário encriptar


    }
}
