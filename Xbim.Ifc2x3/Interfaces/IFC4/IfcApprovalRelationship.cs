// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ApprovalResource
{
	public partial class @IfcApprovalRelationship : IIfcApprovalRelationship
	{
		IIfcApproval IIfcApprovalRelationship.RelatingApproval 
		{ 
			get
			{
				return RelatingApproval as IIfcApproval;
			} 
		}
		IEnumerable<IIfcApproval> IIfcApprovalRelationship.RelatedApprovals 
		{ 
			get
			{
				//## Handle return of RelatedApprovals for which no match was found
				//TODO: Handle return of RelatedApprovals for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcResourceLevelRelationship.Name 
		{ 
			get
			{
				//## Handle return of Name for which no match was found
				//TODO: Handle return of Name for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcResourceLevelRelationship.Description 
		{ 
			get
			{
				//## Handle return of Description for which no match was found
				//TODO: Handle return of Description for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
	}
}