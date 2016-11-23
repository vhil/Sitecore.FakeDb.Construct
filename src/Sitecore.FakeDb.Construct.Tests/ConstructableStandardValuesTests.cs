using FluentAssertions;
using NUnit.Framework;
using Sitecore.Data;

namespace Sitecore.FakeDb.Construct.Tests
{
    [TestFixture]
    public class ConstructableStandardValuesTests
    {
        [Test]
        public void AssignableDbTemplate_ReturnsTargetType()
        {
            // setup
            var standardValues = new TestStandardValues() as ConstructableStandardValues<TestDbTemplate>;

            // act
            var type = standardValues.AssignableDbTemplate;

            // assert
            type.ShouldBeEquivalentTo(typeof(TestDbTemplate));
        }

        [Test]
        public void Indexer_KnownID_ReturnsKnownValue()
        {
            // setup
            var standardValues = new TestStandardValues() as ConstructableStandardValues<TestDbTemplate>;
            
            // act
            var value = standardValues[TestDbTemplate.FieldIds.NavigationTitle];

            // assert
            value.ShouldBeEquivalentTo("$name");
        }

        [Test]
        public void Indexer_UnknownID_ReturnsEmptyString()
        {
            // setup
            var standardValues = new TestStandardValues() as ConstructableStandardValues<TestDbTemplate>;

            // act
            var actualValue = standardValues[ID.NewID];

            // assert
            actualValue.ShouldBeEquivalentTo(string.Empty);
        }

        [Test]
        public void Indexer_StandardValuesInitializedFromDerivedClass()
        {
          
        }
    }
}
