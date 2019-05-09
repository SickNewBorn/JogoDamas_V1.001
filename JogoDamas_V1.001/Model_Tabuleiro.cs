using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDamas_V1._001
{
    public class Model_Tabuleiro
    {
        public int Linhas { get; private set; }
        public int Colunas { get; private set; }
        public Model_Pedras Mat { get; private set; }
        public int NumPedrasBrancas { get; private set; }
        public int NumPedrasPretas { get; private set; }


    }
}
