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
namespace Xbim.Ifc2x3.PlumbingFireProtectionDomain
{
	public partial class @IfcWasteTerminalType : IIfcWasteTerminalType
	{
		Xbim.Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum IIfcWasteTerminalType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.FLOORTRAP:
						return Xbim.Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.FLOORTRAP;
					
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.FLOORWASTE:
						return Xbim.Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.FLOORWASTE;
					
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.GULLYSUMP:
						return Xbim.Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.GULLYSUMP;
					
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.GULLYTRAP:
						return Xbim.Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.GULLYTRAP;
					
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.GREASEINTERCEPTOR:
						//## Handle translation of GREASEINTERCEPTOR member from IfcWasteTerminalTypeEnum in property PredefinedType
						//TODO: Handle translation of GREASEINTERCEPTOR member from IfcWasteTerminalTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.OILINTERCEPTOR:
						//## Handle translation of OILINTERCEPTOR member from IfcWasteTerminalTypeEnum in property PredefinedType
						//TODO: Handle translation of OILINTERCEPTOR member from IfcWasteTerminalTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.PETROLINTERCEPTOR:
						//## Handle translation of PETROLINTERCEPTOR member from IfcWasteTerminalTypeEnum in property PredefinedType
						//TODO: Handle translation of PETROLINTERCEPTOR member from IfcWasteTerminalTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.ROOFDRAIN:
						return Xbim.Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.ROOFDRAIN;
					
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.WASTEDISPOSALUNIT:
						return Xbim.Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.WASTEDISPOSALUNIT;
					
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.WASTETRAP:
						return Xbim.Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.WASTETRAP;
					
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.USERDEFINED:
						return Xbim.Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}