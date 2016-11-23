/*
This is example of generated constructable template classes.
*/

using System.Collections.Generic;
using Sitecore.Data;

namespace Sitecore.FakeDb.Construct.Tests
{
    /// <summary>
    /// Example of generated constructable Db template for most common Navigation template
    /// </summary>
    /// <seealso cref="ConstructableDbTemplate" />
    // ReSharper disable once PartialTypeWithSinglePart
    public partial class TestDbTemplate : ConstructableDbTemplate
    {
        protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
        {
            var template = new DbTemplate(TemplateName, TemplateId)
            {
                { new DbField(FieldNames.NavigationTitle, FieldIds.NavigationTitle), standardValues[FieldIds.NavigationTitle] },
                { new DbField(FieldNames.HideFromNavigation, FieldIds.HideFromNavigation), standardValues[FieldIds.HideFromNavigation] },
            };

            template.BaseIDs = new ID[]
            {
            };

            db.Add(template);
        }

        public static ID TemplateId = new ID("{F26CDC22-CF07-4688-B864-5825FA424C0E}");
        public const string TemplateName = "Navigation";

        public static class FieldNames
        {
            public const string HideFromNavigation = "Hide From Navigation";
            public const string NavigationTitle = "Navigation Title";
        }

        public static class FieldIds
        {
            public static ID HideFromNavigation = new ID("{4DB7E755-F283-43E1-BA89-084FC73B272A}");
            public static ID NavigationTitle = new ID("{4E805864-4A2B-4394-A2A4-99D1CF97ACA8}");
        }
    }

    /// <summary>
    /// Example of generated constructable Standard Values for most common Navigation template
    /// </summary>
    /// <seealso cref="Construct.ConstructableStandardValues{NavigationDbTemplate}" />
    public class TestStandardValues : ConstructableStandardValues<TestDbTemplate>
    {
        protected override IDictionary<ID, string> ConstructStandardValues()
        {
            return new Dictionary<ID, string>
            {
                { TestDbTemplate.FieldIds.HideFromNavigation, "" },
                { TestDbTemplate.FieldIds.NavigationTitle, "$name" }
            };
        }
    }

    // abstract classese - should not be read from assemply
    public abstract class AbstractDbTemplate : ConstructableDbTemplate
    {
    }

    public abstract class AbstractStandardValues : ConstructableStandardValues<AbstractDbTemplate>
    {
    }
}
