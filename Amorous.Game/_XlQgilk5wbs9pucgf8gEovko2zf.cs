using System;
using System.Reflection;
using Microsoft.Xna.Framework.Graphics;

public static class _XlQgilk5wbs9pucgf8gEovko2zf
{
	private static readonly PropertyInfo _2m1r1A4nAJ2cK1CdX6V7NfWkAWv = ((_XlQgilk5wbs9pucgf8gEovko2zf)(object)_XlQgilk5wbs9pucgf8gEovko2zf.smethod_1(typeof(RenderTarget2D).TypeHandle)).method_0("RenderTargetUsage", BindingFlags.Instance | BindingFlags.Public);

	public static void _w2YD42TXOY22EP4Mpp7wzDUO4xv(this RenderTarget2D renderTarget2D_0, RenderTargetUsage renderTargetUsage_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_XlQgilk5wbs9pucgf8gEovko2zf.smethod_0(_2m1r1A4nAJ2cK1CdX6V7NfWkAWv, (object)renderTarget2D_0, (object)renderTargetUsage_0, (object[])null);
	}

	static void smethod_0(PropertyInfo propertyInfo_0, object object_0, object object_1, object[] object_2)
	{
		propertyInfo_0.SetValue(object_0, object_1, object_2);
	}

	static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	PropertyInfo method_0(string string_0, BindingFlags bindingFlags_0)
	{
		return ((Type)this).GetProperty(string_0, bindingFlags_0);
	}
}