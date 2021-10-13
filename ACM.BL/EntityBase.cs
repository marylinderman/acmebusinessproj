using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{

    /// <summary>
    /// Represents an abstract base class for all entity classes, such as <see cref="Customer"/>, <see cref="Order"/>, and others.
    /// </summary>
    

    //Made this an abstract class so it can only be used as a base class.
    public abstract class EntityBase
    {
        /// <summary>
        /// Specifies whether object is available in the application.
        /// </summary>
        public enum EntityStateOption
        {
            /// <summary>
            /// Indicates that an entity object is available in the application.
            /// </summary>
            Active,
            /// <summary>
            /// Indicates that an entity object that was removed from the application.
            /// </summary>
            Deleted
        }
        /// <summary>
        ///  Gets or sets the current state of the entity object as available or deleted from the application.
        /// </summary>
        public EntityStateOption EntityState { get; set; }
        /// <summary>
        ///  Gets or sets a Boolean value indicating whether the object has been modified.
        /// </summary>
        public bool HasChanges { get; set; }
        /// <summary>
        ///  Gets or sets a Boolean value indicating whether the object was recently created. 
        /// </summary>
        public bool IsNew { get; private set; }
        /// <summary>
        /// Gets or sets a Boolean value indicating whether object has valid properties on it. 
        /// </summary>
        //This property uses polymorphism to call the correct method based on the entity type.
        public bool IsValid => Validate();
        /// <summary>
        ///  Verifies whether the entity object has properties set to valid values.
        /// </summary>
        /// <returns>A Boolean value indicating whether the object is valid</returns>
        // Override this method in each of the entity classes.
        // No method body and ends with ;
        public abstract bool Validate();
       



    }
}
