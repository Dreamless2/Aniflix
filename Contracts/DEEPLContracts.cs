using DeepL;
using Aniflix.Functions;

namespace Aniflix.Contracts
{
    public class DEEPLContracts
    {
        private readonly DeepLClient _client = new(GlobalVars.DEEPL_KEY);
        private readonly string _sourceLanguage = "EN";
        private readonly string _targetLanguage = "PT-BR";
    }
}
