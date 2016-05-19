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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcDoorStyle : IIfcDoorStyle
	{
		Ifc4.Interfaces.IfcDoorStyleOperationEnum IIfcDoorStyle.OperationType 
		{ 
			get
			{
				switch (OperationType)
				{
					case IfcDoorStyleOperationEnum.SINGLE_SWING_LEFT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.SINGLE_SWING_LEFT;
					
					case IfcDoorStyleOperationEnum.SINGLE_SWING_RIGHT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.SINGLE_SWING_RIGHT;
					
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING;
					
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT;
					
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT;
					
					case IfcDoorStyleOperationEnum.DOUBLE_SWING_LEFT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_SWING_LEFT;
					
					case IfcDoorStyleOperationEnum.DOUBLE_SWING_RIGHT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_SWING_RIGHT;
					
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_DOUBLE_SWING:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_DOUBLE_SWING;
					
					case IfcDoorStyleOperationEnum.SLIDING_TO_LEFT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.SLIDING_TO_LEFT;
					
					case IfcDoorStyleOperationEnum.SLIDING_TO_RIGHT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.SLIDING_TO_RIGHT;
					
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_SLIDING:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SLIDING;
					
					case IfcDoorStyleOperationEnum.FOLDING_TO_LEFT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.FOLDING_TO_LEFT;
					
					case IfcDoorStyleOperationEnum.FOLDING_TO_RIGHT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.FOLDING_TO_RIGHT;
					
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_FOLDING:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_FOLDING;
					
					case IfcDoorStyleOperationEnum.REVOLVING:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.REVOLVING;
					
					case IfcDoorStyleOperationEnum.ROLLINGUP:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.ROLLINGUP;
					
					case IfcDoorStyleOperationEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.USERDEFINED;
					
					case IfcDoorStyleOperationEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		Ifc4.Interfaces.IfcDoorStyleConstructionEnum IIfcDoorStyle.ConstructionType 
		{ 
			get
			{
				switch (ConstructionType)
				{
					case IfcDoorStyleConstructionEnum.ALUMINIUM:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.ALUMINIUM;
					
					case IfcDoorStyleConstructionEnum.HIGH_GRADE_STEEL:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.HIGH_GRADE_STEEL;
					
					case IfcDoorStyleConstructionEnum.STEEL:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.STEEL;
					
					case IfcDoorStyleConstructionEnum.WOOD:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.WOOD;
					
					case IfcDoorStyleConstructionEnum.ALUMINIUM_WOOD:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.ALUMINIUM_WOOD;
					
					case IfcDoorStyleConstructionEnum.ALUMINIUM_PLASTIC:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.ALUMINIUM_PLASTIC;
					
					case IfcDoorStyleConstructionEnum.PLASTIC:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.PLASTIC;
					
					case IfcDoorStyleConstructionEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.USERDEFINED;
					
					case IfcDoorStyleConstructionEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		Ifc4.MeasureResource.IfcBoolean IIfcDoorStyle.ParameterTakesPrecedence 
		{ 
			get
			{
				//## Handle return of ParameterTakesPrecedence for which no match was found
			    return new Ifc4.MeasureResource.IfcBoolean(ParameterTakesPrecedence);
			    //##
			} 
			set
			{
				ParameterTakesPrecedence = value;
				
			}
		}
		Ifc4.MeasureResource.IfcBoolean IIfcDoorStyle.Sizeable 
		{ 
			get
			{
				//## Handle return of Sizeable for which no match was found
                return new Ifc4.MeasureResource.IfcBoolean(Sizeable);
				//##
			} 
			set
			{
				Sizeable = value;
				
			}
		}
	//## Custom code
	//##
	}
}