using System;
using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool isNew { get; private set; }
        public bool IsValid => Validate();

        public abstract bool Validate();
    }
}