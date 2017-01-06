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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class IfcCurveStyle : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.PresentationAppearanceResource.IfcCurveStyle");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcCurveStyle clause) {
			var retVal = false;
			if (clause == Where.IfcCurveStyle.WR11) {
				try {
					retVal = (!(EXISTS(CurveWidth))) || (TYPEOF(CurveWidth).Contains("IFC2X3.IFCPOSITIVELENGTHMEASURE")) || ((TYPEOF(CurveWidth).Contains("IFC2X3.IFCDESCRIPTIVEMEASURE")) && (CurveWidth.AsIfcDescriptiveMeasure() == "by layer"));
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcCurveStyle.WR11' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcCurveStyle.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCurveStyle.WR11", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.Where
{
	public class IfcCurveStyle
	{
		public static readonly IfcCurveStyle WR11 = new IfcCurveStyle();
		protected IfcCurveStyle() {}
	}
}
