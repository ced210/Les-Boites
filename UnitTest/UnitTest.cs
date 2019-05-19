using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Les_Boites;
using FluentAssertions;

namespace UnitTest
{
    class MasterBoxTest
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void Spec_Empty_Test()
        {
            MasterBoite mb = new MasterBoite();
            mb.Height.Should().Be(0);
            mb.Width.Should().Be(0);
            mb.Text.Should().BeEmpty();
        }

        [Test]
        public void Spec_SimpleText_Test()
        {
            MasterBoite mb = new MasterBoite("yo");
            mb.Height.Should().Be(1);
            mb.Width.Should().Be(2);
            mb.Text.Should().BeEquivalentTo(new List<string>() { "yo" });
        }

        [Test]
        public void Spec_MultiLineText_Test()
        {
            MasterBoite mb = new MasterBoite("yo\ncornet");
            mb.Height.Should().Be(2);
            mb.Width.Should().Be(6);
            mb.Text.Should().BeEquivalentTo(new List<string>() { "yo    ", "cornet" });
        }

    }
    class BoiteTest
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void Spec_Empty_Test()
        {
            Boite b = new Boite();
            b.Height.Should().Be(0);
            b.Width.Should().Be(0);
            b.Text.Should().BeEmpty();
        }

        [Test]
        public void Spec_SimpleText_Test()
        {
            Boite b = new Boite("yo");
            b.Height.Should().Be(1);
            b.Width.Should().Be(2);
            b.Text.Should().BeEquivalentTo(new List<string>() { "yo" });
        }

        [Test]
        public void Spec_MultiLineText_Test()
        {
            Boite b = new Boite("yo\ncornet");
            b.Height.Should().Be(2);
            b.Width.Should().Be(6);
            b.Text.Should().BeEquivalentTo(new List<string>() { "yo    ", "cornet" });
        }
    }

    class ComboHoziontal_Test
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void MultiLine_WithSameHeight()
        {
            Boite leftBox = new Boite("yo");
            Boite rigthBox = new Boite("Mr");
            ComboHorizontal cb = new ComboHorizontal(leftBox, rigthBox);

            cb.Height.Should().Be(1);
            cb.Width.Should().Be(5);
        }

        [Test]
        public void MultiLine_WithDifferentHeight()
        {
            Boite leftBox = new Boite("yo");
            Boite rigthBox = new Boite("Mr\ncornet");
            ComboHorizontal cb = new ComboHorizontal(leftBox, rigthBox);

            cb.Height.Should().Be(2);
            cb.Width.Should().Be(9);

            List<string> expectedText = new List<string>() { "yo|Mr    ", "  |cornet" };
            cb.Text.Should().BeEquivalentTo(expectedText);
        }
    }

    class ComboVertical_Test
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void MultiLine_WithSameWidth()
        {
            Boite topBox = new Boite("yo");
            Boite bottomBox = new Boite("Mr");
            ComboVertical cb = new ComboVertical(topBox, bottomBox);

            cb.Height.Should().Be(3);
            cb.Width.Should().Be(2);
        }

        [Test]
        public void MultiLine_WithDifferentHeight()
        {
            Boite topBox = new Boite("yo");
            Boite bottomBox = new Boite("Mr\ncornet");
            ComboVertical cb = new ComboVertical(topBox, bottomBox);

            cb.Height.Should().Be(4);
            cb.Width.Should().Be(6);

            List<string> expectedText = new List<string>() { "yo    ", "------","Mr    ", "cornet" };
            cb.Text.Should().BeEquivalentTo(expectedText);
        }
    }
}
