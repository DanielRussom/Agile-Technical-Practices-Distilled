namespace Agile_Technical_Practices_Distilled.Chapter_8
{
    public class Copier
    {
        private readonly ISource source;
        private readonly IDestination destination;

        public Copier(ISource source, IDestination destination)
        {
            this.source = source;
            this.destination = destination;
        }

        public void Copy()
        {
            var sourceChar = source.GetChar();

            if (CharacterIsNewline(sourceChar))
            {
                return;
            }

            destination.SetChar(sourceChar);

        }

        private static bool CharacterIsNewline(char sourceChar)
        {
            return sourceChar == '\n';
        }
    }
}
