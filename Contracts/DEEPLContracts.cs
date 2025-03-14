using DeepL;
using DeepL.Model;
using Aniflix.Functions;

namespace Aniflix.Contracts
{
    public class DEEPLContracts
    {
        private readonly DeepLClient _client = new DeepLClient(GlobalVars.DEEPL_KEY)
        {
            MaximumNetwortRetries = 5
        };
    }


}
