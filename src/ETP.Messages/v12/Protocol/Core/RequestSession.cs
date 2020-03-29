// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Core
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class RequestSession : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"RequestSession\",\"namespace\":\"Energistics.Etp.v12.Protoco" +
				"l.Core\",\"fields\":[{\"name\":\"applicationName\",\"type\":\"string\"},{\"name\":\"applicatio" +
				"nVersion\",\"type\":\"string\"},{\"name\":\"clientInstanceId\",\"type\":{\"type\":\"fixed\",\"na" +
				"me\":\"Uuid\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"size\":16,\"fullName\":\"Ene" +
				"rgistics.Etp.v12.Datatypes.Uuid\",\"depends\":[]}},{\"name\":\"requestedProtocols\",\"ty" +
				"pe\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"SupportedProtocol\",\"namespa" +
				"ce\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"protocol\",\"type\":\"int\"},{" +
				"\"name\":\"protocolVersion\",\"type\":{\"type\":\"record\",\"name\":\"Version\",\"namespace\":\"E" +
				"nergistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"major\",\"default\":0,\"type\":\"int\"" +
				"},{\"name\":\"minor\",\"default\":0,\"type\":\"int\"},{\"name\":\"revision\",\"default\":0,\"type" +
				"\":\"int\"},{\"name\":\"patch\",\"default\":0,\"type\":\"int\"}],\"fullName\":\"Energistics.Etp." +
				"v12.Datatypes.Version\",\"depends\":[]}},{\"name\":\"role\",\"type\":\"string\"},{\"name\":\"p" +
				"rotocolCapabilities\",\"default\":{},\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\"" +
				",\"name\":\"DataValue\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name" +
				"\":\"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\"" +
				":\"record\",\"name\":\"ArrayOfBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"f" +
				"ields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}],\"fullName\":" +
				"\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"depends\":[]},{\"type\":\"record\",\"n" +
				"ame\":\"ArrayOfInt\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":" +
				"\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}],\"fullName\":\"Energistics.Etp.v12" +
				".Datatypes.ArrayOfInt\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfLong\",\"name" +
				"space\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\"" +
				":\"array\",\"items\":\"long\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong" +
				"\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfFloat\",\"namespace\":\"Energistics." +
				"Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"fl" +
				"oat\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"depends\":[]},{\"" +
				"type\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"Energistics.Etp.v12.Datatypes" +
				"\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}],\"fullNam" +
				"e\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"depends\":[]},{\"type\":\"record\"," +
				"\"name\":\"ArrayOfString\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"n" +
				"ame\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}],\"fullName\":\"Energistics" +
				".Etp.v12.Datatypes.ArrayOfString\",\"depends\":[]},\"bytes\"]}],\"fullName\":\"Energisti" +
				"cs.Etp.v12.Datatypes.DataValue\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Ar" +
				"rayOfBoolean\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\r\n  \"Energistics.Et" +
				"p.v12.Datatypes.ArrayOfLong\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\r\n" +
				"  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n  \"Energistics.Etp.v12.Datatyp" +
				"es.ArrayOfString\"\r\n]}}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.SupportedProt" +
				"ocol\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Version\",\r\n  \"Energistics.Et" +
				"p.v12.Datatypes.DataValue\"\r\n]}}},{\"name\":\"supportedObjects\",\"type\":{\"type\":\"arra" +
				"y\",\"items\":\"string\"}},{\"name\":\"supportedCompression\",\"type\":\"string\"},{\"name\":\"s" +
				"upportedFormats\",\"default\":[\"xml\"],\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"n" +
				"ame\":\"endpointCapabilities\",\"default\":{},\"type\":{\"type\":\"map\",\"values\":\"Energist" +
				"ics.Etp.v12.Datatypes.DataValue\"}}],\"protocol\":\"0\",\"messageType\":\"1\",\"senderRole" +
				"\":\"client\",\"protocolRoles\":\"client, server\",\"multipartFlag\":false,\"fullName\":\"En" +
				"ergistics.Etp.v12.Protocol.Core.RequestSession\",\"depends\":[\r\n  \"Energistics.Etp." +
				"v12.Datatypes.Uuid\",\r\n  \"Energistics.Etp.v12.Datatypes.SupportedProtocol\",\r\n  \"E" +
				"nergistics.Etp.v12.Datatypes.DataValue\"\r\n]}");
		private string _applicationName;
		private string _applicationVersion;
		private Energistics.Etp.v12.Datatypes.Uuid _clientInstanceId;
		private IList<Energistics.Etp.v12.Datatypes.SupportedProtocol> _requestedProtocols;
		private IList<System.String> _supportedObjects;
		private string _supportedCompression;
		private IList<System.String> _supportedFormats;
		private IDictionary<string,Energistics.Etp.v12.Datatypes.DataValue> _endpointCapabilities;
		public virtual Schema Schema
		{
			get
			{
				return RequestSession._SCHEMA;
			}
		}
		public string ApplicationName
		{
			get
			{
				return this._applicationName;
			}
			set
			{
				this._applicationName = value;
			}
		}
		public string ApplicationVersion
		{
			get
			{
				return this._applicationVersion;
			}
			set
			{
				this._applicationVersion = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.Uuid ClientInstanceId
		{
			get
			{
				return this._clientInstanceId;
			}
			set
			{
				this._clientInstanceId = value;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.SupportedProtocol> RequestedProtocols
		{
			get
			{
				return this._requestedProtocols;
			}
			set
			{
				this._requestedProtocols = value;
			}
		}
		public IList<System.String> SupportedObjects
		{
			get
			{
				return this._supportedObjects;
			}
			set
			{
				this._supportedObjects = value;
			}
		}
		public string SupportedCompression
		{
			get
			{
				return this._supportedCompression;
			}
			set
			{
				this._supportedCompression = value;
			}
		}
		public IList<System.String> SupportedFormats
		{
			get
			{
				return this._supportedFormats;
			}
			set
			{
				this._supportedFormats = value;
			}
		}
		public IDictionary<string,Energistics.Etp.v12.Datatypes.DataValue> EndpointCapabilities
		{
			get
			{
				return this._endpointCapabilities;
			}
			set
			{
				this._endpointCapabilities = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._applicationName;
			case 1: return this._applicationVersion;
			case 2: return this._clientInstanceId;
			case 3: return this._requestedProtocols;
			case 4: return this._supportedObjects;
			case 5: return this._supportedCompression;
			case 6: return this._supportedFormats;
			case 7: return this._endpointCapabilities;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._applicationName = (System.String)fieldValue; break;
			case 1: this._applicationVersion = (System.String)fieldValue; break;
			case 2: this._clientInstanceId = (Energistics.Etp.v12.Datatypes.Uuid)fieldValue; break;
			case 3: this._requestedProtocols = (IList<Energistics.Etp.v12.Datatypes.SupportedProtocol>)fieldValue; break;
			case 4: this._supportedObjects = (IList<System.String>)fieldValue; break;
			case 5: this._supportedCompression = (System.String)fieldValue; break;
			case 6: this._supportedFormats = (IList<System.String>)fieldValue; break;
			case 7: this._endpointCapabilities = (IDictionary<string,Energistics.Etp.v12.Datatypes.DataValue>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
