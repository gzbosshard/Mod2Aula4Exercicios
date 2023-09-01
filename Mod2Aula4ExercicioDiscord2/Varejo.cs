using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Aula4ExercicioDiscord2
{
    internal class Varejo : Empresa, IEmpresa
    {
        public override void RealizarVenda()
        {
            Console.WriteLine("Varejo vende produtos");
        }
    }
}
