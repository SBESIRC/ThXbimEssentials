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
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.IfcRail.GeometryResource
{
	public partial class @IfcCartesianPoint : IIfcCartesianPoint
	{

		[CrossSchemaAttribute(typeof(IIfcCartesianPoint), 1)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcLengthMeasure> IIfcCartesianPoint.Coordinates 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcLengthMeasure, Ifc4.MeasureResource.IfcLengthMeasure>(Coordinates, 
					s => new Ifc4.MeasureResource.IfcLengthMeasure(s), 
					t => new MeasureResource.IfcLengthMeasure(t));
			} 
		}
		Ifc4.GeometryResource.IfcDimensionCount Ifc4.GeometricModelResource.IfcGeometricSetSelect.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}