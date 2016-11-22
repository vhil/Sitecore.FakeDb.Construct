using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Sitecore.FakeDb.Construct
{
	public static class DbConstructFactory
	{
		public static Db ConstructDb(Assembly assembly)
		{
			var templates = assembly.GetTypes()
				.Where(x => typeof(ConstructableDbTemplate).IsAssignableFrom(x))
				.Where(x => !x.IsAbstract)
				.Select(type => (ConstructableDbTemplate)Activator.CreateInstance(type, null));

            var standardValues = assembly.GetTypes()
				.Where(x => typeof(ConstructableStandardValues).IsAssignableFrom(x))
                .Where(x => !x.IsAbstract)
                .Select(type => (ConstructableStandardValues)Activator.CreateInstance(type, null));

			return ConstructDb(templates, standardValues);
		}

        public static Db ConstructDb(IEnumerable<ConstructableDbTemplate> constructables, IEnumerable<ConstructableStandardValues> standardValues)
        {
            var standardValuesDictionary = new Dictionary<Type, ConstructableStandardValues>();

            foreach (var standatdValue in standardValues)
            {
                if (!standardValuesDictionary.ContainsKey(standatdValue.AssignableDbTemplate))
                {
                    standardValuesDictionary.Add(standatdValue.AssignableDbTemplate, standatdValue);
                }
            }

            var db = new Db();

            foreach (var template in constructables)
            {
                template.ConstructDbTemplate(db, standardValuesDictionary[template.GetType()]);
            }

            return db;
        }
    }
}