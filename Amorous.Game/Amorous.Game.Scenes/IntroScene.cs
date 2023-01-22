using System;
using Amorous.Game.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class IntroScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private int _Q7Kx7ErHf3u1QIUDKfFCKSXbznG;

	private readonly float _PbBEddQtI9iZg1ocIlBafUuVdrO;

	public _ujAkjlfN5TywwbLAUDzPvtab6uJ _h29gtnqEWLAa5qsliRXuXiPwY2o { get; private set; }

	public _ujAkjlfN5TywwbLAUDzPvtab6uJ _agB6DEyENfHFg1x2I4KsJqoQUpg { get; private set; }

	public CoupleANPC _4BkRUyoqu3iKk7SRvIVoP35EcKA { get; private set; }

	public CoupleBNPC _ZCUbMPsnW0SgjlADsYyZVasibXM { get; private set; }

	public IntroScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_h29gtnqEWLAa5qsliRXuXiPwY2o = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Intro/Background", 0, 0);
		_agB6DEyENfHFg1x2I4KsJqoQUpg = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Scenery", "Assets/Scenes/Intro/Scenery", 0, 1250);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Biggyzoom - The Night Sky", 0.4f);
		_PbBEddQtI9iZg1ocIlBafUuVdrO = 1f;
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		_ZCUbMPsnW0SgjlADsYyZVasibXM = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		_ZCUbMPsnW0SgjlADsYyZVasibXM._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1280f;
		_ZCUbMPsnW0SgjlADsYyZVasibXM._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1090f;
		_ZCUbMPsnW0SgjlADsYyZVasibXM._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleBNPC.EPoses.Waving);
		_ZCUbMPsnW0SgjlADsYyZVasibXM._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
		_4BkRUyoqu3iKk7SRvIVoP35EcKA = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		_4BkRUyoqu3iKk7SRvIVoP35EcKA._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = -800f;
		_4BkRUyoqu3iKk7SRvIVoP35EcKA._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1090f;
		_4BkRUyoqu3iKk7SRvIVoP35EcKA._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleANPC.EPoses.Waving);
		_4BkRUyoqu3iKk7SRvIVoP35EcKA._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG += gameTime_0.ElapsedGameTime.Milliseconds;
		_EZKvqbHbBzrIsmIefNbwSVvgrP5A(_h29gtnqEWLAa5qsliRXuXiPwY2o, 0f, 18000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 0, 0, 0, -540);
		_EZKvqbHbBzrIsmIefNbwSVvgrP5A(_agB6DEyENfHFg1x2I4KsJqoQUpg, 10000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 8000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 0, 1250, 0, -170);
		_nuSr558RHFkx9d2QBs2DeGUB1wX(_4BkRUyoqu3iKk7SRvIVoP35EcKA, 14000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 4000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, -800, 1090, 600, 1090);
		_nuSr558RHFkx9d2QBs2DeGUB1wX(_ZCUbMPsnW0SgjlADsYyZVasibXM, 14000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 4000f * _PbBEddQtI9iZg1ocIlBafUuVdrO, 1280, 1090, 450, 1090);
	}

	private void _EZKvqbHbBzrIsmIefNbwSVvgrP5A(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0, float float_1, int int_0, int int_1, int int_2, int int_3)
	{
		if (!((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < float_0) && (float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < float_0 + float_1)
		{
			float amount = ((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG - float_0) / float_1;
			_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = MathHelper.Lerp(int_0, int_2, amount);
			_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = MathHelper.Lerp(int_1, int_3, amount);
		}
	}

	private void _nuSr558RHFkx9d2QBs2DeGUB1wX(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0, float float_0, float float_1, int int_0, int int_1, int int_2, int int_3)
	{
		if (!((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < float_0) && (float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < float_0 + float_1)
		{
			float amount = ((float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG - float_0) / float_1;
			_tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = MathHelper.Lerp(int_0, int_2, amount);
			_tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = MathHelper.Lerp(int_1, int_3, amount);
		}
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static void smethod_15(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static void smethod_17(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_18(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	void method_0(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static TimeSpan smethod_19(GameTime gameTime_0)
	{
		return gameTime_0.ElapsedGameTime;
	}

	static float smethod_20(float float_0, float float_1, float float_2)
	{
		return MathHelper.Lerp(float_0, float_1, float_2);
	}

	static void smethod_21(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_22(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
