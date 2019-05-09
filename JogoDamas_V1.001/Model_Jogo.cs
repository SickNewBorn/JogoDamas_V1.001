using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDamas_V1._001
{
    public class Model_Jogo
    {
        public Model_Jogador J1 { get; private set; }
        public Model_Jogador J2 { get; private set; }
        public Model_Tabuleiro AreaDeJogo { get; private set; }
        public int Turno { get; private set; }
        public int PedrasBrancas { get; private set; }
        public int PedrasPretas { get; private set; }
        public int DamasBrancas { get; private set; }
        public int DamasPretas { get; private set; }

    }
}
