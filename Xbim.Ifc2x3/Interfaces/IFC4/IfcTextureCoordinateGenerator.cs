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
namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	public partial class @IfcTextureCoordinateGenerator : IIfcTextureCoordinateGenerator
	{
		Xbim.Ifc4.MeasureResource.IfcLabel IIfcTextureCoordinateGenerator.Mode 
		{ 
			get
			{
				return new Xbim.Ifc4.MeasureResource.IfcLabel((string)Mode);
			} 
		}
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcReal> IIfcTextureCoordinateGenerator.Parameter 
		{ 
			get
			{
				//## Handle return of Parameter for which no match was found
				//TODO: Handle return of Parameter for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
	}
}