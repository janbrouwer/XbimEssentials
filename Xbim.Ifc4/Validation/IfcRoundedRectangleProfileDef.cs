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
namespace Xbim.Ifc4.ProfileResource
{
	public partial class IfcRoundedRectangleProfileDef : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.ProfileResource.IfcRoundedRectangleProfileDef");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcRoundedRectangleProfileDef clause) {
			var retVal = false;
			if (clause == Where.IfcRoundedRectangleProfileDef.ValidRadius) {
				try {
					retVal = ((RoundingRadius <= (this/* as IfcRectangleProfileDef*/.XDim / 2)) && (RoundingRadius <= (this/* as IfcRectangleProfileDef*/.YDim / 2)));
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcRoundedRectangleProfileDef.ValidRadius' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcRoundedRectangleProfileDef.ValidRadius))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRoundedRectangleProfileDef.ValidRadius", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcRoundedRectangleProfileDef
	{
		public static readonly IfcRoundedRectangleProfileDef ValidRadius = new IfcRoundedRectangleProfileDef();
		protected IfcRoundedRectangleProfileDef() {}
	}
}
