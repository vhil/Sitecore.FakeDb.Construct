using System;
using Sitecore.Data;

namespace Sitecore.FakeDb.Construct
{
    /// <summary>
    /// This class is used for templates which do not have dedicated standard value types. Provides empty standard values for all fields.
    /// </summary>
    /// <seealso cref="Sitecore.FakeDb.Construct.ConstructableStandardValues" />
    public class DefaultStandardValues : ConstructableStandardValues
    {
        public override Type AssignableDbTemplate { get { return typeof(ConstructableDbTemplate); } }

        public override string this[ID fieldId]
        {
            get { return string.Empty; }
        }
    }
}
