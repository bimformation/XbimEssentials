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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcFillAreaStyleTiles : IIfcFillAreaStyleTiles
	{
		IEnumerable<IIfcVector> IIfcFillAreaStyleTiles.TilingPattern 
		{ 
			get
			{
				//## Handle return of TilingPattern for which no match was found
				//TODO: Handle return of TilingPattern for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		IEnumerable<IIfcStyledItem> IIfcFillAreaStyleTiles.Tiles 
		{ 
			get
			{
				//## Handle return of Tiles for which no match was found
				//TODO: Handle return of Tiles for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcPositiveRatioMeasure IIfcFillAreaStyleTiles.TilingScale 
		{ 
			get
			{
				return new Xbim.Ifc4.MeasureResource.IfcPositiveRatioMeasure((double)TilingScale);
			} 
		}
	}
}