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
namespace Xbim.Ifc4.PresentationDefinitionResource
{
	public partial class IfcTextLiteralWithExtent : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.PresentationDefinitionResource.IfcTextLiteralWithExtent");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcTextLiteralWithExtent clause) {
			var retVal = false;
			if (clause == Where.IfcTextLiteralWithExtent.WR31) {
				try {
					retVal = !(TYPEOF(Extent).Contains("IFC4.IFCPLANARBOX"));
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcTextLiteralWithExtent.WR31' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcTextLiteralWithExtent.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTextLiteralWithExtent.WR31", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcTextLiteralWithExtent
	{
		public static readonly IfcTextLiteralWithExtent WR31 = new IfcTextLiteralWithExtent();
		protected IfcTextLiteralWithExtent() {}
	}
}
