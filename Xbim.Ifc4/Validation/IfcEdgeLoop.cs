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
namespace Xbim.Ifc4.TopologyResource
{
	public partial class IfcEdgeLoop : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.TopologyResource.IfcEdgeLoop");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcEdgeLoop clause) {
			var retVal = false;
			if (clause == Where.IfcEdgeLoop.IsClosed) {
				try {
					retVal = Object.ReferenceEquals((EdgeList.ToArray()[0].EdgeStart), (EdgeList.ToArray()[Ne-1].EdgeEnd));
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcEdgeLoop.IsClosed' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			if (clause == Where.IfcEdgeLoop.IsContinuous) {
				try {
					retVal = IfcLoopHeadToTail(this);
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcEdgeLoop.IsContinuous' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcEdgeLoop.IsClosed))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcEdgeLoop.IsClosed", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcEdgeLoop.IsContinuous))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcEdgeLoop.IsContinuous", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcEdgeLoop
	{
		public static readonly IfcEdgeLoop IsClosed = new IfcEdgeLoop();
		public static readonly IfcEdgeLoop IsContinuous = new IfcEdgeLoop();
		protected IfcEdgeLoop() {}
	}
}
