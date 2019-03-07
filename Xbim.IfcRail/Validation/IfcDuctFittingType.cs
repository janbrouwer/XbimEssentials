using System;
using Microsoft.Extensions.Logging;
using Xbim.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;

// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.IfcRail.HvacDomain
{
	public partial class IfcDuctFittingType : IExpressValidatable
	{
		public enum IfcDuctFittingTypeClause
		{
			CorrectPredefinedType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcDuctFittingTypeClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcDuctFittingTypeClause.CorrectPredefinedType:
						retVal = (PredefinedType != IfcDuctFittingTypeEnum.USERDEFINED) || ((PredefinedType == IfcDuctFittingTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcElementType*/.ElementType));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Xbim.IfcRail.HvacDomain.IfcDuctFittingType>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcDuctFittingType.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcDuctFittingTypeClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDuctFittingType.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}