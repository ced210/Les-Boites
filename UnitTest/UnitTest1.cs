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
            Box box = new Box("Man! Hey!!! \n\rceci est un test \n\rmultiligne");

            box.Height.Should().Be(3);
            box.Width.Should().Be(16);
            box.Text.Should().BeNull("Man! Hey!!! \n\rceci est un test \n\rmultiligne");
        }
    }
}