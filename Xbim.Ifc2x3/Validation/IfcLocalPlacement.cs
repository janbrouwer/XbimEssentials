using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
using static Xbim.Ifc2x3.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	public partial class IfcLocalPlacement : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.GeometricConstraintResource.IfcLocalPlacement");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcLocalPlacement clause) {
			var retVal = false;
			if (clause == Where.IfcLocalPlacement.WR21) {
				try {
					retVal = IfcCorrectLocalPlacement(RelativePlacement, PlacementRelTo);
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcLocalPlacement.WR21' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcLocalPlacement.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcLocalPlacement.WR21", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.Where
{
	public class IfcLocalPlacement
	{
		public static readonly IfcLocalPlacement WR21 = new IfcLocalPlacement();
		protected IfcLocalPlacement() {}
	}
}