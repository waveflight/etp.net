// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes.Object
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Resource : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""Resource"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""alternateUris"",""default"":[],""type"":{""type"":""array"",""items"":""string""}},{""name"":""dataObjectType"",""type"":""string""},{""name"":""name"",""type"":""string""},{""name"":""sourceCount"",""default"":null,""type"":[""null"",""int""]},{""name"":""targetCount"",""default"":null,""type"":[""null"",""int""]},{""name"":""lastChanged"",""type"":""long""},{""name"":""customData"",""default"":{},""type"":{""type"":""map"",""values"":""string""}}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.Resource"",""depends"":[]}");
		private string _uri;
		private IList<System.String> _alternateUris;
		private string _dataObjectType;
		private string _name;
		private System.Nullable<int> _sourceCount;
		private System.Nullable<int> _targetCount;
		private long _lastChanged;
		private IDictionary<string,System.String> _customData;
		public virtual Schema Schema
		{
			get
			{
				return Resource._SCHEMA;
			}
		}
		public string Uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}
		public IList<System.String> AlternateUris
		{
			get
			{
				return this._alternateUris;
			}
			set
			{
				this._alternateUris = value;
			}
		}
		public string DataObjectType
		{
			get
			{
				return this._dataObjectType;
			}
			set
			{
				this._dataObjectType = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public System.Nullable<int> SourceCount
		{
			get
			{
				return this._sourceCount;
			}
			set
			{
				this._sourceCount = value;
			}
		}
		public System.Nullable<int> TargetCount
		{
			get
			{
				return this._targetCount;
			}
			set
			{
				this._targetCount = value;
			}
		}
		public long LastChanged
		{
			get
			{
				return this._lastChanged;
			}
			set
			{
				this._lastChanged = value;
			}
		}
		public IDictionary<string,System.String> CustomData
		{
			get
			{
				return this._customData;
			}
			set
			{
				this._customData = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._alternateUris;
			case 2: return this._dataObjectType;
			case 3: return this._name;
			case 4: return this._sourceCount;
			case 5: return this._targetCount;
			case 6: return this._lastChanged;
			case 7: return this._customData;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._alternateUris = (IList<System.String>)fieldValue; break;
			case 2: this._dataObjectType = (System.String)fieldValue; break;
			case 3: this._name = (System.String)fieldValue; break;
			case 4: this._sourceCount = (System.Nullable<int>)fieldValue; break;
			case 5: this._targetCount = (System.Nullable<int>)fieldValue; break;
			case 6: this._lastChanged = (System.Int64)fieldValue; break;
			case 7: this._customData = (IDictionary<string,System.String>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
