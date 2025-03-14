using DeepL;
using System;
using System.Linq;
using System.Text;
using TMDbLib.Client;
using Aniflix.Functions;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Collections.Generic;

namespace Aniflix.Contracts
{
    public class DEEPLContracts
    {
        private readonly DeepLClient _client = new(GlobalVars.DEEPL_KEY);

        private readonly string _sourceLanguage = "EN";
        private readonly string _targetLanguage = "PT-BR";

        public DEEPLContracts()
        {

        }



    }
}
