// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.StoreNotification
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class UnsubscribeNotifications : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""UnsubscribeNotifications"",""namespace"":""Energistics.Etp.v12.Protocol.StoreNotification"",""fields"":[{""name"":""requestUuid"",""type"":{""type"":""fixed"",""name"":""Uuid"",""namespace"":""Energistics.Etp.v12.Datatypes"",""size"":16,""fullName"":""Energistics.Etp.v12.Datatypes.Uuid"",""depends"":[]}}],""protocol"":""5"",""messageType"":""4"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.Protocol.StoreNotification.UnsubscribeNotifications"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Uuid""
]}");
		private Energistics.Etp.v12.Datatypes.Uuid _requestUuid;
		public virtual Schema Schema
		{
			get
			{
				return UnsubscribeNotifications._SCHEMA;
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
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._requestUuid;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._requestUuid = (Energistics.Etp.v12.Datatypes.Uuid)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
