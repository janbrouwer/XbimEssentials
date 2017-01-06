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
namespace Xbim.Ifc4.ProcessExtension
{
	public partial class IfcProcedure : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.ProcessExtension.IfcProcedure");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcProcedure clause) {
			var retVal = false;
			if (clause == Where.IfcProcedure.HasName) {
				try {
					retVal = EXISTS(this/* as IfcRoot*/.Name);
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcProcedure.HasName' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			if (clause == Where.IfcProcedure.CorrectPredefinedType) {
				try {
					retVal = !(EXISTS(PredefinedType)) || (PredefinedType != IfcProcedureTypeEnum.USERDEFINED) || ((PredefinedType == IfcProcedureTypeEnum.USERDEFINED) && EXISTS(this/* as IfcObject*/.ObjectType));
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcProcedure.CorrectPredefinedType' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			return base.ValidateClause((Where.IfcObject)clause);
		}

		public new IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(Where.IfcProcedure.HasName))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcProcedure.HasName", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcProcedure.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcProcedure.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcProcedure : IfcObject
	{
		public static readonly IfcProcedure HasName = new IfcProcedure();
		public static readonly IfcProcedure CorrectPredefinedType = new IfcProcedure();
		protected IfcProcedure() {}
	}
}
