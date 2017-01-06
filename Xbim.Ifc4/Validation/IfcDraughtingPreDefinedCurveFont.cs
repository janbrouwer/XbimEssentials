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
namespace Xbim.Ifc4.PresentationAppearanceResource
{
	public partial class IfcDraughtingPreDefinedCurveFont : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.PresentationAppearanceResource.IfcDraughtingPreDefinedCurveFont");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcDraughtingPreDefinedCurveFont clause) {
			var retVal = false;
			if (clause == Where.IfcDraughtingPreDefinedCurveFont.PreDefinedCurveFontNames) {
				try {
					retVal = NewArray("continuous", "chain", "chain double dash", "dashed", "dotted", "by layer").Contains(this/* as IfcPredefinedItem*/.Name);
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcDraughtingPreDefinedCurveFont.PreDefinedCurveFontNames' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcDraughtingPreDefinedCurveFont.PreDefinedCurveFontNames))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDraughtingPreDefinedCurveFont.PreDefinedCurveFontNames", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcDraughtingPreDefinedCurveFont
	{
		public static readonly IfcDraughtingPreDefinedCurveFont PreDefinedCurveFontNames = new IfcDraughtingPreDefinedCurveFont();
		protected IfcDraughtingPreDefinedCurveFont() {}
	}
}
