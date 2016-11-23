using System;
using System.Collections.Generic;
using Sitecore.Data;

namespace Sitecore.FakeDb.Construct
{
    /// <summary>
    /// Base class for constructable standard value types.
    /// </summary>
    public abstract class ConstructableStandardValues
    {
        public abstract Type AssignableDbTemplate { get; }
        public abstract string this[ID fieldId] { get; }
    }

    /// <summary>
    /// Base generic class for constructable standard value types.
    /// </summary>
    /// <typeparam name="TDbTemplate">The type of the database template.</typeparam>
    public abstract class ConstructableStandardValues<TDbTemplate> : ConstructableStandardValues
        where TDbTemplate : ConstructableDbTemplate
    {
        private IDictionary<ID, string> standardValues;

        protected abstract IDictionary<ID, string> ConstructStandardValues();

        public override Type AssignableDbTemplate
        {
            get { return typeof(TDbTemplate); }
        }

        public override string this[ID fieldId]
        {
            get
            {
                if (this.standardValues == null)
                {
                    this.standardValues = this.ConstructStandardValues();
                }

                if (this.standardValues.ContainsKey(fieldId))
                {
                    return this.standardValues[fieldId];
                }

                return string.Empty;
            }
        }
    }
}
