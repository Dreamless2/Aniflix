﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (new[] { alphas, numerics, dashes, underlines, spaces, periods }.All(x => !x))
                return value;

            var whitelistChars = new HashSet<char>(
                string.Concat(
                        alphas ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" : "",
                        numerics ? "0123456789" : "",
                        dashes ? "-" : "",
                        underlines ? "_" : "",
                        periods ? "." : "",
                        spaces ? " " : ""
                    )
                    .ToCharArray()
            );

            var scrubbedValue = value
                .Aggregate(
                    new StringBuilder(),
                    (sb, @char) =>
                    {
                        if (whitelistChars.Contains(@char))
                            sb.Append(@char);
                        return sb;
                    }
                )
                .ToString();

            return scrubbedValue;
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
    }
}
