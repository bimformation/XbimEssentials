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
	public partial class @IfcWindowLiningProperties : IIfcWindowLiningProperties
	{
		Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcWindowLiningProperties.LiningDepth 
		{ 
			get
			{
				if (LiningDepth == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)LiningDepth);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcWindowLiningProperties.LiningThickness 
		{ 
			get
			{
				if (LiningThickness == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcNonNegativeLengthMeasure((double)LiningThickness);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcWindowLiningProperties.TransomThickness 
		{ 
			get
			{
				if (TransomThickness == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcNonNegativeLengthMeasure((double)TransomThickness);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcWindowLiningProperties.MullionThickness 
		{ 
			get
			{
				if (MullionThickness == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcNonNegativeLengthMeasure((double)MullionThickness);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.FirstTransomOffset 
		{ 
			get
			{
				if (FirstTransomOffset == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)FirstTransomOffset);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.SecondTransomOffset 
		{ 
			get
			{
				if (SecondTransomOffset == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)SecondTransomOffset);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.FirstMullionOffset 
		{ 
			get
			{
				if (FirstMullionOffset == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)FirstMullionOffset);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.SecondMullionOffset 
		{ 
			get
			{
				if (SecondMullionOffset == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)SecondMullionOffset);
			} 
		}
		IIfcShapeAspect IIfcWindowLiningProperties.ShapeAspectStyle 
		{ 
			get
			{
				return ShapeAspectStyle as IIfcShapeAspect;
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLengthMeasure? IIfcWindowLiningProperties.LiningOffset 
		{ 
			get
			{
				//## Handle return of LiningOffset for which no match was found
				//TODO: Handle return of LiningOffset for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLengthMeasure? IIfcWindowLiningProperties.LiningToPanelOffsetX 
		{ 
			get
			{
				//## Handle return of LiningToPanelOffsetX for which no match was found
				//TODO: Handle return of LiningToPanelOffsetX for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLengthMeasure? IIfcWindowLiningProperties.LiningToPanelOffsetY 
		{ 
			get
			{
				//## Handle return of LiningToPanelOffsetY for which no match was found
				//TODO: Handle return of LiningToPanelOffsetY for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
	}
}