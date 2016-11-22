using System;
using Sitecore.Data;

namespace Sitecore.FakeDb.Construct
{
    public class DefaultStandardValues : ConstructableStandardValues
    {
        public override Type AssignableDbTemplate { get { return typeof(ConstructableDbTemplate); } }

        public override string this[ID fieldId]
        {
            get { return string.Empty; }
        }
    }
}
