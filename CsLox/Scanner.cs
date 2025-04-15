
namespace CsLox
{
    public class Scanner
    {
        private string _v;
        private int _start = 0;
        private int _current = 0;

        public Scanner(string v)
        {
            _v = v;
        }

        public List<Token> Scan()
        {
            var tokens = new List<Token>();

            string[] keywords = { "var" };

            var singleCharactors = new Dictionary<char, Token.TokenType>
            { 
                { '=', Token.TokenType.Equal },
                { '(', Token.TokenType.LEFT_PAREN },
                { ')', Token.TokenType.RIGHT_PAREN },
                { '{', Token.TokenType.LEFT_BRACE },
                { '}', Token.TokenType.RIGHT_BRACE },
                { ',', Token.TokenType.COMMA },
                { '.', Token.TokenType.DOT },
                { '-', Token.TokenType.MINUS },
                { '+', Token.TokenType.PLUS },
                { ';', Token.TokenType.SEMICOLON },
                { '/', Token.TokenType.SLASH },
                { '*', Token.TokenType.STAR }
            };

            while (_current < _v.Length)
            {
                if (_v[_current] == ' ')
                {
                    Advance();
                    continue;
                }

                if (singleCharactors.TryGetValue(_v[_current], out var tokenType))
                {
                    tokens.Add(new Token(tokenType));
                    Advance();
                    continue;
                }

                var foundAt = _v.IndexOf(keywords[0], _current);
                if (foundAt >= 0)
                {
                    tokens.Add(new Token(Token.TokenType.Var));
                    _current = foundAt + keywords[0].Length;
                    continue;
                }

                ++_current;
            }

            tokens.Add(new Token(Token.TokenType.EOF));

            return tokens;
        }

        private void Advance()
        {
            ++_current;
        }
    }
}