using System.Text.Json;
using CsLox;

namespace CsLoxTest
{
    public class ScannerTest
    {
        // [Fact]
        // public void Can_Scan_Token_Keyword()
        // {
        //     var scanner = new Scanner("var");
        //     var tokens = scanner.Scan();

        //     Assert.Single(tokens);
        // }

        [Fact]
        public void Can_Scan_Token_SingleChar()
        {
            var scanner = new Scanner("   =   ");
            var tokens = scanner.Scan();

            Assert.Equal(2, tokens.Count);
        }

        [Fact]
        public void Can_Scan_Token_SingleChar_All()
        {
            var scanner = new Scanner("(){},.-+;/*");
            var tokens = scanner.Scan();

            Assert.Equal(12, tokens.Count);
            Assert.Equal(tokens, [
                new Token(Token.TokenType.LEFT_PAREN),
                new Token(Token.TokenType.RIGHT_PAREN),
                new Token(Token.TokenType.LEFT_BRACE),
                new Token(Token.TokenType.RIGHT_BRACE),
                new Token(Token.TokenType.COMMA),
                new Token(Token.TokenType.DOT),
                new Token(Token.TokenType.MINUS),
                new Token(Token.TokenType.PLUS),
                new Token(Token.TokenType.SEMICOLON),
                new Token(Token.TokenType.SLASH),
                new Token(Token.TokenType.STAR),
                new Token(Token.TokenType.EOF),
            ]);
        }

        // [Fact]
        // public void Can_Scan_Token()
        // {
        //     var scanner = new Scanner("var language = \"lox\";");
        //     var tokens = scanner.Scan();

        //     Assert.Equal(5, tokens.Count);
        // }
    }
}