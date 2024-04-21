using System.Collections.Generic;

namespace Application
{
    public class ModelBase
    {
        public List<string> ProcessarDadosAPI(List<string> dados) => dados;
        public List<string> RecolherDadosFicheiro() => new List<string> { "Dados do arquivo" };
    }
}