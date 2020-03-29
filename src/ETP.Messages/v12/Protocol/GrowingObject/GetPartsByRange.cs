// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.GrowingObject
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetPartsByRange : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""GetPartsByRange"",""namespace"":""Energistics.Etp.v12.Protocol.GrowingObject"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""format"",""default"":""xml"",""type"":""string""},{""name"":""indexInterval"",""type"":{""type"":""record"",""name"":""IndexInterval"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""startIndex"",""type"":{""type"":""record"",""name"":""IndexValue"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""long"",""double""]}],""fullName"":""Energistics.Etp.v12.Datatypes.IndexValue"",""depends"":[]}},{""name"":""endIndex"",""type"":""Energistics.Etp.v12.Datatypes.IndexValue""},{""name"":""uom"",""type"":""string""},{""name"":""depthDatum"",""default"":"""",""type"":""string""}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.IndexInterval"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.IndexValue"",
  ""Energistics.Etp.v12.Datatypes.IndexValue""
]}},{""name"":""includeOverlappingIntervals"",""type"":""boolean""}],""protocol"":""6"",""messageType"":""4"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRange"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Object.IndexInterval""
]}");
		private string _uri;
		private string _format;
		private Energistics.Etp.v12.Datatypes.Object.IndexInterval _indexInterval;
		private bool _includeOverlappingIntervals;
		public virtual Schema Schema
		{
			get
			{
				return GetPartsByRange._SCHEMA;
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
		public string Format
		{
			get
			{
				return this._format;
			}
			set
			{
				this._format = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.IndexInterval IndexInterval
		{
			get
			{
				return this._indexInterval;
			}
			set
			{
				this._indexInterval = value;
			}
		}
		public bool IncludeOverlappingIntervals
		{
			get
			{
				return this._includeOverlappingIntervals;
			}
			set
			{
				this._includeOverlappingIntervals = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._format;
			case 2: return this._indexInterval;
			case 3: return this._includeOverlappingIntervals;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._format = (System.String)fieldValue; break;
			case 2: this._indexInterval = (Energistics.Etp.v12.Datatypes.Object.IndexInterval)fieldValue; break;
			case 3: this._includeOverlappingIntervals = (System.Boolean)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
