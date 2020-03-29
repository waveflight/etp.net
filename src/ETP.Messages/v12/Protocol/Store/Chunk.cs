// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Store
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Chunk : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""Chunk"",""namespace"":""Energistics.Etp.v12.Protocol.Store"",""fields"":[{""name"":""blobId"",""type"":{""type"":""fixed"",""name"":""Uuid"",""namespace"":""Energistics.Etp.v12.Datatypes"",""size"":16,""fullName"":""Energistics.Etp.v12.Datatypes.Uuid"",""depends"":[]}},{""name"":""data"",""type"":""bytes""}],""protocol"":""4"",""messageType"":""8"",""senderRole"":""store,customer"",""protocolRoles"":""store,customer"",""multipartFlag"":true,""fullName"":""Energistics.Etp.v12.Protocol.Store.Chunk"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Uuid""
]}");
		private Energistics.Etp.v12.Datatypes.Uuid _blobId;
		private byte[] _data;
		public virtual Schema Schema
		{
			get
			{
				return Chunk._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Uuid BlobId
		{
			get
			{
				return this._blobId;
			}
			set
			{
				this._blobId = value;
			}
		}
		public byte[] Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._blobId;
			case 1: return this._data;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._blobId = (Energistics.Etp.v12.Datatypes.Uuid)fieldValue; break;
			case 1: this._data = (System.Byte[])fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
