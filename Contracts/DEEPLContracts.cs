using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Client;

namespace Aniflix.Contracts
{
    public class DEEPLContracts
    {
        private readonly TMDbClient _client = new("d1f15ac0632492b3c3a940032ad6b95b")
        {
            DefaultLanguage = "pt-BR",
            DefaultCountry = "BR",
            Timeout = TimeSpan.FromSeconds(600)
        };

    }
}
