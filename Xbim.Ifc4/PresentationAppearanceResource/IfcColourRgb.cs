// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCCOLOURRGB", 490)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcColourRgb : IfcColourSpecification, IfcColourOrFactor, IInstantiableEntity, IEqualityComparer<@IfcColourRgb>, IEquatable<@IfcColourRgb>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcColourRgb(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcNormalisedRatioMeasure _red;
		private IfcNormalisedRatioMeasure _green;
		private IfcNormalisedRatioMeasure _blue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure @Red 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _red;
				((IPersistEntity)this).Activate(false);
				return _red;
			} 
			set
			{
				SetValue( v =>  _red = v, _red, value,  "Red");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure @Green 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _green;
				((IPersistEntity)this).Activate(false);
				return _green;
			} 
			set
			{
				SetValue( v =>  _green = v, _green, value,  "Green");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure @Blue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _blue;
				((IPersistEntity)this).Activate(false);
				return _blue;
			} 
			set
			{
				SetValue( v =>  _blue = v, _blue, value,  "Blue");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_red = value.RealVal;
					return;
				case 2: 
					_green = value.RealVal;
					return;
				case 3: 
					_blue = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcColourRgb other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcColourRgb
            var root = (@IfcColourRgb)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcColourRgb left, @IfcColourRgb right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcColourRgb left, @IfcColourRgb right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcColourRgb x, @IfcColourRgb y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcColourRgb obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}