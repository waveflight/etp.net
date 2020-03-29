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
	
	public partial class OpenSession : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"OpenSession\",\"namespace\":\"Energistics.Etp.v12.Protocol.C" +
				"ore\",\"fields\":[{\"name\":\"applicationName\",\"type\":\"string\"},{\"name\":\"applicationVe" +
				"rsion\",\"type\":\"string\"},{\"name\":\"serverInstanceId\",\"type\":{\"type\":\"fixed\",\"name\"" +
				":\"Uuid\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"size\":16,\"fullName\":\"Energi" +
				"stics.Etp.v12.Datatypes.Uuid\",\"depends\":[]}},{\"name\":\"supportedProtocols\",\"type\"" +
				":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"SupportedProtocol\",\"namespace\"" +
				":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"protocol\",\"type\":\"int\"},{\"na" +
				"me\":\"protocolVersion\",\"type\":{\"type\":\"record\",\"name\":\"Version\",\"namespace\":\"Ener" +
				"gistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"major\",\"default\":0,\"type\":\"int\"},{" +
				"\"name\":\"minor\",\"default\":0,\"type\":\"int\"},{\"name\":\"revision\",\"default\":0,\"type\":\"" +
				"int\"},{\"name\":\"patch\",\"default\":0,\"type\":\"int\"}],\"fullName\":\"Energistics.Etp.v12" +
				".Datatypes.Version\",\"depends\":[]}},{\"name\":\"role\",\"type\":\"string\"},{\"name\":\"prot" +
				"ocolCapabilities\",\"default\":{},\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"n" +
				"ame\":\"DataValue\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"" +
				"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"r" +
				"ecord\",\"name\":\"ArrayOfBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fiel" +
				"ds\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}],\"fullName\":\"En" +
				"ergistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"depends\":[]},{\"type\":\"record\",\"name" +
				"\":\"ArrayOfInt\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"va" +
				"lues\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}],\"fullName\":\"Energistics.Etp.v12.Da" +
				"tatypes.ArrayOfInt\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfLong\",\"namespa" +
				"ce\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"a" +
				"rray\",\"items\":\"long\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"" +
				"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfFloat\",\"namespace\":\"Energistics.Etp" +
				".v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float" +
				"\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"depends\":[]},{\"typ" +
				"e\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"" +
				"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}],\"fullName\":" +
				"\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"depends\":[]},{\"type\":\"record\",\"na" +
				"me\":\"ArrayOfString\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name" +
				"\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}],\"fullName\":\"Energistics.Et" +
				"p.v12.Datatypes.ArrayOfString\",\"depends\":[]},\"bytes\"]}],\"fullName\":\"Energistics." +
				"Etp.v12.Datatypes.DataValue\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Array" +
				"OfBoolean\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\r\n  \"Energistics.Etp.v" +
				"12.Datatypes.ArrayOfLong\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\r\n  \"" +
				"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n  \"Energistics.Etp.v12.Datatypes." +
				"ArrayOfString\"\r\n]}}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.SupportedProtoco" +
				"l\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Version\",\r\n  \"Energistics.Etp.v" +
				"12.Datatypes.DataValue\"\r\n]}}},{\"name\":\"supportedObjects\",\"type\":{\"type\":\"array\"," +
				"\"items\":\"string\"}},{\"name\":\"supportedCompression\",\"type\":\"string\"},{\"name\":\"supp" +
				"ortedFormats\",\"default\":[\"xml\"],\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name" +
				"\":\"endpointCapabilities\",\"default\":{},\"type\":{\"type\":\"map\",\"values\":\"Energistics" +
				".Etp.v12.Datatypes.DataValue\"}}],\"protocol\":\"0\",\"messageType\":\"2\",\"senderRole\":\"" +
				"server\",\"protocolRoles\":\"client, server\",\"multipartFlag\":false,\"fullName\":\"Energ" +
				"istics.Etp.v12.Protocol.Core.OpenSession\",\"depends\":[\r\n  \"Energistics.Etp.v12.Da" +
				"tatypes.Uuid\",\r\n  \"Energistics.Etp.v12.Datatypes.SupportedProtocol\",\r\n  \"Energis" +
				"tics.Etp.v12.Datatypes.DataValue\"\r\n]}");
		private string _applicationName;
		private string _applicationVersion;
		private Energistics.Etp.v12.Datatypes.Uuid _serverInstanceId;
		private IList<Energistics.Etp.v12.Datatypes.SupportedProtocol> _supportedProtocols;
		private IList<System.String> _supportedObjects;
		private string _supportedCompression;
		private IList<System.String> _supportedFormats;
		private IDictionary<string,Energistics.Etp.v12.Datatypes.DataValue> _endpointCapabilities;
		public virtual Schema Schema
		{
			get
			{
				return OpenSession._SCHEMA;
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
		public Energistics.Etp.v12.Datatypes.Uuid ServerInstanceId
		{
			get
			{
				return this._serverInstanceId;
			}
			set
			{
				this._serverInstanceId = value;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.SupportedProtocol> SupportedProtocols
		{
			get
			{
				return this._supportedProtocols;
			}
			set
			{
				this._supportedProtocols = value;
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
			case 2: return this._serverInstanceId;
			case 3: return this._supportedProtocols;
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
			case 2: this._serverInstanceId = (Energistics.Etp.v12.Datatypes.Uuid)fieldValue; break;
			case 3: this._supportedProtocols = (IList<Energistics.Etp.v12.Datatypes.SupportedProtocol>)fieldValue; break;
			case 4: this._supportedObjects = (IList<System.String>)fieldValue; break;
			case 5: this._supportedCompression = (System.String)fieldValue; break;
			case 6: this._supportedFormats = (IList<System.String>)fieldValue; break;
			case 7: this._endpointCapabilities = (IDictionary<string,Energistics.Etp.v12.Datatypes.DataValue>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
