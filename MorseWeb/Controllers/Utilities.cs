using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorseWeb.Controllers
{
  public static class Utilities
  {
    static string Dot = "∙ ";
    static string Dash = "- ";
    private static Dictionary<char, string> _morseAlphabetDictionary = CreateMorseAlphabetDictionary();

    private static Dictionary<char, string> CreateMorseAlphabetDictionary()
    {
      return new Dictionary<char, string>()
    {
            { 'A', Dot + Dash },
            { 'B', Dash + Dot + Dot + Dot },
            { 'C', Dash + Dot + Dash + Dot },
            { 'D', Dash + Dot + Dot },
            { 'E', Dot },
            { 'F', Dot + Dot + Dash + Dot },
            { 'G', Dash + Dash + Dot },
            { 'H', Dot + Dot + Dot + Dot },
            { 'I', Dot + Dot },
            { 'J', Dot + Dash + Dash + Dash },
            { 'K', Dash + Dot + Dash },
            { 'L', Dot + Dash + Dot + Dot },
            { 'M', Dash + Dash },
            { 'N', Dash + Dot },
            { 'O', Dash + Dash + Dash },
            { 'P', Dot + Dash + Dash + Dot },
            { 'Q', Dash + Dash + Dot + Dash },
            { 'R', Dot + Dash + Dot },
            { 'S', Dot + Dot + Dot },
            { 'T', Dash },
            { 'U', Dot + Dot + Dash },
            { 'V', Dot + Dot + Dot + Dash },
            { 'W', Dot + Dash + Dash },
            { 'X', Dash + Dot + Dot + Dash },
            { 'Y', Dash + Dot + Dash + Dash },
            { 'Z', Dash + Dash + Dot + Dot },
            { ' ', "\n" },
            { '_', "\n" },
            { '0', Dash + Dash + Dash + Dash + Dash },
            { '1', Dot + Dash + Dash + Dash + Dash },
            { '2', Dot + Dot + Dash + Dash + Dash },
            { '3', Dot + Dot + Dot + Dash + Dash },
            { '4', Dot + Dot + Dot + Dot + Dash },
            { '5', Dot + Dot + Dot + Dot + Dot },
            { '6', Dash + Dot + Dot + Dot + Dot },
            { '7', Dash + Dash + Dot + Dot + Dot },
            { '8', Dash + Dash + Dash + Dot + Dot },
            { '9', Dash + Dash + Dash + Dash + Dot }
         };
    }

    public static string ConvertWordsToMorse(string[] words)
    {
      string morseCode = string.Empty;
      foreach (string word in words)
      {
        char[] chars = word.ToCharArray();
        morseCode += ConvertLettersToMorse(chars);
      }
      return morseCode;
    }

    private static string ConvertLettersToMorse(char[] chars)
    {
      string morseCode = string.Empty;
      foreach (char character in chars)
      {
        morseCode += GetMorseForChar(character) + $"{"",3}";
      }
      return morseCode;
    }

    private static string GetMorseForCharFromDictionary(char character)
    {
      return _morseAlphabetDictionary[character];
    }

    private static string GetMorseForChar(char character)
    {
      string dot = "∙ ";
      string dash = "- ";

      switch (character)
      {
        case 'A': return dot + dash;

        case 'B': return dash + dot + dot + dot;

        case 'C': return dash + dot + dash + dot;

        case 'D': return dash + dot + dot;

        case 'E': return dot;

        case 'F': return dot + dot + dash + dot;

        case 'G': return dash + dash + dot;

        case 'H': return dot + dot + dot + dot;

        case 'I': return dot + dot;

        case 'J': return dot + dash + dash + dash;

        case 'K': return dash + dot + dash;

        case 'L': return dot + dash + dot + dot;

        case 'M': return dash + dash;

        case 'N': return dash + dot;

        case 'O': return dash + dash + dash;

        case 'P': return dot + dash + dash + dot;

        case 'Q': return dash + dash + dot + dash;

        case 'R': return dot + dash + dot;

        case 'S': return dot + dot + dot;

        case 'T': return dash;

        case 'U': return dot + dot + dash;

        case 'V': return dot + dot + dot + dash;

        case 'W': return dot + dash + dash;

        case 'X': return dash + dot + dot + dash;

        case 'Y': return dash + dot + dash + dash;

        case 'Z': return dash + dash + dot + dot;

        case ' ': return "\n";

        case '_': goto case ' ';

        case '0': return dash + dash + dash + dash + dash;

        case '1': return dot + dash + dash + dash + dash;

        case '2': return dot + dot + dash + dash + dash;

        case '3': return dot + dot + dot + dash + dash;

        case '4': return dot + dot + dot + dot + dash;

        case '5': return dot + dot + dot + dot + dot;

        case '6': return dash + dot + dot + dot + dot;

        case '7': return dash + dash + dot + dot + dot;

        case '8': return dash + dash + dash + dot + dot;

        case '9': return dash + dash + dash + dash + dot;

        default: return "";
      }
    }
  }
}
