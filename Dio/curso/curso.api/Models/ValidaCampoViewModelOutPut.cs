using System.Collections.Generic;

namespace curso.api.Models.Usuarios
{
    public class ValidaCampoViewModelOutPut
    {

        public IEnumerable<string> Erros { get; private set; }

        public ValidaCampoViewModelOutPut(IEnumerable<string> erros)
        {
            Erros = erros;
        }

    }
}
