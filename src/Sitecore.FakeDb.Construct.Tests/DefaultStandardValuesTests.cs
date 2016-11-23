using System;
using FluentAssertions;
using NUnit.Framework;
using Sitecore.Data;

namespace Sitecore.FakeDb.Construct.Tests
{
    [TestFixture]
    public class DefaultStandardValuesTests
    {
        [Test]
        [TestCase("{AB15FD73-CD82-4CF5-A9F1-FEFF00A52B74}")]
        [TestCase("{41E2C8AF-484C-489A-A414-CE6365387941}")]
        public void Indexer_ValidId_ReturnsEmptyString(string fieldIdString)
        {
            // setup
            var instance = new DefaultStandardValues();

            // act
            var value = instance[new ID(fieldIdString)];

            // assert
            value.Should().BeEmpty();
        }
    }
}
