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
namespace Xbim.Ifc2x3.ProfileResource
{
	public partial class @IfcAsymmetricIShapeProfileDef : IIfcAsymmetricIShapeProfileDef
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcAsymmetricIShapeProfileDef.BottomFlangeWidth 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(OverallWidth);
			} 
			set
			{
				OverallWidth = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcAsymmetricIShapeProfileDef.OverallDepth 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(OverallDepth);
			} 
			set
			{
				OverallDepth = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcAsymmetricIShapeProfileDef.WebThickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(WebThickness);
			} 
			set
			{
				WebThickness = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcAsymmetricIShapeProfileDef.BottomFlangeThickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(FlangeThickness);
			} 
			set
			{
				FlangeThickness = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcAsymmetricIShapeProfileDef.BottomFlangeFilletRadius 
		{ 
			get
			{
				if (!FilletRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(FilletRadius.Value);
			} 
			set
			{
				FilletRadius = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcAsymmetricIShapeProfileDef.TopFlangeWidth 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(TopFlangeWidth);
			} 
			set
			{
				TopFlangeWidth = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcAsymmetricIShapeProfileDef.TopFlangeThickness 
		{ 
			get
			{
				if (!TopFlangeThickness.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(TopFlangeThickness.Value);
			} 
			set
			{
				TopFlangeThickness = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcAsymmetricIShapeProfileDef.TopFlangeFilletRadius 
		{ 
			get
			{
				if (!TopFlangeFilletRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(TopFlangeFilletRadius.Value);
			} 
			set
			{
				TopFlangeFilletRadius = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		private  Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? _bottomFlangeEdgeRadius;

		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcAsymmetricIShapeProfileDef.BottomFlangeEdgeRadius 
		{ 
			get
			{
				return _bottomFlangeEdgeRadius;
			} 
			set
			{
				SetValue(v => _bottomFlangeEdgeRadius = v, _bottomFlangeEdgeRadius, value, "BottomFlangeEdgeRadius", byte.MaxValue);
				
			}
		}

		private  Ifc4.MeasureResource.IfcPlaneAngleMeasure? _bottomFlangeSlope;

		Ifc4.MeasureResource.IfcPlaneAngleMeasure? IIfcAsymmetricIShapeProfileDef.BottomFlangeSlope 
		{ 
			get
			{
				return _bottomFlangeSlope;
			} 
			set
			{
				SetValue(v => _bottomFlangeSlope = v, _bottomFlangeSlope, value, "BottomFlangeSlope", byte.MaxValue);
				
			}
		}

		private  Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? _topFlangeEdgeRadius;

		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcAsymmetricIShapeProfileDef.TopFlangeEdgeRadius 
		{ 
			get
			{
				return _topFlangeEdgeRadius;
			} 
			set
			{
				SetValue(v => _topFlangeEdgeRadius = v, _topFlangeEdgeRadius, value, "TopFlangeEdgeRadius", byte.MaxValue);
				
			}
		}

		private  Ifc4.MeasureResource.IfcPlaneAngleMeasure? _topFlangeSlope;

		Ifc4.MeasureResource.IfcPlaneAngleMeasure? IIfcAsymmetricIShapeProfileDef.TopFlangeSlope 
		{ 
			get
			{
				return _topFlangeSlope;
			} 
			set
			{
				SetValue(v => _topFlangeSlope = v, _topFlangeSlope, value, "TopFlangeSlope", byte.MaxValue);
				
			}
		}
	//## Custom code
	//##
	}
}