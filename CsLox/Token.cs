using System.Text.Json;

namespace CsLox
{
    public record Token(Token.TokenType Type)
    {
        public enum TokenType
        {
            Equal,
            Var,
            LEFT_PAREN,
            RIGHT_PAREN,
            LEFT_BRACE,
            RIGHT_BRACE,
            COMMA,
            DOT,
            MINUS,
            PLUS,
            SEMICOLON,
            SLASH,
            STAR,
            EOF,
        };
    }
}