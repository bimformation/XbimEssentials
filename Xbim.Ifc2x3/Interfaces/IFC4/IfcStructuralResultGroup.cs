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
namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralResultGroup : IIfcStructuralResultGroup
	{
		Ifc4.Interfaces.IfcAnalysisTheoryTypeEnum IIfcStructuralResultGroup.TheoryType 
		{ 
			get
			{
				switch (TheoryType)
				{
					case IfcAnalysisTheoryTypeEnum.FIRST_ORDER_THEORY:
						return Ifc4.Interfaces.IfcAnalysisTheoryTypeEnum.FIRST_ORDER_THEORY;
					
					case IfcAnalysisTheoryTypeEnum.SECOND_ORDER_THEORY:
						return Ifc4.Interfaces.IfcAnalysisTheoryTypeEnum.SECOND_ORDER_THEORY;
					
					case IfcAnalysisTheoryTypeEnum.THIRD_ORDER_THEORY:
						return Ifc4.Interfaces.IfcAnalysisTheoryTypeEnum.THIRD_ORDER_THEORY;
					
					case IfcAnalysisTheoryTypeEnum.FULL_NONLINEAR_THEORY:
						return Ifc4.Interfaces.IfcAnalysisTheoryTypeEnum.FULL_NONLINEAR_THEORY;
					
					case IfcAnalysisTheoryTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcAnalysisTheoryTypeEnum.USERDEFINED;
					
					case IfcAnalysisTheoryTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcAnalysisTheoryTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		IIfcStructuralLoadGroup IIfcStructuralResultGroup.ResultForLoadGroup 
		{ 
			get
			{
				return ResultForLoadGroup;
			} 
			set
			{
				ResultForLoadGroup = value as IfcStructuralLoadGroup;
				
			}
		}
		Ifc4.MeasureResource.IfcBoolean IIfcStructuralResultGroup.IsLinear 
		{ 
			get
			{
				//## Handle return of IsLinear for which no match was found
                return new Ifc4.MeasureResource.IfcBoolean(IsLinear);
				//##
			} 
			set
			{
				IsLinear = value;
				
			}
		}
		IEnumerable<IIfcStructuralAnalysisModel> IIfcStructuralResultGroup.ResultGroupFor 
		{ 
			get
			{
				return Model.Instances.Where<IIfcStructuralAnalysisModel>(e => e.HasResults != null &&  e.HasResults.Contains(this), "HasResults", this);
			} 
		}
	//## Custom code
	//##
	}
}