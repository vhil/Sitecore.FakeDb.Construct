using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Sitecore.FakeDb.Construct
{
	public static class DbConstructFactory
	{
	    public static IEnumerable<ConstructableDbTemplate> GetConstructableTemplates(Assembly assembly)
	    {
	        if (assembly == null)
	        {
                throw new ArgumentNullException(string.Format("'{0}' input parameter should not be null.", nameof(assembly)));
	        }

	        return assembly.GetTypes()
                .Where(x => typeof(ConstructableDbTemplate).IsAssignableFrom(x))
                .Where(x => !x.IsAbstract)
                .Select(type => (ConstructableDbTemplate)Activator.CreateInstance(type, null));
        }

        public static IEnumerable<ConstructableStandardValues> GetConstructableStandardValues(Assembly assembly)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException(string.Format("'{0}' input parameter should not be null.", nameof(assembly)));
            }

            return assembly.GetTypes()
                .Where(x => typeof(ConstructableStandardValues).IsAssignableFrom(x))
                .Where(x => !x.IsAbstract)
                .Select(type => (ConstructableStandardValues)Activator.CreateInstance(type, null));
        }

        public static Db ConstructDb(Assembly assembly)
		{
			return ConstructDb(
                GetConstructableTemplates(assembly), 
                GetConstructableStandardValues(assembly));
		}

        public static Db ConstructDb(IEnumerable<ConstructableDbTemplate> templates, IEnumerable<ConstructableStandardValues> standardValues)
        {
            if (templates == null)
            {
                throw new ArgumentNullException(string.Format("'{0}' input parameter should not be null.", nameof(templates)));
            }

            if (standardValues == null)
            {
                throw new ArgumentNullException(string.Format("'{0}' input parameter should not be null.", nameof(standardValues)));
            }

            var standardValuesDictionary = new Dictionary<Type, ConstructableStandardValues>();

            foreach (var standatdValue in standardValues)
            {
                if (!standardValuesDictionary.ContainsKey(standatdValue.AssignableDbTemplate))
                {
                    standardValuesDictionary.Add(standatdValue.AssignableDbTemplate, standatdValue);
                }
            }

            var db = new Db();

            foreach (var template in templates)
            {
                var templateType = template.GetType();
                var standardValuesInstance = standardValuesDictionary.ContainsKey(templateType)
                    ? standardValuesDictionary[templateType]
                    : null;

                template.ConstructDbTemplate(db, standardValuesInstance);
            }

            return db;
        }
    }
}