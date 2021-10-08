using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   //Made this an abstract class so it can only be used as a base class.
   public abstract class EntityBase
    {

        public enum EntityStateOption
        {
            Active,
            Deleted
        }

        public EntityStateOption EntityState { get; set; }

        public bool HasChanges { get; set; }

        public bool IsNew { get; private set; }

        //This property uses polymorphism to call the correct method based on the entity type.
        public bool IsValid => Validate();

        // Override this method in each of the entity classes.
        // No method body and ends with ;
        public abstract bool Validate();
       



    }
}
