// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ExternalReferenceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcClassification
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcClassification : IIfcExternalInformation, IfcClassificationReferenceSelect, IfcClassificationSelect
	{
		IfcLabel? @Source { get; }
		IfcLabel? @Edition { get; }
		IfcDate? @EditionDate { get; }
		IfcLabel @Name { get; }
		IfcText? @Description { get; }
		IfcURIReference? @Location { get; }
		IEnumerable<IfcIdentifier> @ReferenceTokens { get; }
		IEnumerable<IIfcRelAssociatesClassification> @ClassificationForObjects {  get; }
		IEnumerable<IIfcClassificationReference> @HasReferences {  get; }
	
	}
}

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IfcClassification", 492)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassification : IfcExternalInformation, IInstantiableEntity, IIfcClassification, IEqualityComparer<@IfcClassification>, IEquatable<@IfcClassification>
	{
		#region IIfcClassification explicit implementation
		IfcLabel? IIfcClassification.Source { get { return @Source; } }	
		IfcLabel? IIfcClassification.Edition { get { return @Edition; } }	
		IfcDate? IIfcClassification.EditionDate { get { return @EditionDate; } }	
		IfcLabel IIfcClassification.Name { get { return @Name; } }	
		IfcText? IIfcClassification.Description { get { return @Description; } }	
		IfcURIReference? IIfcClassification.Location { get { return @Location; } }	
		IEnumerable<IfcIdentifier> IIfcClassification.ReferenceTokens { get { return @ReferenceTokens; } }	
		 
		IEnumerable<IIfcRelAssociatesClassification> IIfcClassification.ClassificationForObjects {  get { return @ClassificationForObjects; } }
		IEnumerable<IIfcClassificationReference> IIfcClassification.HasReferences {  get { return @HasReferences; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcClassification(IModel model) : base(model) 		{ 
			Model = model; 
			_referenceTokens = new OptionalItemSet<IfcIdentifier>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcLabel? _source;
		private IfcLabel? _edition;
		private IfcDate? _editionDate;
		private IfcLabel _name;
		private IfcText? _description;
		private IfcURIReference? _location;
		private OptionalItemSet<IfcIdentifier> _referenceTokens;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcLabel? @Source 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _source;
				((IPersistEntity)this).Activate(false);
				return _source;
			} 
			set
			{
				SetValue( v =>  _source = v, _source, value,  "Source");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcLabel? @Edition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _edition;
				((IPersistEntity)this).Activate(false);
				return _edition;
			} 
			set
			{
				SetValue( v =>  _edition = v, _edition, value,  "Edition");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcDate? @EditionDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _editionDate;
				((IPersistEntity)this).Activate(false);
				return _editionDate;
			} 
			set
			{
				SetValue( v =>  _editionDate = v, _editionDate, value,  "EditionDate");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcURIReference? @Location 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _location;
				((IPersistEntity)this).Activate(false);
				return _location;
			} 
			set
			{
				SetValue( v =>  _location = v, _location, value,  "Location");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 7)]
		public OptionalItemSet<IfcIdentifier> @ReferenceTokens 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _referenceTokens;
				((IPersistEntity)this).Activate(false);
				return _referenceTokens;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingClassification")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 8)]
		public IEnumerable<IfcRelAssociatesClassification> @ClassificationForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesClassification>(e => (e.RelatingClassification as IfcClassification) == this, "RelatingClassification", this);
			} 
		}
		[InverseProperty("ReferencedSource")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 9)]
		public IEnumerable<IfcClassificationReference> @HasReferences 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationReference>(e => (e.ReferencedSource as IfcClassification) == this, "ReferencedSource", this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_source = value.StringVal;
					return;
				case 1: 
					_edition = value.StringVal;
					return;
				case 2: 
					_editionDate = value.StringVal;
					return;
				case 3: 
					_name = value.StringVal;
					return;
				case 4: 
					_description = value.StringVal;
					return;
				case 5: 
					_location = value.StringVal;
					return;
				case 6: 
					if (_referenceTokens == null) _referenceTokens = new OptionalItemSet<IfcIdentifier>( this );
					_referenceTokens.InternalAdd(value.StringVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcClassification other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcClassification
            var root = (@IfcClassification)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcClassification left, @IfcClassification right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcClassification left, @IfcClassification right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcClassification x, @IfcClassification y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcClassification obj)
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