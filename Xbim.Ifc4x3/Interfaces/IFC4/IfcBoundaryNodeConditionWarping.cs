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
namespace Xbim.Ifc4x3.StructuralLoadResource
{
	public partial class @IfcBoundaryNodeConditionWarping : IIfcBoundaryNodeConditionWarping
	{

		[CrossSchemaAttribute(typeof(IIfcBoundaryNodeConditionWarping), 8)]
		IIfcWarpingStiffnessSelect IIfcBoundaryNodeConditionWarping.WarpingStiffness 
		{ 
			get
			{
				if (WarpingStiffness == null) return null;
				if (WarpingStiffness is MeasureResource.IfcBoolean) 
					return new Ifc4.MeasureResource.IfcBoolean((MeasureResource.IfcBoolean)WarpingStiffness);
				if (WarpingStiffness is MeasureResource.IfcWarpingMomentMeasure) 
					return new Ifc4.MeasureResource.IfcWarpingMomentMeasure((MeasureResource.IfcWarpingMomentMeasure)WarpingStiffness);
				return null;
			} 
			set
			{
				if (value == null)
				{
					WarpingStiffness = null;
					return;
				}	
				if (value is Ifc4.MeasureResource.IfcBoolean) 
				{
					WarpingStiffness = new MeasureResource.IfcBoolean((Ifc4.MeasureResource.IfcBoolean)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcWarpingMomentMeasure) 
				{
					WarpingStiffness = new MeasureResource.IfcWarpingMomentMeasure((Ifc4.MeasureResource.IfcWarpingMomentMeasure)value);
					return;
				}
				
			}
		}
	//## Custom code
	//##
	}
}