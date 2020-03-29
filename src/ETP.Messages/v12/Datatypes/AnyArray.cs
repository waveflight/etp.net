// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class AnyArray : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"AnyArray\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"f" +
				"ields\":[{\"name\":\"item\",\"type\":[{\"type\":\"record\",\"name\":\"ArrayOfBoolean\",\"namespa" +
				"ce\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"a" +
				"rray\",\"items\":\"boolean\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfBool" +
				"ean\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfInt\",\"namespace\":\"Energistics" +
				".Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"i" +
				"nt\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"depends\":[]},{\"typ" +
				"e\":\"record\",\"name\":\"ArrayOfLong\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fi" +
				"elds\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}],\"fullName\":\"Ene" +
				"rgistics.Etp.v12.Datatypes.ArrayOfLong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"A" +
				"rrayOfFloat\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"valu" +
				"es\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}],\"fullName\":\"Energistics.Etp.v12.Da" +
				"tatypes.ArrayOfFloat\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfDouble\",\"nam" +
				"espace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type" +
				"\":\"array\",\"items\":\"double\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfD" +
				"ouble\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfString\",\"namespace\":\"Energi" +
				"stics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"item" +
				"s\":\"string\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"depends" +
				"\":[]},\"bytes\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"depends\":[" +
				"\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\r\n  \"Energistics.Etp.v12.Data" +
				"types.ArrayOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"Energisti" +
				"cs.Etp.v12.Datatypes.ArrayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDou" +
				"ble\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfString\"\r\n]}");
		private object _item;
		public virtual Schema Schema
		{
			get
			{
				return AnyArray._SCHEMA;
			}
		}
		public object Item
		{
			get
			{
				return this._item;
			}
			set
			{
				this._item = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._item;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._item = (System.Object)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
