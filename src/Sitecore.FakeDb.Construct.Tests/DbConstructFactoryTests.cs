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
                templates.Should().Contain(x => x.ID == TestDbTemplate.TemplateId);
            }
        }

        [Test]
        public void GetConstructableTemplates_FromAssembly_ReturnsListOfConstructableDbTemplateInstances()
        {
            // setup
            var assembly = Assembly.GetExecutingAssembly();

            // act
            var templates = DbConstructFactory.GetConstructableTemplates(assembly);

            // assert
            templates.Should().NotBeEmpty();
            templates.Should().NotContain(x => x == null);
            templates.Should().ContainItemsAssignableTo<ConstructableDbTemplate>();
        }

        [Test]
        public void GetConstructableTemplates_FromAssembly_DoesNotConstructAbstractClasses()
        {
            // setup
            var assembly = Assembly.GetExecutingAssembly();

            // act
            var templates = DbConstructFactory.GetConstructableTemplates(assembly);

            // assert
            templates.Should().NotContain(x => x.GetType() == typeof (AbstractDbTemplate));
        }

        [Test]
        public void GetConstructableTemplates_NullParameter_ThrowsArgumentNullException()
        {
            // setup
            Assembly assembly = null;

            // act
            Action action = () => DbConstructFactory.GetConstructableTemplates(assembly);

            // assert
            action.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void GetConstructableStandardValues_FromAssembly_ReturnsListOfConstructableStandardValuesInstances()
        {
            // setup
            var assembly = Assembly.GetExecutingAssembly();

            // act
            var templates = DbConstructFactory.GetConstructableStandardValues(assembly);

            // assert
            templates.Should().NotBeEmpty();
            templates.Should().NotContain(x => x == null);
            templates.Should().ContainItemsAssignableTo<ConstructableStandardValues>();
        }

        [Test]
        public void GetConstructableStandardValues_FromAssembly_DoesNotConstructAbstractClasses()
        {
            // setup
            var assembly = Assembly.GetExecutingAssembly();

            // act
            var templates = DbConstructFactory.GetConstructableStandardValues(assembly);

            // assert
            templates.Should().NotContain(x => x.GetType() == typeof(AbstractStandardValues));
        }

        [Test]
        public void GetConstructableStandardValues_NullParameter_ThrowsArgumentNullException()
        {
            // setup
            Assembly assembly = null;

            // act
            Action action = () => DbConstructFactory.GetConstructableStandardValues(assembly);

            // assert
            action.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void ConstructDb_ExampleTemplates_StandardValuesReplaceTokensAppliedCorrectlyToFakeDb()
        {
            using (var db = DbConstructFactory.ConstructDb(new [] {new TestDbTemplate()}, new [] {new TestStandardValues()}))
            {
                // setup
                var currentItemId = ID.NewID;
                var navRootItem = new DbItem("root", currentItemId, TestDbTemplate.TemplateId);

                db.Add(navRootItem);

                // act
                var currentItem = db.GetItem(currentItemId);

                // assert
                currentItem.Should().NotBeNull();
                currentItem[TestDbTemplate.FieldNames.NavigationTitle].Should().BeEquivalentTo("root");
            }
        }
    }
}
