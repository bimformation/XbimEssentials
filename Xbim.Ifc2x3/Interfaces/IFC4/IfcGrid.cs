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
	public partial class @IfcGrid : IIfcGrid
	{
		IEnumerable<IIfcGridAxis> IIfcGrid.UAxes 
		{ 
			get
			{
			foreach (var member in UAxes)
			{
				yield return member as IIfcGridAxis;
			}
			} 
		}
		IEnumerable<IIfcGridAxis> IIfcGrid.VAxes 
		{ 
			get
			{
			foreach (var member in VAxes)
			{
				yield return member as IIfcGridAxis;
			}
			} 
		}
		IEnumerable<IIfcGridAxis> IIfcGrid.WAxes 
		{ 
			get
			{
			foreach (var member in WAxes)
			{
				yield return member as IIfcGridAxis;
			}
			} 
		}
		Xbim.Ifc4.ProductExtension.IfcGridTypeEnum? IIfcGrid.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
				//TODO: Handle return of PredefinedType for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcGrid.ContainedInStructure 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelContainedInSpatialStructure>(e => e.RelatedElements != null &&  e.RelatedElements.Contains(this));
			} 
		}
	}
}