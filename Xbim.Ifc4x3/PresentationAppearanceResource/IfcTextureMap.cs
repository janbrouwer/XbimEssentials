// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.TopologyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.PresentationAppearanceResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.PresentationAppearanceResource
{
	[ExpressType("IfcTextureMap", 734)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureMap : IfcTextureCoordinate, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcTextureMap>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureMap(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_vertices = new ItemSet<IfcTextureVertex>( this, 0,  2);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcTextureVertex> _vertices;
		private IfcFace _mappedTo;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 3 }, new int [] { -1 }, 2)]
		public IItemSet<IfcTextureVertex> @Vertices 
		{ 
			get 
			{
				if(_activated) return _vertices;
				Activate();
				return _vertices;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcFace @MappedTo 
		{ 
			get 
			{
				if(_activated) return _mappedTo;
				Activate();
				return _mappedTo;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _mappedTo = v, _mappedTo, value,  "MappedTo", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_vertices.InternalAdd((IfcTextureVertex)value.EntityVal);
					return;
				case 2: 
					_mappedTo = (IfcFace)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextureMap other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Maps)
					yield return entity;
				foreach(var entity in @Vertices)
					yield return entity;
				if (@MappedTo != null)
					yield return @MappedTo;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Maps)
					yield return entity;
				if (@MappedTo != null)
					yield return @MappedTo;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}