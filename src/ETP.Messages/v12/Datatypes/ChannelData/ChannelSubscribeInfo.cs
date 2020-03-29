// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes.ChannelData
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ChannelSubscribeInfo : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ChannelSubscribeInfo"",""namespace"":""Energistics.Etp.v12.Datatypes.ChannelData"",""fields"":[{""name"":""channelId"",""type"":""long""},{""name"":""startIndex"",""type"":{""type"":""record"",""name"":""IndexValue"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""long"",""double""]}],""fullName"":""Energistics.Etp.v12.Datatypes.IndexValue"",""depends"":[]}},{""name"":""dataChanges"",""default"":true,""type"":""boolean""},{""name"":""requestLatestIndexCount"",""type"":[""null"",""int""]}],""fullName"":""Energistics.Etp.v12.Datatypes.ChannelData.ChannelSubscribeInfo"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.IndexValue""
]}");
		private long _channelId;
		private Energistics.Etp.v12.Datatypes.IndexValue _startIndex;
		private bool _dataChanges;
		private System.Nullable<int> _requestLatestIndexCount;
		public virtual Schema Schema
		{
			get
			{
				return ChannelSubscribeInfo._SCHEMA;
			}
		}
		public long ChannelId
		{
			get
			{
				return this._channelId;
			}
			set
			{
				this._channelId = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.IndexValue StartIndex
		{
			get
			{
				return this._startIndex;
			}
			set
			{
				this._startIndex = value;
			}
		}
		public bool DataChanges
		{
			get
			{
				return this._dataChanges;
			}
			set
			{
				this._dataChanges = value;
			}
		}
		public System.Nullable<int> RequestLatestIndexCount
		{
			get
			{
				return this._requestLatestIndexCount;
			}
			set
			{
				this._requestLatestIndexCount = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._channelId;
			case 1: return this._startIndex;
			case 2: return this._dataChanges;
			case 3: return this._requestLatestIndexCount;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._channelId = (System.Int64)fieldValue; break;
			case 1: this._startIndex = (Energistics.Etp.v12.Datatypes.IndexValue)fieldValue; break;
			case 2: this._dataChanges = (System.Boolean)fieldValue; break;
			case 3: this._requestLatestIndexCount = (System.Nullable<int>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
