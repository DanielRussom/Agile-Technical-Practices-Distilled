using Agile_Technical_Practices_Distilled.Chapter_8;
using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Agile_Technical_Practices_Distilled.Tests.Chatpter_8
{
    [TestClass]
    public class CopierShould
    {
        [TestMethod]
        public void Copy_single_character_string()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<ISource>().Setup(x => x.GetChar()).Returns('a');

                var ToTest = mock.Create<Copier>();

                ToTest.Copy();

                mock.Mock<ISource>().Verify(x => x.GetChar(), Times.Exactly(1));
                mock.Mock<IDestination>().Verify(x => x.SetChar('a'), Times.Exactly(1));
            }
        }
    }
}
