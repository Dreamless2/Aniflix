using System;
using System.Linq;
using System.Text;
using TMDbLib.Client;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aniflix.Contracts
{
    public class DEEPLContracts
    {
        private readonly DeepLClient _client = new("d1f15ac0632492b3c3a940032ad6b95b")
        {
            DefaultLanguage = "pt-BR",
            DefaultCountry = "BR",
            Timeout = TimeSpan.FromSeconds(600)
        };

    }
}
