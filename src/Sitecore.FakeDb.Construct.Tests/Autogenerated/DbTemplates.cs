using global::Sitecore.Data;
using global::Sitecore.FakeDb;
using global::Sitecore.FakeDb.Construct;
using global::System.Collections.Generic;

#region Metadata Standard Values

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated Constructable Standard Values type for Metadata template (/sitecore/templates/SUG/Feature/Metadata/Data Templates/Metadata)
	/// </summary>
	/// <seealso cref="Construct.ConstructableStandardValues{MetadataDbTemplate}" />
	public class MetadataDbTemplateStandardValues : ConstructableStandardValues<MetadataDbTemplate>
	{
		protected override IDictionary<ID, string> ConstructStandardValues()
		{
			return new Dictionary<ID, string>
			{
				{ MetadataDbTemplate.FieldIds.MetaDescription, "" },
				{ MetadataDbTemplate.FieldIds.MetaKeywords, "" },
				{ MetadataDbTemplate.FieldIds.MetaTitle, "" },
			};
		}
	}
}

#endregion
#region Website Metadata

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated FakeDb constructable type for Website Metadata template (Template ID: {1C41706F-C660-418E-A39B-28D2599A08CF})
	/// </summary>
	/// <seealso cref="Sitecore.FakeDb.Construct.ConstructableDbTemplate" />
	public partial class WebsiteMetadataDbTemplate : ConstructableDbTemplate
	{
		protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
		{

			var template = new DbTemplate(TemplateName, TemplateId)
            {
                { new DbField(FieldNames.MetaTitle, FieldIds.MetaTitle), standardValues[FieldIds.MetaTitle] },
	
            };

            template.BaseIDs = new ID[]
            {
            };

            db.Add(template);
		}

		public static ID TemplateId = new ID("{1C41706F-C660-418E-A39B-28D2599A08CF}");
		public const string TemplateName = "Website Metadata";

		public static class FieldNames
		{
			public const string MetaTitle = "Meta Title";
		}

		public static class FieldIds
		{
			public static ID MetaTitle = new ID("{56AD3D90-A189-4864-ADB5-851FCDECB645}");
		}
	}
}

#endregion
#region Site Root

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated FakeDb constructable type for Site Root template (Template ID: {204DDF12-D112-46B7-93BF-F0AEA42F6ACD})
	/// </summary>
	/// <seealso cref="Sitecore.FakeDb.Construct.ConstructableDbTemplate" />
	public partial class SiteRootDbTemplate : ConstructableDbTemplate
	{
		protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
		{

			var template = new DbTemplate(TemplateName, TemplateId)
            {
	
            };

            template.BaseIDs = new ID[]
            {
				ID.Parse("{4753C2DB-B490-4C2C-AD11-944EC7E4A2D9}"), // Navigation Root
				ID.Parse("{DC23040E-2384-43D9-B698-3073FCAAFF1E}"), // Site Logo
				ID.Parse("{1C41706F-C660-418E-A39B-28D2599A08CF}"), // Website Metadata
            };

            db.Add(template);
		}

		public static ID TemplateId = new ID("{204DDF12-D112-46B7-93BF-F0AEA42F6ACD}");
		public const string TemplateName = "Site Root";

		public static class FieldNames
		{
			public const string SiteLogo = "Site Logo";
			public const string MetaTitle = "Meta Title";
		}

		public static class FieldIds
		{
			public static ID SiteLogo = new ID("{F8750A5A-DBF2-479A-B9C7-6CCE9F4A2F7B}");
			public static ID MetaTitle = new ID("{56AD3D90-A189-4864-ADB5-851FCDECB645}");
		}
	}
}

#endregion
#region Metadata

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated FakeDb constructable type for Metadata template (Template ID: {312ED441-85C0-4ED2-9798-83153EDB248B})
	/// </summary>
	/// <seealso cref="Sitecore.FakeDb.Construct.ConstructableDbTemplate" />
	public partial class MetadataDbTemplate : ConstructableDbTemplate
	{
		protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
		{

			var template = new DbTemplate(TemplateName, TemplateId)
            {
                { new DbField(FieldNames.MetaDescription, FieldIds.MetaDescription), standardValues[FieldIds.MetaDescription] },
                { new DbField(FieldNames.MetaKeywords, FieldIds.MetaKeywords), standardValues[FieldIds.MetaKeywords] },
                { new DbField(FieldNames.MetaTitle, FieldIds.MetaTitle), standardValues[FieldIds.MetaTitle] },
	
            };

            template.BaseIDs = new ID[]
            {
            };

            db.Add(template);
		}

		public static ID TemplateId = new ID("{312ED441-85C0-4ED2-9798-83153EDB248B}");
		public const string TemplateName = "Metadata";

		public static class FieldNames
		{
			public const string MetaDescription = "Meta Description";
			public const string MetaKeywords = "Meta Keywords";
			public const string MetaTitle = "Meta Title";
		}

		public static class FieldIds
		{
			public static ID MetaDescription = new ID("{63FDF18B-F2BE-4484-9394-3D1BBD340554}");
			public static ID MetaKeywords = new ID("{F35F5DA4-6A33-4169-98CC-F64D92E3D793}");
			public static ID MetaTitle = new ID("{2F806BF2-D70E-46AB-AE07-DE758CB38919}");
		}
	}
}

#endregion
#region Page Title

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated FakeDb constructable type for Page Title template (Template ID: {3F6DDFA2-C79B-4C4A-86D4-696E76303C92})
	/// </summary>
	/// <seealso cref="Sitecore.FakeDb.Construct.ConstructableDbTemplate" />
	public partial class PageTitleDbTemplate : ConstructableDbTemplate
	{
		protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
		{

			var template = new DbTemplate(TemplateName, TemplateId)
            {
                { new DbField(FieldNames.PageTitle, FieldIds.PageTitle), standardValues[FieldIds.PageTitle] },
	
            };

            template.BaseIDs = new ID[]
            {
            };

            db.Add(template);
		}

		public static ID TemplateId = new ID("{3F6DDFA2-C79B-4C4A-86D4-696E76303C92}");
		public const string TemplateName = "Page Title";

		public static class FieldNames
		{
			public const string PageTitle = "Page Title";
		}

		public static class FieldIds
		{
			public static ID PageTitle = new ID("{1DA953BA-45A9-4534-8D35-A1F21589EDDF}");
		}
	}
}

#endregion
#region Navigation Root Standard Values

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated Constructable Standard Values type for Navigation Root template (/sitecore/templates/SUG/Feature/Navigation/Data Templates/Navigation Root)
	/// </summary>
	/// <seealso cref="Construct.ConstructableStandardValues{NavigationRootDbTemplate}" />
	public class NavigationRootDbTemplateStandardValues : ConstructableStandardValues<NavigationRootDbTemplate>
	{
		protected override IDictionary<ID, string> ConstructStandardValues()
		{
			return new Dictionary<ID, string>
			{
			};
		}
	}
}

#endregion
#region Navigation Root

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated FakeDb constructable type for Navigation Root template (Template ID: {4753C2DB-B490-4C2C-AD11-944EC7E4A2D9})
	/// </summary>
	/// <seealso cref="Sitecore.FakeDb.Construct.ConstructableDbTemplate" />
	public partial class NavigationRootDbTemplate : ConstructableDbTemplate
	{
		protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
		{

			var template = new DbTemplate(TemplateName, TemplateId)
            {
	
            };

            template.BaseIDs = new ID[]
            {
            };

            db.Add(template);
		}

		public static ID TemplateId = new ID("{4753C2DB-B490-4C2C-AD11-944EC7E4A2D9}");
		public const string TemplateName = "Navigation Root";

		public static class FieldNames
		{
		}

		public static class FieldIds
		{
		}
	}
}

#endregion
#region Page Body

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated FakeDb constructable type for Page Body template (Template ID: {478F623F-E2CE-4EA8-B8E7-081E98A0AA22})
	/// </summary>
	/// <seealso cref="Sitecore.FakeDb.Construct.ConstructableDbTemplate" />
	public partial class PageBodyDbTemplate : ConstructableDbTemplate
	{
		protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
		{

			var template = new DbTemplate(TemplateName, TemplateId)
            {
                { new DbField(FieldNames.PageBody, FieldIds.PageBody), standardValues[FieldIds.PageBody] },
	
            };

            template.BaseIDs = new ID[]
            {
            };

            db.Add(template);
		}

		public static ID TemplateId = new ID("{478F623F-E2CE-4EA8-B8E7-081E98A0AA22}");
		public const string TemplateName = "Page Body";

		public static class FieldNames
		{
			public const string PageBody = "Page Body";
		}

		public static class FieldIds
		{
			public static ID PageBody = new ID("{6F41F93F-2F57-44A4-B983-E942CA49FB3C}");
		}
	}
}

#endregion
#region Page Image Standard Values

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated Constructable Standard Values type for Page Image template (/sitecore/templates/SUG/Feature/Page Content/Content Types/Page Image)
	/// </summary>
	/// <seealso cref="Construct.ConstructableStandardValues{PageImageDbTemplate}" />
	public class PageImageDbTemplateStandardValues : ConstructableStandardValues<PageImageDbTemplate>
	{
		protected override IDictionary<ID, string> ConstructStandardValues()
		{
			return new Dictionary<ID, string>
			{
				{ PageImageDbTemplate.FieldIds.PageImage, "" },
			};
		}
	}
}

#endregion
#region Page Title Standard Values

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated Constructable Standard Values type for Page Title template (/sitecore/templates/SUG/Feature/Page Content/Content Types/Page Title)
	/// </summary>
	/// <seealso cref="Construct.ConstructableStandardValues{PageTitleDbTemplate}" />
	public class PageTitleDbTemplateStandardValues : ConstructableStandardValues<PageTitleDbTemplate>
	{
		protected override IDictionary<ID, string> ConstructStandardValues()
		{
			return new Dictionary<ID, string>
			{
				{ PageTitleDbTemplate.FieldIds.PageTitle, "" },
			};
		}
	}
}

#endregion
#region Page Standard Values

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated Constructable Standard Values type for Page template (/sitecore/templates/SUG/Project/Page Types/Page)
	/// </summary>
	/// <seealso cref="Construct.ConstructableStandardValues{PageDbTemplate}" />
	public class PageDbTemplateStandardValues : ConstructableStandardValues<PageDbTemplate>
	{
		protected override IDictionary<ID, string> ConstructStandardValues()
		{
			return new Dictionary<ID, string>
			{
				{ PageDbTemplate.FieldIds.HideFromNavigation, "" },
				{ PageDbTemplate.FieldIds.NavigationTitle, "" },
				{ PageDbTemplate.FieldIds.MetaDescription, "" },
				{ PageDbTemplate.FieldIds.MetaKeywords, "" },
				{ PageDbTemplate.FieldIds.MetaTitle, "" },
			};
		}
	}
}

#endregion
#region Page

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated FakeDb constructable type for Page template (Template ID: {B8C23FBD-9A9F-4570-AB5F-38249B1E4CFF})
	/// </summary>
	/// <seealso cref="Sitecore.FakeDb.Construct.ConstructableDbTemplate" />
	public partial class PageDbTemplate : ConstructableDbTemplate
	{
		protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
		{

			var template = new DbTemplate(TemplateName, TemplateId)
            {
	
            };

            template.BaseIDs = new ID[]
            {
				ID.Parse("{F16CDC22-CF07-4688-B864-5825FA424C0E}"), // Navigation
				ID.Parse("{312ED441-85C0-4ED2-9798-83153EDB248B}"), // Metadata
            };

            db.Add(template);
		}

		public static ID TemplateId = new ID("{B8C23FBD-9A9F-4570-AB5F-38249B1E4CFF}");
		public const string TemplateName = "Page";

		public static class FieldNames
		{
			public const string HideFromNavigation = "Hide From Navigation";
			public const string NavigationTitle = "Navigation Title";
			public const string MetaDescription = "Meta Description";
			public const string MetaKeywords = "Meta Keywords";
			public const string MetaTitle = "Meta Title";
		}

		public static class FieldIds
		{
			public static ID HideFromNavigation = new ID("{3DB7E755-F283-43E1-BA89-084FC73B272A}");
			public static ID NavigationTitle = new ID("{3E805864-4A2B-4394-A2A4-99D1CF97ACA8}");
			public static ID MetaDescription = new ID("{63FDF18B-F2BE-4484-9394-3D1BBD340554}");
			public static ID MetaKeywords = new ID("{F35F5DA4-6A33-4169-98CC-F64D92E3D793}");
			public static ID MetaTitle = new ID("{2F806BF2-D70E-46AB-AE07-DE758CB38919}");
		}
	}
}

#endregion
#region Page Image

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated FakeDb constructable type for Page Image template (Template ID: {B986636B-C1A3-438A-A478-B26FFD3A8217})
	/// </summary>
	/// <seealso cref="Sitecore.FakeDb.Construct.ConstructableDbTemplate" />
	public partial class PageImageDbTemplate : ConstructableDbTemplate
	{
		protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
		{

			var template = new DbTemplate(TemplateName, TemplateId)
            {
                { new DbField(FieldNames.PageImage, FieldIds.PageImage), standardValues[FieldIds.PageImage] },
	
            };

            template.BaseIDs = new ID[]
            {
            };

            db.Add(template);
		}

		public static ID TemplateId = new ID("{B986636B-C1A3-438A-A478-B26FFD3A8217}");
		public const string TemplateName = "Page Image";

		public static class FieldNames
		{
			public const string PageImage = "Page Image";
		}

		public static class FieldIds
		{
			public static ID PageImage = new ID("{56C6C167-A8D8-4D32-8462-A5B5E49490CA}");
		}
	}
}

#endregion
#region Site Root Standard Values

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated Constructable Standard Values type for Site Root template (/sitecore/templates/SUG/Project/Content Types/Site Root)
	/// </summary>
	/// <seealso cref="Construct.ConstructableStandardValues{SiteRootDbTemplate}" />
	public class SiteRootDbTemplateStandardValues : ConstructableStandardValues<SiteRootDbTemplate>
	{
		protected override IDictionary<ID, string> ConstructStandardValues()
		{
			return new Dictionary<ID, string>
			{
				{ SiteRootDbTemplate.FieldIds.SiteLogo, "" },
				{ SiteRootDbTemplate.FieldIds.MetaTitle, "" },
			};
		}
	}
}

#endregion
#region Navigation Standard Values

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated Constructable Standard Values type for Navigation template (/sitecore/templates/SUG/Feature/Navigation/Data Templates/Navigation)
	/// </summary>
	/// <seealso cref="Construct.ConstructableStandardValues{NavigationDbTemplate}" />
	public class NavigationDbTemplateStandardValues : ConstructableStandardValues<NavigationDbTemplate>
	{
		protected override IDictionary<ID, string> ConstructStandardValues()
		{
			return new Dictionary<ID, string>
			{
				{ NavigationDbTemplate.FieldIds.HideFromNavigation, "" },
				{ NavigationDbTemplate.FieldIds.NavigationTitle, "$name" },
			};
		}
	}
}

#endregion
#region Site Logo

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated FakeDb constructable type for Site Logo template (Template ID: {DC23040E-2384-43D9-B698-3073FCAAFF1E})
	/// </summary>
	/// <seealso cref="Sitecore.FakeDb.Construct.ConstructableDbTemplate" />
	public partial class SiteLogoDbTemplate : ConstructableDbTemplate
	{
		protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
		{

			var template = new DbTemplate(TemplateName, TemplateId)
            {
                { new DbField(FieldNames.SiteLogo, FieldIds.SiteLogo), standardValues[FieldIds.SiteLogo] },
	
            };

            template.BaseIDs = new ID[]
            {
            };

            db.Add(template);
		}

		public static ID TemplateId = new ID("{DC23040E-2384-43D9-B698-3073FCAAFF1E}");
		public const string TemplateName = "Site Logo";

		public static class FieldNames
		{
			public const string SiteLogo = "Site Logo";
		}

		public static class FieldIds
		{
			public static ID SiteLogo = new ID("{F8750A5A-DBF2-479A-B9C7-6CCE9F4A2F7B}");
		}
	}
}

#endregion
#region Website Metadata Standard Values

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated Constructable Standard Values type for Website Metadata template (/sitecore/templates/SUG/Feature/Metadata/Data Templates/Website Metadata)
	/// </summary>
	/// <seealso cref="Construct.ConstructableStandardValues{WebsiteMetadataDbTemplate}" />
	public class WebsiteMetadataDbTemplateStandardValues : ConstructableStandardValues<WebsiteMetadataDbTemplate>
	{
		protected override IDictionary<ID, string> ConstructStandardValues()
		{
			return new Dictionary<ID, string>
			{
				{ WebsiteMetadataDbTemplate.FieldIds.MetaTitle, "" },
			};
		}
	}
}

#endregion
#region Site Logo Standard Values

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated Constructable Standard Values type for Site Logo template (/sitecore/templates/SUG/Feature/Sites/Content Types/Site Logo)
	/// </summary>
	/// <seealso cref="Construct.ConstructableStandardValues{SiteLogoDbTemplate}" />
	public class SiteLogoDbTemplateStandardValues : ConstructableStandardValues<SiteLogoDbTemplate>
	{
		protected override IDictionary<ID, string> ConstructStandardValues()
		{
			return new Dictionary<ID, string>
			{
				{ SiteLogoDbTemplate.FieldIds.SiteLogo, "" },
			};
		}
	}
}

#endregion
#region Navigation

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated FakeDb constructable type for Navigation template (Template ID: {F16CDC22-CF07-4688-B864-5825FA424C0E})
	/// </summary>
	/// <seealso cref="Sitecore.FakeDb.Construct.ConstructableDbTemplate" />
	public partial class NavigationDbTemplate : ConstructableDbTemplate
	{
		protected override void ConstructTemplate(Db db, ConstructableStandardValues standardValues)
		{

			var template = new DbTemplate(TemplateName, TemplateId)
            {
                { new DbField(FieldNames.HideFromNavigation, FieldIds.HideFromNavigation), standardValues[FieldIds.HideFromNavigation] },
                { new DbField(FieldNames.NavigationTitle, FieldIds.NavigationTitle), standardValues[FieldIds.NavigationTitle] },
	
            };

            template.BaseIDs = new ID[]
            {
            };

            db.Add(template);
		}

		public static ID TemplateId = new ID("{F16CDC22-CF07-4688-B864-5825FA424C0E}");
		public const string TemplateName = "Navigation";

		public static class FieldNames
		{
			public const string HideFromNavigation = "Hide From Navigation";
			public const string NavigationTitle = "Navigation Title";
		}

		public static class FieldIds
		{
			public static ID HideFromNavigation = new ID("{3DB7E755-F283-43E1-BA89-084FC73B272A}");
			public static ID NavigationTitle = new ID("{3E805864-4A2B-4394-A2A4-99D1CF97ACA8}");
		}
	}
}

#endregion
#region Page Body Standard Values

namespace Sitecore.FakeDb.Construct.Tests.DbTemplates
{
	/// <summary>
	/// Generated Constructable Standard Values type for Page Body template (/sitecore/templates/SUG/Feature/Page Content/Content Types/Page Body)
	/// </summary>
	/// <seealso cref="Construct.ConstructableStandardValues{PageBodyDbTemplate}" />
	public class PageBodyDbTemplateStandardValues : ConstructableStandardValues<PageBodyDbTemplate>
	{
		protected override IDictionary<ID, string> ConstructStandardValues()
		{
			return new Dictionary<ID, string>
			{
				{ PageBodyDbTemplate.FieldIds.PageBody, "" },
			};
		}
	}
}

#endregion
