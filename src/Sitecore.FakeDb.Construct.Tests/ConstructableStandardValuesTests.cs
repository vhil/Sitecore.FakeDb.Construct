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
            var standardValues = new NavigationStandardValues() as ConstructableStandardValues<NavigationDbTemplate>;

            // act
            var actualType = standardValues.AssignableDbTemplate;

            // assert
            actualType.ShouldBeEquivalentTo(typeof(NavigationDbTemplate));
        }

        [Test]
        public void Indexer_KnownID_ReturnsKnownValue()
        {
            // setup
            var standardValues = new NavigationStandardValues() as ConstructableStandardValues<NavigationDbTemplate>;
            
            // act
            var actualValue = standardValues[NavigationDbTemplate.FieldIds.NavigationTitle];

            // assert
            actualValue.ShouldBeEquivalentTo("$name");
        }

        [Test]
        public void Indexer_UnknownID_ReturnsEmptyString()
        {
            // setup
            var standardValues = new NavigationStandardValues() as ConstructableStandardValues<NavigationDbTemplate>;

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
