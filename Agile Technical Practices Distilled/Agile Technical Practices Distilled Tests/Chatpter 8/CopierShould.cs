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
        [DataRow ('a')]
        [DataRow('b')]
        public void Copy_expected_characters(char input)
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<ISource>().Setup(x => x.GetChar()).Returns(input);

                var ToTest = mock.Create<Copier>();

                ToTest.Copy();

                mock.Mock<ISource>().Verify(x => x.GetChar(), Times.Exactly(1));
                mock.Mock<IDestination>().Verify(x => x.SetChar(input), Times.Exactly(1));
            }
        }
    }
}
