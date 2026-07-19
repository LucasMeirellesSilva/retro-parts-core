using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace RetroPecasAPI.Application.Common;

public static partial class SlugGenerator
{
    [GeneratedRegex(@"[\s_]+")]
    private static partial Regex SpacesRegex();

    [GeneratedRegex(@"[^a-z0-9-]")]
    private static partial Regex InvalidCharactersRegex();

    [GeneratedRegex(@"-+")]
    private static partial Regex MultipleHyphensRegex();

    public static string Generate(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        // Remove acentos
        string normalized = text.Normalize(NormalizationForm.FormD);

        StringBuilder builder = new();

        foreach (char c in normalized)
        {
            if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
            {
                builder.Append(c);
            }
        }

        text = builder.ToString().Normalize(NormalizationForm.FormC);

        // Minúsculas
        text = text.ToLowerInvariant();

        // Trata parênteses como separadores
        text = text
            .Replace("(", " ")
            .Replace(")", " ");

        // Espaços e underscores viram hífen
        text = SpacesRegex().Replace(text, "-");

        // Remove caracteres inválidos
        text = InvalidCharactersRegex().Replace(text, "");

        // Remove hífens duplicados
        text = MultipleHyphensRegex().Replace(text, "-");

        // Remove hífens do início e fim
        return text.Trim('-');
    }
}