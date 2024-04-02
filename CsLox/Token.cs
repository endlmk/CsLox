namespace CsLox
{
    public record Token
    {
        public enum TokenType
        {
            Equal,
            Var,
        };

        TokenType Type;
    }
}