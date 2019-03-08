// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.QuantityResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.QuantityResource
{
	[ExpressType("IfcQuantityTime", 254)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityTime : IfcPhysicalSimpleQuantity, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcQuantityTime>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityTime(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcTimeMeasure _timeValue;
		private IfcLabel? _formula;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcTimeMeasure @TimeValue 
		{ 
			get 
			{
				if(_activated) return _timeValue;
				Activate();
				return _timeValue;
			} 
			set
			{
				SetValue( v =>  _timeValue = v, _timeValue, value,  "TimeValue", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcLabel? @Formula 
		{ 
			get 
			{
				if(_activated) return _formula;
				Activate();
				return _formula;
			} 
			set
			{
				SetValue( v =>  _formula = v, _formula, value,  "Formula", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_timeValue = value.RealVal;
					return;
				case 4: 
					_formula = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcQuantityTime other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}