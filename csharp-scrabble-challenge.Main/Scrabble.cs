using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Scrabble
    {

        private string _word;
        private int modifier = 1;

        Dictionary<char, int> scores = new Dictionary<char, int>()
            {
                {'a', 1}, {'e', 1}, {'i', 1}, {'o', 1}, {'u', 1}, {'l', 1}, {'n', 1}, {'r', 1}, {'s', 1}, {'t', 1},
                {'d', 2}, {'g', 2},
                {'b', 3}, {'c', 3}, {'m', 3}, {'p', 3},
                {'f', 4}, {'h', 4}, {'v', 4}, {'w', 4}, {'y', 4},
                {'k', 5},
                {'j', 8}, {'x', 8},
                {'q', 10}, {'z', 10}
            };

        public Scrabble(string word)
        {
            _word = word.Trim().ToLower();

            if (_word.StartsWith("[") && _word.EndsWith("]"))
            {
                _word = _word.Remove(0, 1);
                _word = _word.Remove(_word.Length - 1);
                modifier = 3;
            }
            else if (_word.StartsWith("{") && _word.EndsWith("}"))
            {
                _word =_word.Remove(0, 1);
                _word = _word.Remove(_word.Length - 1);
                modifier = 2;
            }
        }

        public int score()
        {

            int totalScore = 0;
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in _word)
            {
                if (scores.ContainsKey(c))
                {
                    totalScore += scores[c];
                }
            }

            foreach (KeyValuePair<char, int> kvp in counts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.WriteLine($"\nYour total score for this word is: {totalScore}");
            return totalScore * modifier;
        }
    }
}
