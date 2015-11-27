// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ExternalReferenceResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDocumentReference
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDocumentReference : IIfcExternalReference, IfcDocumentSelect
	{
		IEnumerable<IIfcDocumentInformation> @ReferenceToDocument {  get; }
	
	}
}

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IfcDocumentReference", 450)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDocumentReference : IfcExternalReference, IInstantiableEntity, IIfcDocumentReference, IEqualityComparer<@IfcDocumentReference>, IEquatable<@IfcDocumentReference>
	{
		#region IIfcDocumentReference explicit implementation
		 
		IEnumerable<IIfcDocumentInformation> IIfcDocumentReference.ReferenceToDocument {  get { return @ReferenceToDocument; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDocumentReference(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region Inverse attributes
		[InverseProperty("DocumentReferences")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 4)]
		public IEnumerable<IfcDocumentInformation> @ReferenceToDocument 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDocumentInformation>(e => e.DocumentReferences != null &&  e.DocumentReferences.Contains(this), "DocumentReferences", this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : EXISTS(Name) XOR EXISTS(ReferenceToDocument[1]);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDocumentReference other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDocumentReference
            var root = (@IfcDocumentReference)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDocumentReference left, @IfcDocumentReference right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDocumentReference left, @IfcDocumentReference right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDocumentReference x, @IfcDocumentReference y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDocumentReference obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}