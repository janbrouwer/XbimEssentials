// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.SharedFacilitiesElements
{
	public partial class @IfcFurniture : IIfcFurniture
	{

		[CrossSchemaAttribute(typeof(IIfcFurniture), 9)]
		Ifc4.Interfaces.IfcFurnitureTypeEnum? IIfcFurniture.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcFurnitureTypeEnum.CHAIR:
						return Ifc4.Interfaces.IfcFurnitureTypeEnum.CHAIR;
					case IfcFurnitureTypeEnum.TABLE:
						return Ifc4.Interfaces.IfcFurnitureTypeEnum.TABLE;
					case IfcFurnitureTypeEnum.DESK:
						return Ifc4.Interfaces.IfcFurnitureTypeEnum.DESK;
					case IfcFurnitureTypeEnum.BED:
						return Ifc4.Interfaces.IfcFurnitureTypeEnum.BED;
					case IfcFurnitureTypeEnum.FILECABINET:
						return Ifc4.Interfaces.IfcFurnitureTypeEnum.FILECABINET;
					case IfcFurnitureTypeEnum.SHELF:
						return Ifc4.Interfaces.IfcFurnitureTypeEnum.SHELF;
					case IfcFurnitureTypeEnum.SOFA:
						return Ifc4.Interfaces.IfcFurnitureTypeEnum.SOFA;
					case IfcFurnitureTypeEnum.TECHNICALCABINET:
						//## Handle translation of TECHNICALCABINET member from IfcFurnitureTypeEnum in property PredefinedType
						//TODO: Handle translation of TECHNICALCABINET member from IfcFurnitureTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcFurnitureTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcFurnitureTypeEnum.USERDEFINED;
					case IfcFurnitureTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcFurnitureTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcFurnitureTypeEnum.CHAIR:
						PredefinedType = IfcFurnitureTypeEnum.CHAIR;
						return;
					case Ifc4.Interfaces.IfcFurnitureTypeEnum.TABLE:
						PredefinedType = IfcFurnitureTypeEnum.TABLE;
						return;
					case Ifc4.Interfaces.IfcFurnitureTypeEnum.DESK:
						PredefinedType = IfcFurnitureTypeEnum.DESK;
						return;
					case Ifc4.Interfaces.IfcFurnitureTypeEnum.BED:
						PredefinedType = IfcFurnitureTypeEnum.BED;
						return;
					case Ifc4.Interfaces.IfcFurnitureTypeEnum.FILECABINET:
						PredefinedType = IfcFurnitureTypeEnum.FILECABINET;
						return;
					case Ifc4.Interfaces.IfcFurnitureTypeEnum.SHELF:
						PredefinedType = IfcFurnitureTypeEnum.SHELF;
						return;
					case Ifc4.Interfaces.IfcFurnitureTypeEnum.SOFA:
						PredefinedType = IfcFurnitureTypeEnum.SOFA;
						return;
					case Ifc4.Interfaces.IfcFurnitureTypeEnum.USERDEFINED:
						PredefinedType = IfcFurnitureTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcFurnitureTypeEnum.NOTDEFINED:
						PredefinedType = IfcFurnitureTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}