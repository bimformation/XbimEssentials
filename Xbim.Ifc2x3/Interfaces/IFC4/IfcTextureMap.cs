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
	public partial class @IfcTextureMap : IIfcTextureMap
	{
		IEnumerable<IIfcTextureVertex> IIfcTextureMap.Vertices 
		{ 
			get
			{
				//## Handle return of Vertices for which no match was found
			    var map = TextureMaps.FirstOrDefault();
			    return map == null ? Enumerable.Empty<IIfcTextureVertex>() : map.TextureVertices;
			    //##
			} 
		}
		IIfcFace IIfcTextureMap.MappedTo 
		{ 
			get
			{
				//## Handle return of MappedTo for which no match was found
                return new  Interfaces.Conversions.IfcFaceTransient(TextureMaps.First());;
				//##
			} 
			set
			{
				//## Handle setting of MappedTo for which no match was found
			    throw new System.PlatformNotSupportedException();
			    //##
				NotifyPropertyChanged("MappedTo");
				
			}
		}
	//## Custom code
	//##
	}
}