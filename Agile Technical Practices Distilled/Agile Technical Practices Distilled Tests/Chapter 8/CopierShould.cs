using Agile_Technical_Practices_Distilled.Chapter_8;
using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_8
{
    [TestClass]
    public class CopierShould
    {
        [TestMethod]
        [DataRow ('a')]
        [DataRow('b')]
        public void Copy_expected_character(char input)
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

        [TestMethod]
        public void Copy_all_expected_characters()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var ToTest = mock.Create<Copier>();

                mock.Mock<ISource>().Setup(x => x.GetChar()).Returns('a');
                ToTest.Copy();

                mock.Mock<ISource>().Setup(x => x.GetChar()).Returns('b');
                ToTest.Copy();

                mock.Mock<ISource>().Verify(x => x.GetChar(), Times.Exactly(2));
                mock.Mock<IDestination>().Verify(x => x.SetChar('a'), Times.Exactly(1));
                mock.Mock<IDestination>().Verify(x => x.SetChar('b'), Times.Exactly(1));
            }
        }

        [TestMethod]
        public void Not_copy_newline_character()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var ToTest = mock.Create<Copier>();

                mock.Mock<ISource>().Setup(x => x.GetChar()).Returns('\n');
                ToTest.Copy();

                mock.Mock<ISource>().Verify(x => x.GetChar(), Times.Exactly(1));
                mock.Mock<IDestination>().Verify(x => x.SetChar(It.IsAny<char>()), Times.Exactly(0));
            }
        }

        [TestMethod]
        public void Not_copy_characters_after_newline()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var ToTest = mock.Create<Copier>();

                mock.Mock<ISource>().Setup(x => x.GetChar()).Returns('a');
                ToTest.Copy();
                mock.Mock<ISource>().Setup(x => x.GetChar()).Returns('\n');
                ToTest.Copy();
                mock.Mock<ISource>().Setup(x => x.GetChar()).Returns('b');
                ToTest.Copy();

                mock.Mock<ISource>().Verify(x => x.GetChar(), Times.Exactly(2));
                mock.Mock<IDestination>().Verify(x => x.SetChar(It.IsAny<char>()), Times.Exactly(1));
            }
        }
    }
}
