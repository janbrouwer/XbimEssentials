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
namespace Xbim.Ifc4.ElectricalDomain
{
	public partial class IfcAudioVisualApplianceType : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.ElectricalDomain.IfcAudioVisualApplianceType");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcAudioVisualApplianceType clause) {
			var retVal = false;
			if (clause == Where.IfcAudioVisualApplianceType.CorrectPredefinedType) {
				try {
					retVal = (PredefinedType != IfcAudioVisualApplianceTypeEnum.USERDEFINED) || ((PredefinedType == IfcAudioVisualApplianceTypeEnum.USERDEFINED) && EXISTS(this/* as IfcElementType*/.ElementType));
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcAudioVisualApplianceType.CorrectPredefinedType' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			return base.ValidateClause((Where.IfcTypeProduct)clause);
		}

		public new IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(Where.IfcAudioVisualApplianceType.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcAudioVisualApplianceType.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcAudioVisualApplianceType : IfcTypeProduct
	{
		public static readonly IfcAudioVisualApplianceType CorrectPredefinedType = new IfcAudioVisualApplianceType();
		protected IfcAudioVisualApplianceType() {}
	}
}
