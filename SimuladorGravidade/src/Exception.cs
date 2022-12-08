using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGravidade.src
{
    [Serializable]
    internal class QtdCorposUltrapassadoException : Exception
    {
        public QtdCorposUltrapassadoException(string message)
            : base(message) { }
    }

    internal class MassaUltrapassadaException : Exception
    {
        public MassaUltrapassadaException(string message)
            : base(message) { }
    }
}
