
namespace CsLox
{
    public class Scanner
    {
        private string _v;
        private int _current = 0;

        public Scanner(string v)
        {
            _v = v;
        }

        public List<Token> Scan()
        {
            var tokens = new List<Token>();

            string[] keywords = { "var" };

            char[] singleCharactors = { '=' };

            while (_current < _v.Length)
            {
                if (_v[_current] == ' ')
                {
                    ++_current;
                    continue;
                }

                if (_v[_current] == singleCharactors[0])
                {
                    tokens.Add(new Token());
                    ++_current;
                    continue;
                }

                var foundAt = _v.IndexOf(keywords[0], _current);
                if (foundAt >= 0)
                {
                    tokens.Add(new Token());
                    _current = foundAt + keywords[0].Length;
                    continue;
                }

                ++_current;
            }

            return tokens;
        }
    }
}