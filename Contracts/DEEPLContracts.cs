using DeepL;
using DeepL.Model;
using Aniflix.Functions;

namespace Aniflix.Contracts
{
    public class DEEPLContracts
    {
        private readonly DeepLClient _client = new(GlobalVars.DEEPL_KEY);

        public async Task<string> Translate(string text, string targetLanguage) =>
            await _client.TranslateTextAsync(text, targetLanguage);


    }


}
