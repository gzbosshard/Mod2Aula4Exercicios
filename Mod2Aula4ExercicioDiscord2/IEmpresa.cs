using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Aula4ExercicioDiscord2
{
    internal interface IEmpresa
    {
        public string NomeEmpresa { get; set; }
        public int QuantidadeFuncionarios { get; set; }

        public void ImprimirInfosEmpresa();
        public abstract void RealizarVenda();
    }
}
