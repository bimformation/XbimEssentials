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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcRelConnectsPortToElement : IIfcRelConnectsPortToElement
	{
		IIfcPort IIfcRelConnectsPortToElement.RelatingPort 
		{ 
			get
			{
				return RelatingPort;
			} 
			set
			{
				RelatingPort = value as IfcPort;
				
			}
		}
		IIfcDistributionElement IIfcRelConnectsPortToElement.RelatedElement 
		{ 
			get
			{
				//## Handle return of RelatedElement for which no match was found
                return RelatedElement;
				//##
			} 
			set
			{
				//## Handle setting of RelatedElement for which no match was found
				RelatedElement = value as IfcElement;
				//##
				
			}
		}
	//## Custom code
	//##
	}
}