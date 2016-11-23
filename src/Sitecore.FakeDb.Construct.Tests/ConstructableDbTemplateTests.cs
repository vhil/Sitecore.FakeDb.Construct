using System;
using FluentAssertions;
using NUnit.Framework;

namespace Sitecore.FakeDb.Construct.Tests
{
    [TestFixture]
    public class ConstructableDbTemplateTests
    {
        [Test]
        public void ConstructDbTemplate_NullStandardValues_CreatesDefaultStandardValues()
        {
            using (var db = new Db())
            {
                // setup
                var template = new ConstructableDbTemplateVerifier();

                // act
                template.ConstructDbTemplate(db, null);

                // assert
                template.ConstructTemplateWasCalled.Should().BeTrue();
                template.StandardValues.Should().NotBeNull();
                template.StandardValues.GetType().ShouldBeEquivalentTo(typeof(DefaultStandardValues));
            }
        }
    }

    public class ConstructableDbTemplateVerifier : ConstructableDbTemplate
    {
        public Db Db;
        public ConstructableStandardValues StandardValues;
        public bool ConstructTemplateWasCalled;

        protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
        {
            this.ConstructTemplateWasCalled = true;
            this.Db = db;
            this.StandardValues = standardValues;
        }
    }
}
