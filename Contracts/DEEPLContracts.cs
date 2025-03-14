using DeepL;
using DeepL.Model;
using Aniflix.Functions;

namespace Aniflix.Contracts
{
    public class DEEPLContracts
    {

        private DeepLClientOptions _options = new()
        {
            MaximumNetworkRetries = 5,
            PerRetryConnectionTimeout = TimeSpan.FromSeconds(10),
        }


        private readonly DeepLClient _client = new DeepLClient(GlobalVars.DEEPL_KEY)
        {

        };
    }


}
