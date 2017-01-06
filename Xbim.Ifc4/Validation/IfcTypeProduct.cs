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
namespace Xbim.Ifc4.Kernel
{
	public partial class IfcTypeProduct : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.Kernel.IfcTypeProduct");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcTypeProduct clause) {
			var retVal = false;
			if (clause == Where.IfcTypeProduct.ApplicableOccurrence) {
				try {
					retVal = !(EXISTS(this/* as IfcTypeObject*/.Types.ToArray()[0])) || (SIZEOF(this/* as IfcTypeObject*/.Types.ToArray()[0].RelatedObjects.Where(temp => !(TYPEOF(temp).Contains("IFC4.IFCPRODUCT")))) == 0);
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcTypeProduct.ApplicableOccurrence' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			return base.ValidateClause((Where.IfcTypeObject)clause);
		}

		public new IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(Where.IfcTypeProduct.ApplicableOccurrence))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTypeProduct.ApplicableOccurrence", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcTypeProduct : IfcTypeObject
	{
		public static readonly IfcTypeProduct ApplicableOccurrence = new IfcTypeProduct();
		protected IfcTypeProduct() {}
	}
}
