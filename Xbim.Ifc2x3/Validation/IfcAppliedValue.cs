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
namespace Xbim.Ifc2x3.CostResource
{
	public partial class IfcAppliedValue : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.CostResource.IfcAppliedValue");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcAppliedValue clause) {
			var retVal = false;
			if (clause == Where.IfcAppliedValue.WR1) {
				try {
					retVal = EXISTS(AppliedValue) || EXISTS(ValueOfComponents);
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcAppliedValue.WR1' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcAppliedValue.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcAppliedValue.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.Where
{
	public class IfcAppliedValue
	{
		public static readonly IfcAppliedValue WR1 = new IfcAppliedValue();
		protected IfcAppliedValue() {}
	}
}
