#region "Copyright"
/***********************************************************************************
* Copyright (C) 2025  Tiago.NET
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program.  If not, see <https://www.gnu.org/licenses/>.
**********************************************************************************/
#endregion

using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Aniflix.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveDiacritics(this string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder(normalizedString.Length);

            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString();
        }

        public static string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException(
                    $"{nameof(input)} cannot be empty",
                    nameof(input)
                ),
                _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1)),
            };

        public static string FirstCharToLower(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException(
                    $"{nameof(input)} cannot be empty",
                    nameof(input)
                ),
                _ => string.Concat(input[0].ToString().ToLower(), input.AsSpan(1)),
            };

        public static string RemoveExcept(
        string value,
        bool alphas = false,
        bool numerics = false,
        bool dashes = false,
        bool underlines = false,
        bool spaces = false,
        bool periods = false
    )
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            var pattern = $"[^{(alphas ? "a-zA-Z" : "")}" +
                          $"{(numerics ? "0-9" : "")}" +
                          $"{(dashes ? "-" : "")}" +
                          $"{(underlines ? "_" : "")}" +
                          $"{(spaces ? " " : "")}" +
                          $"{(periods ? "\\." : "")}]";

            return Regex.Replace(value, pattern, "");
        }

        public static string ClearLists(IEnumerable<string> names)
        {
            HashSet<string> uniqueNames = [];

            foreach (var name in names)
            {
                string cleanName = new([.. name.RemoveDiacritics().Where(char.IsAscii)]);
                uniqueNames.Add($"{cleanName.Replace(" ", "")}");
            }

            return string.Join(" ", uniqueNames);
        }

        public static string StripPunctuation(this string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string RemoveAccents(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString.EnumerateRunes())
            {
                var unicodeCategory = Rune.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public static bool HasAccents(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            string normalized = input.Normalize(NormalizationForm.FormD);
            return Regex.IsMatch(normalized, @"\p{M}");
        }
        public static string CleanString(string input)
        {
            string normalized = input.Normalize(NormalizationForm.FormD);
            string withoutAccents = Regex.Replace(normalized, "[^a-zA-Z# ]", "");
            return Regex.Replace(withoutAccents, @"[\p{P}&&[^#]]", "");
        }
    }
}
