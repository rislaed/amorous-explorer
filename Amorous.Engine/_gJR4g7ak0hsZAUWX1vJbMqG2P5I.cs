using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _gJR4g7ak0hsZAUWX1vJbMqG2P5I : _RlrsL89bialFQa9mzWurgsdr6FK<Color>
{
	private readonly Texture2D _OzFEGvZu5tqLcitcWhX3j9pIBZM;

	public _gJR4g7ak0hsZAUWX1vJbMqG2P5I(GraphicsDevice graphicsDevice_0)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		_OzFEGvZu5tqLcitcWhX3j9pIBZM = _gJR4g7ak0hsZAUWX1vJbMqG2P5I.smethod_1(graphicsDevice_0, 1, 1, bool_0: false, (SurfaceFormat)0);
		_OzFEGvZu5tqLcitcWhX3j9pIBZM.SetData<Color>((Color[])(object)new Color[1] { Color.get_White() });
	}

	protected override Color _Gs9QTlqmpM6Jpgrjf53LUcRTbM(Color color_0, Color color_1, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Color.Lerp(color_0, color_1, float_0);
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, _wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		_gJR4g7ak0hsZAUWX1vJbMqG2P5I.smethod_2(spriteBatch_0);
		spriteBatch_0.Draw(_OzFEGvZu5tqLcitcWhX3j9pIBZM, new Rectangle(0, 0, _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._L7Fbjq2u4uL5uJIyoRAHpKNXmDI, _wRd4nHuQQlAPEwrHOGkBfut6Uip_0._omy3Cp1IbOKtE3eoz7lAP5DqhT9), base._SWODlbUkQEqfwrtprjLPOeGF7HO);
		spriteBatch_0.End();
	}

	public void _PYAXEqRAOkDRRNqm1k71R7GJTJK(Action action_0 = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		_9JRBBOsuQbaGxb3DQypwWYtojV0(new Color(0, 0, 0, 255), action_0);
	}

	public void _FegL010tc92iskjjyD0T33dDwNE(Action action_0 = null)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		_9JRBBOsuQbaGxb3DQypwWYtojV0(new Color(0, 0, 0, 0), action_0);
	}

	public void _7d2DAwjp6FutkJY09U0Mlk43Nmn(Color color_0, Action action_0 = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_9JRBBOsuQbaGxb3DQypwWYtojV0(color_0, action_0);
	}

	public void _E7yBM68AWt7OGHJ5D6xYA8RK8tAA(Color color_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_98dbKZq4dvkw2wLkjZ77Y5Ih4xP(color_0);
	}

	static Texture2D smethod_1(GraphicsDevice graphicsDevice_0, int int_0, int int_1, bool bool_0, SurfaceFormat surfaceFormat_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Texture2D(graphicsDevice_0, int_0, int_1, bool_0, surfaceFormat_0);
	}

	static void smethod_2(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}
}