// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.GrowingObjectNotification
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class PartsChanged : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""PartsChanged"",""namespace"":""Energistics.Etp.v12.Protocol.GrowingObjectNotification"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""requestUuid"",""type"":{""type"":""fixed"",""name"":""Uuid"",""namespace"":""Energistics.Etp.v12.Datatypes"",""size"":16,""fullName"":""Energistics.Etp.v12.Datatypes.Uuid"",""depends"":[]}},{""name"":""changeKind"",""type"":{""type"":""enum"",""name"":""ObjectChangeKind"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""symbols"":[""insert"",""update"",""authorized""],""fullName"":""Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind"",""depends"":[]}},{""name"":""changeTime"",""type"":""long""},{""name"":""format"",""default"":"""",""type"":""string""},{""name"":""parts"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""ObjectPart"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""uid"",""type"":""string""},{""name"":""data"",""type"":""bytes""}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.ObjectPart"",""depends"":[]}}}],""protocol"":""7"",""messageType"":""2"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsChanged"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Uuid"",
  ""Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind"",
  ""Energistics.Etp.v12.Datatypes.Object.ObjectPart""
]}");
		private string _uri;
		private Energistics.Etp.v12.Datatypes.Uuid _requestUuid;
		private Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind _changeKind;
		private long _changeTime;
		private string _format;
		private IList<Energistics.Etp.v12.Datatypes.Object.ObjectPart> _parts;
		public virtual Schema Schema
		{
			get
			{
				return PartsChanged._SCHEMA;
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
		public Energistics.Etp.v12.Datatypes.Uuid RequestUuid
		{
			get
			{
				return this._requestUuid;
			}
			set
			{
				this._requestUuid = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind ChangeKind
		{
			get
			{
				return this._changeKind;
			}
			set
			{
				this._changeKind = value;
			}
		}
		public long ChangeTime
		{
			get
			{
				return this._changeTime;
			}
			set
			{
				this._changeTime = value;
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
		public IList<Energistics.Etp.v12.Datatypes.Object.ObjectPart> Parts
		{
			get
			{
				return this._parts;
			}
			set
			{
				this._parts = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._requestUuid;
			case 2: return this._changeKind;
			case 3: return this._changeTime;
			case 4: return this._format;
			case 5: return this._parts;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._requestUuid = (Energistics.Etp.v12.Datatypes.Uuid)fieldValue; break;
			case 2: this._changeKind = (Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind)fieldValue; break;
			case 3: this._changeTime = (System.Int64)fieldValue; break;
			case 4: this._format = (System.String)fieldValue; break;
			case 5: this._parts = (IList<Energistics.Etp.v12.Datatypes.Object.ObjectPart>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
