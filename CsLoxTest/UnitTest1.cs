using CsLox;

namespace CsLoxTest
{
    public class ScannerTest
    {
        [Fact]
        public void Can_Scan_Token_Keyword()
        {
            var scanner = new Scanner("var");
            var tokens = scanner.Scan();

            Assert.Single(tokens);
        }

        [Fact]
        public void Can_Scan_Token_SingleChar()
        {
            var scanner = new Scanner("   =   ");
            var tokens = scanner.Scan();

            Assert.Single(tokens);
        }

        [Fact]
        public void Can_Scan_Token_SingleChar_All()
        {
            var scanner = new Scanner("(){},.-+;/*");
            var tokens = scanner.Scan();

            Assert.Equal(11, tokens.Count);
        }

        [Fact]
        public void Can_Scan_Token()
        {
            var scanner = new Scanner("var language = \"lox\";");
            var tokens = scanner.Scan();

            Assert.Equal(5, tokens.Count);
        }
    }
}