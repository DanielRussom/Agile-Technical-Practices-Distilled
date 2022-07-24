namespace Agile_Technical_Practices_Distilled.Chapter_5
{
    public class InvalidMoveException : Exception
    {
        public InvalidMoveException(string message) : base(message)
        {
        }
    }
}