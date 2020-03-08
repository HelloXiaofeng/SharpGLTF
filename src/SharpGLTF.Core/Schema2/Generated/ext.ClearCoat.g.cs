//------------------------------------------------------------------------------------------------
//      This file has been programatically generated; DON´T EDIT!
//------------------------------------------------------------------------------------------------

#pragma warning disable SA1001
#pragma warning disable SA1027
#pragma warning disable SA1028
#pragma warning disable SA1121
#pragma warning disable SA1205
#pragma warning disable SA1309
#pragma warning disable SA1402
#pragma warning disable SA1505
#pragma warning disable SA1507
#pragma warning disable SA1508
#pragma warning disable SA1652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.Json;

namespace SharpGLTF.Schema2
{
	using Collections;

	/// <summary>
	/// glTF extension that defines the clearcoat material layer.
	/// </summary>
	partial class MaterialClearCoat : ExtraProperties
	{
	
		private const Double _clearcoatFactorDefault = 0;
		private const Double _clearcoatFactorMinimum = 0;
		private const Double _clearcoatFactorMaximum = 1;
		private Double? _clearcoatFactor = _clearcoatFactorDefault;
		
		private MaterialNormalTextureInfo _clearcoatNormalTexture;
		
		private const Double _clearcoatRoughnessFactorDefault = 0;
		private const Double _clearcoatRoughnessFactorMinimum = 0;
		private const Double _clearcoatRoughnessFactorMaximum = 1;
		private Double? _clearcoatRoughnessFactor = _clearcoatRoughnessFactorDefault;
		
		private TextureInfo _clearcoatRoughnessTexture;
		
		private TextureInfo _clearcoatTexture;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "clearcoatFactor", _clearcoatFactor, _clearcoatFactorDefault);
			SerializePropertyObject(writer, "clearcoatNormalTexture", _clearcoatNormalTexture);
			SerializeProperty(writer, "clearcoatRoughnessFactor", _clearcoatRoughnessFactor, _clearcoatRoughnessFactorDefault);
			SerializePropertyObject(writer, "clearcoatRoughnessTexture", _clearcoatRoughnessTexture);
			SerializePropertyObject(writer, "clearcoatTexture", _clearcoatTexture);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "clearcoatFactor": _clearcoatFactor = DeserializePropertyValue<Double?>(ref reader); break;
				case "clearcoatNormalTexture": _clearcoatNormalTexture = DeserializePropertyValue<MaterialNormalTextureInfo>(ref reader); break;
				case "clearcoatRoughnessFactor": _clearcoatRoughnessFactor = DeserializePropertyValue<Double?>(ref reader); break;
				case "clearcoatRoughnessTexture": _clearcoatRoughnessTexture = DeserializePropertyValue<TextureInfo>(ref reader); break;
				case "clearcoatTexture": _clearcoatTexture = DeserializePropertyValue<TextureInfo>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

}
