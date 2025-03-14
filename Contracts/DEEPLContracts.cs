using DeepL;
using DeepL.Model;
using Aniflix.Functions;

namespace Aniflix.Contracts
{
    public class DEEPLContracts
    {
        private readonly DeepLClient _client = new(GlobalVars.DEEPL_KEY);

        public async Task<TextResult> Translate(string text) =>
            await _client.TranslateTextAsync(text, null, LanguageCode.PortugueseBrazilian);
    }
}
