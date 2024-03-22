using CsLox;

namespace CsLoxTest
{
    public class ScannerTest
    {
        [Fact]
        public void Can_Scan_Token()
        {
            var scanner = new Scanner("var language = \"lox\";");
            var tokens = scanner.Scan();

            Assert.Equal(5, tokens.Count);
        }
    }
}