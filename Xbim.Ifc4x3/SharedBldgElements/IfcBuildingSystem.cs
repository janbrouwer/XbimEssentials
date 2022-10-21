// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.ProductExtension;
using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.SharedBldgElements;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.SharedBldgElements
{
	[ExpressType("IfcBuildingSystem", 1108)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBuildingSystem : IfcSystem, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcBuildingSystem>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBuildingSystem(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcBuildingSystemTypeEnum? _predefinedType;
		private IfcLabel? _longName;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 20)]
		public IfcBuildingSystemTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 21)]
		public IfcLabel? @LongName 
		{ 
			get 
			{
				if(_activated) return _longName;
				Activate();
				return _longName;
			} 
			set
			{
				SetValue( v =>  _longName = v, _longName, value,  "LongName", 7);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
                    _predefinedType = (IfcBuildingSystemTypeEnum) System.Enum.Parse(typeof (IfcBuildingSystemTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_longName = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBuildingSystem other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}