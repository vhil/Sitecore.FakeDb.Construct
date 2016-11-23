using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Sitecore.FakeDb.Construct
{
    /// <summary>
    /// Entry point into Sitecore.FakeDb.Construct. Provides factory methods to construct Db instance from given assembly or from give lists of templates and standard values.
    /// </summary>
    public static class DbConstructFactory
	{
        /// <summary>
        /// Gets list of instances of all types derived from ConstructableDbTemplate class.
        /// </summary>
        /// <param name="assembly">The assembly with types.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
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

        /// <summary>
        /// Gets list of instances of all types derived from ConstructableStandardValues class.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
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

        /// <summary>
        /// Constructs all available types of ConstructableDbTemplate and ConstructableStandardValues in given assembly into new instance of Db type.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <returns></returns>
        public static Db ConstructDb(Assembly assembly)
		{
			return ConstructDb(
                GetConstructableTemplates(assembly), 
                GetConstructableStandardValues(assembly));
		}

        /// <summary>
        /// Constructs given types of ConstructableDbTemplate and ConstructableStandardValues into new instance of Db type.
        /// </summary>
        /// <param name="templates">List of template types</param>
        /// <param name="standardValues">List of standard value types</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// </exception>
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