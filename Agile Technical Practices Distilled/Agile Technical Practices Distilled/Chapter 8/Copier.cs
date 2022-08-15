namespace Agile_Technical_Practices_Distilled.Chapter_8
{
    public class Copier
    {
        private readonly ISource source;
        private readonly IDestination destination;
        private bool IsCopierDisabled = false;

        public Copier(ISource source, IDestination destination)
        {
            this.source = source;
            this.destination = destination;
        }

        public void Copy()
        {
            if (IsCopierDisabled)
            {
                return; 
            }

            var sourceChar = source.GetChar();

            if (CharacterIsNewline(sourceChar))
            {
                IsCopierDisabled = true;
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
