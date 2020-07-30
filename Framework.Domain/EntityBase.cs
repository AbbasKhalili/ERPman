using System;

namespace Framework.Domain
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            DateSave = DateTime.Now;
        }

        public long Id { get; protected set; }
        public string UserSave { get; set; }
        public DateTime DateSave { get; set; }
    }
}
