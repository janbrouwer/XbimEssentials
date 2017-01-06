using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.ProductExtension
{
	public partial class IfcRelReferencedInSpatialStructure : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.ProductExtension.IfcRelReferencedInSpatialStructure");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcRelReferencedInSpatialStructure clause) {
			var retVal = false;
			if (clause == Where.IfcRelReferencedInSpatialStructure.WR31) {
				try {
					retVal = SIZEOF(RelatedElements.Where(temp => TYPEOF(temp).Contains("IFC4.IFCSPATIALSTRUCTUREELEMENT"))) == 0;
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcRelReferencedInSpatialStructure.WR31' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcRelReferencedInSpatialStructure.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelReferencedInSpatialStructure.WR31", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcRelReferencedInSpatialStructure
	{
		public static readonly IfcRelReferencedInSpatialStructure WR31 = new IfcRelReferencedInSpatialStructure();
		protected IfcRelReferencedInSpatialStructure() {}
	}
}
