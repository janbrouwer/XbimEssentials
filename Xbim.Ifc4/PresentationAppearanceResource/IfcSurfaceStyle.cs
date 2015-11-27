// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.PresentationAppearanceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceStyle : IIfcPresentationStyle, IfcPresentationStyleSelect
	{
		IfcSurfaceSide @Side { get; }
		IEnumerable<IIfcSurfaceStyleElementSelect> @Styles { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcSurfaceStyle", 1067)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyle : IfcPresentationStyle, IInstantiableEntity, IIfcSurfaceStyle, IEqualityComparer<@IfcSurfaceStyle>, IEquatable<@IfcSurfaceStyle>
	{
		#region IIfcSurfaceStyle explicit implementation
		IfcSurfaceSide IIfcSurfaceStyle.Side { get { return @Side; } }	
		IEnumerable<IIfcSurfaceStyleElementSelect> IIfcSurfaceStyle.Styles { get { return @Styles; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyle(IModel model) : base(model) 		{ 
			Model = model; 
			_styles = new ItemSet<IfcSurfaceStyleElementSelect>( this, 5 );
		}

		#region Explicit attribute fields
		private IfcSurfaceSide _side;
		private ItemSet<IfcSurfaceStyleElementSelect> _styles;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 2)]
		public IfcSurfaceSide @Side 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _side;
				((IPersistEntity)this).Activate(false);
				return _side;
			} 
			set
			{
				SetValue( v =>  _side = v, _side, value,  "Side");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, 5, 3)]
		public ItemSet<IfcSurfaceStyleElementSelect> @Styles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _styles;
				((IPersistEntity)this).Activate(false);
				return _styles;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
                    _side = (IfcSurfaceSide) System.Enum.Parse(typeof (IfcSurfaceSide), value.EnumVal, true);
					return;
				case 2: 
					if (_styles == null) _styles = new ItemSet<IfcSurfaceStyleElementSelect>( this );
					_styles.InternalAdd((IfcSurfaceStyleElementSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*MaxOneShading:  )) <= 1;*/
		/*MaxOneLighting:  )) <= 1;*/
		/*MaxOneRefraction:  )) <= 1;*/
		/*MaxOneTextures:  )) <= 1;*/
		/*MaxOneExtDefined:  )) <= 1;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceStyle other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceStyle
            var root = (@IfcSurfaceStyle)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceStyle left, @IfcSurfaceStyle right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurfaceStyle left, @IfcSurfaceStyle right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSurfaceStyle x, @IfcSurfaceStyle y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSurfaceStyle obj)
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