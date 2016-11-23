namespace Sitecore.FakeDb.Construct
{
    /// <summary>
    /// Base class for constructable db template types.
    /// </summary>
    public abstract class ConstructableDbTemplate
    {
        public void ConstructDbTemplate(Db db, ConstructableStandardValues standardValues = null)
        {
            if (standardValues == null)
            {
                standardValues = new DefaultStandardValues();
            }

            this.ConstructTemplate(db, standardValues);
        }

        protected abstract void ConstructTemplate(Db db, ConstructableStandardValues standardValues);
    }
}
