using System;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;
using Sitecore.Data;
using Sitecore.Globalization;

namespace Sitecore.FakeDb.Construct.Tests
{
    [TestFixture]
    public class DbConstructFactoryTests
    {
        [Test]
        public void ConstructDb_FromAssembly_ConstructsRequiredTypes()
        {
            using (var db = DbConstructFactory.ConstructDb(Assembly.GetExecutingAssembly()))
            {
                // act
                var templates = db.Database.Templates.GetTemplates(Language.Parse("en"));

                // assert
                templates.Should().Contain(x => x.ID == NavigationDbTemplate.TemplateId);
            }
        }

        [Test]
        public void ConstructDb_FromAssembly_DoesNotConstructAbstractClasses()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void ConstructDb_StandardValuesBoundToRelevantTemplates()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void ConstructDb_ExampleTemplates_FieldsBoundCorrectly()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void ConstructDb_ExampleTemplates_StandardValuesAppliedToFakeDb()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void ConstructDb_ExampleTemplates_StandardValuesReplaceTokensAppliedCorrectlyToFakeDb()
        {
            using (var db = DbConstructFactory.ConstructDb(new [] {new NavigationDbTemplate()}, new [] {new NavigationStandardValues()}))
            {
                var currentItemId = ID.NewID;
                // setup
                var navRootItem = new DbItem("root", currentItemId, NavigationDbTemplate.TemplateId);

                db.Add(navRootItem);

                var currentItem = db.GetItem(currentItemId);

                // act

                // assert
                currentItem.Should().NotBeNull();
                currentItem[NavigationDbTemplate.FieldNames.NavigationTitle].Should().BeEquivalentTo("root");
            }
        }
    }
}
