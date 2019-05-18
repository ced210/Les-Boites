using NUnit.Framework;
using FluentAssertions;

using Les_Boites;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }


        [Test]
        public void TestStats_EmptyBox()
        {
            Box box = new Box();

            box.Height.Should().Be(0);
            box.Width.Should().Be(0);
            box.Text.Should().BeNull();
        }


        [Test]
        public void TestStats_MultiLineBox()
        {
            Box box = new Box("Man! Hey!!!\r\nceci est un test\r\nmultiligne");

            box.Height.Should().Be(3);
            box.Width.Should().Be(16);
            box.Text.Should().BeEquivalentTo("Man! Hey!!!\r\nceci est un test\r\nmultiligne");
        }

        [Test]
        public void TestFrameSetTopBottom()
        {
            Box box = new Box("yo");
            box.frame.TopBottom.Should().BeEquivalentTo("+--+");
        }

        [Test]
        public void TestFrameSetCenter()
        {
            Box box = new Box("yo");
            box.frame.Center.Should().BeEquivalentTo("|yo|");
        }

        [Test]
        public void TestBoxPlusFrame()
        {
            Box box = new Box("yo");
            box.frame.TopBottom.Should().BeEquivalentTo("+--+");
            box.frame.Center.Should().BeEquivalentTo("|yo|");

        }
    }
}