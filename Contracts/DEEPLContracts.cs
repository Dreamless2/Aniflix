using DeepL;
using DeepL.Model;
using Aniflix.Functions;

namespace Aniflix.Contracts
{
    public class DEEPLContracts
    {

        var DeepLClientOptions _options = new ()
        {
            MaximumNetworkRetries = 5,
            PerRetryConnectionTimeout = TimeSpan.FromSeconds(10),
            sendPlatformInfo = false,
        };


    DeepLClient _client = new(GlobalVars.DEEPL_KEY, _options)

    }


}
