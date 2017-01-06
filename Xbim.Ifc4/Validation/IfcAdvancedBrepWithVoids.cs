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
namespace Xbim.Ifc4.GeometricModelResource
{
	public partial class IfcAdvancedBrepWithVoids : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.GeometricModelResource.IfcAdvancedBrepWithVoids");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcAdvancedBrepWithVoids clause) {
			var retVal = false;
			if (clause == Where.IfcAdvancedBrepWithVoids.VoidsHaveAdvancedFaces) {
				try {
					retVal = SIZEOF(Voids.Where(Vsh => SIZEOF(Vsh.CfsFaces.Where(Afs => (!(TYPEOF(Afs).Contains("IFC4.IFCADVANCEDFACE"))))) == 0)) == 0;
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcAdvancedBrepWithVoids.VoidsHaveAdvancedFaces' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			return base.ValidateClause((Where.IfcAdvancedBrep)clause);
		}

		public new IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(Where.IfcAdvancedBrepWithVoids.VoidsHaveAdvancedFaces))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcAdvancedBrepWithVoids.VoidsHaveAdvancedFaces", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcAdvancedBrepWithVoids : IfcAdvancedBrep
	{
		public static readonly IfcAdvancedBrepWithVoids VoidsHaveAdvancedFaces = new IfcAdvancedBrepWithVoids();
		protected IfcAdvancedBrepWithVoids() {}
	}
}
