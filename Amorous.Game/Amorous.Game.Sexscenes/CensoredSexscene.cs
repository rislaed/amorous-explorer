using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Sexscenes;

public class CensoredSexscene : _TwlwMC1hhdSzamwGWEBxuUkz1gH
{
	private class Particle
	{
		private const int _UxXe1ddUXYV0OcLhWHiKYTJ4pDc = 64;

		private const int _MuBaCWbggdeCgody902PC7mPx77 = 1080;

		private float _nD28BmrDaEzCHelTAa14TKyuSyG;

		private float _LkckKdvuh9GaAwn7XojfbJBd91r;

		private float _MnKzCyEExhWnbYODXLISlC7P0D9;

		private float _AQwQu1ldCtpbkD5F9oEByJdCnWaA;

		private float _u8pBof2EYEcHCEDxEtA27OOeLmVb;

		private float _vS7dI6rh0z8HEXKEL7oHBGUMNb4;

		private float _fEoXp8v9qmXyfxzaUZzMonygxpN;

		private float _SJ8FQp8xbJuebaQOrgLvEJN49JI;

		private float _eJdobumzbRJtj3Df3Y2IgIJQb0c;

		private float _rGcC4uzFv31JwubJhcgwuiNZiMh;

		public Particle()
		{
			_haICL4qkfkOLhPhofWQH1GmjZx5();
		}

		private void _haICL4qkfkOLhPhofWQH1GmjZx5()
		{
			_nD28BmrDaEzCHelTAa14TKyuSyG = Particle.smethod_0(64, 1856);
			_LkckKdvuh9GaAwn7XojfbJBd91r = 1144f;
			_MnKzCyEExhWnbYODXLISlC7P0D9 = 0f;
			_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 1f;
			_u8pBof2EYEcHCEDxEtA27OOeLmVb = Particle.smethod_1(-10f, 10f);
			_vS7dI6rh0z8HEXKEL7oHBGUMNb4 = Particle.smethod_1(128f, 256f);
			_fEoXp8v9qmXyfxzaUZzMonygxpN = Particle.smethod_1(1f, 5f);
			_SJ8FQp8xbJuebaQOrgLvEJN49JI = Particle.smethod_1(10f, 100f);
			_eJdobumzbRJtj3Df3Y2IgIJQb0c = Particle.smethod_1(1f, 3f);
			_rGcC4uzFv31JwubJhcgwuiNZiMh = Particle.smethod_1(0f, 1080f);
		}

		public void _tiBFUHPEkedkbgvuX3whdeyjhKo(float float_0)
		{
			_nD28BmrDaEzCHelTAa14TKyuSyG += (float)Particle.smethod_2((double)(_boyt8NIMtKsAGSTcjHeL0WMbFxs._AmIUCcrmrrQiiirja7DoiZSjXuv * _fEoXp8v9qmXyfxzaUZzMonygxpN)) * (_SJ8FQp8xbJuebaQOrgLvEJN49JI * float_0);
			_LkckKdvuh9GaAwn7XojfbJBd91r -= _vS7dI6rh0z8HEXKEL7oHBGUMNb4 * float_0;
			if (_LkckKdvuh9GaAwn7XojfbJBd91r < _rGcC4uzFv31JwubJhcgwuiNZiMh)
			{
				_MnKzCyEExhWnbYODXLISlC7P0D9 += _vS7dI6rh0z8HEXKEL7oHBGUMNb4 * _eJdobumzbRJtj3Df3Y2IgIJQb0c * float_0;
				_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 1f - _MnKzCyEExhWnbYODXLISlC7P0D9 / _rGcC4uzFv31JwubJhcgwuiNZiMh;
			}
			if (_LkckKdvuh9GaAwn7XojfbJBd91r + 64f < 0f || _AQwQu1ldCtpbkD5F9oEByJdCnWaA <= 0f)
			{
				_haICL4qkfkOLhPhofWQH1GmjZx5();
			}
		}

		public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(Texture2D texture2D_0, SpriteBatch spriteBatch_0)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			spriteBatch_0.Draw(texture2D_0, new Rectangle((int)_nD28BmrDaEzCHelTAa14TKyuSyG, (int)_LkckKdvuh9GaAwn7XojfbJBd91r, 128, 128), (Rectangle?)null, Color.get_White() * _AQwQu1ldCtpbkD5F9oEByJdCnWaA, MathHelper.ToRadians(_u8pBof2EYEcHCEDxEtA27OOeLmVb), new Vector2(64f, 64f), (SpriteEffects)0, 0f);
		}

		static int smethod_0(int int_0, int int_1)
		{
			return _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(int_0, int_1);
		}

		static float smethod_1(float float_0, float float_1)
		{
			return _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(float_0, float_1);
		}

		static double smethod_2(double double_0)
		{
			return Math.Sin(double_0);
		}
	}

	private const int _nqUCZ5ck6SfD47CNEeTDsDMAThLA = 10;

	private readonly List<Particle> _lpzETYXyRHxYihXrkJactMysoTi;

	private readonly Texture2D _tt9eBN54CTaryoKDBFZI2D44oni;

	private float _Ja1biX4ByqpjkgcLg9SPPz8y4itA;

	public CensoredSexscene(ContentManager contentManager_0, string string_0, string string_1, string string_2 = null, float float_0 = 1f, bool bool_0 = true, List<SpineEvent> list_0 = null, _sa8EsNgk4VDRaASdXE7VprdlNlg _sa8EsNgk4VDRaASdXE7VprdlNlg_0 = null, float float_1 = 1000f)
		: base(contentManager_0, string_0, string_1, CensoredSexscene.smethod_9() ? "Assets/SexScenes/Generic/Overlay" : string_2, float_0, bool_0, CensoredSexscene.smethod_9() ? null : list_0, _sa8EsNgk4VDRaASdXE7VprdlNlg_0)
	{
		if (CensoredSexscene.smethod_9())
		{
			_YDmx0efYtcyg4olWGsr0rBMkyjD = (_aElCqTEKQdwgSGVsOO7nt14UEsn = float_1);
			_lpzETYXyRHxYihXrkJactMysoTi = new List<Particle>();
			_tt9eBN54CTaryoKDBFZI2D44oni = contentManager_0.Load<Texture2D>("Assets/SexScenes/Generic/Heart");
			CensoredSexscene.smethod_10("Assets/Music/Steampianist - O Morro Nao Tem Vez", 0.4f);
		}
	}

	public override void _WhR14B3jaJk70xEEeAkh2VLlhbA()
	{
		if (!CensoredSexscene.smethod_9())
		{
			this.method_0();
		}
	}

	public override void _VandJrNHr65bKmzzmFYTOwD1icL()
	{
		if (!CensoredSexscene.smethod_9())
		{
			this.method_1();
		}
	}

	public override void _4XV5xPzQUH5ABIwpxH3yf5EIAyL(int int_0, bool bool_0 = false)
	{
		if (!CensoredSexscene.smethod_9())
		{
			this.method_2(int_0, bool_0);
		}
	}

	public override void _JHfBnmyItvKJDQtdUPp2yLsm4yR()
	{
		if (!CensoredSexscene.smethod_9())
		{
			this.method_3();
		}
	}

	public override void _oHE0dGUBNplXQia6K85vMaNc8jp()
	{
		if (!CensoredSexscene.smethod_9())
		{
			this.method_4();
		}
	}

	public override void _paoLItUYkFWaGSDnCAvBagJ1F5T()
	{
		if (!CensoredSexscene.smethod_9())
		{
			this.method_5();
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		this.method_6(gameTime_0);
		if (!CensoredSexscene.smethod_9())
		{
			return;
		}
		float num = (float)(CensoredSexscene.smethod_11(gameTime_0).TotalMilliseconds / 1000.0);
		if (_lpzETYXyRHxYihXrkJactMysoTi.Count < 10)
		{
			_Ja1biX4ByqpjkgcLg9SPPz8y4itA -= num;
			if (_Ja1biX4ByqpjkgcLg9SPPz8y4itA < 0f)
			{
				_Ja1biX4ByqpjkgcLg9SPPz8y4itA = _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(0f, 1f);
				_lpzETYXyRHxYihXrkJactMysoTi.Add(new Particle());
			}
		}
		foreach (Particle item in _lpzETYXyRHxYihXrkJactMysoTi)
		{
			item._tiBFUHPEkedkbgvuX3whdeyjhKo(num);
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		this.method_7(spriteBatch_0, skeletonMeshRenderer_0);
		if (!CensoredSexscene.smethod_9())
		{
			return;
		}
		CensoredSexscene.smethod_12(spriteBatch_0);
		foreach (Particle item in _lpzETYXyRHxYihXrkJactMysoTi)
		{
			item._f5ctqAmdNsZ889UjM4LxDm8WGxA(_tt9eBN54CTaryoKDBFZI2D44oni, spriteBatch_0);
		}
		CensoredSexscene.smethod_13(spriteBatch_0);
	}

	public override void _eXH4tq2J0DADXDLofA8G8Yw8fau(_qokIrmaaT3Lq6znW10HdrPUO9Fq _qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool bool_0)
	{
		if (!CensoredSexscene.smethod_9())
		{
			this.method_8(_qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool_0);
		}
	}

	static bool smethod_9()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
	}

	static void smethod_10(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	void method_0()
	{
		base._WhR14B3jaJk70xEEeAkh2VLlhbA();
	}

	void method_1()
	{
		base._VandJrNHr65bKmzzmFYTOwD1icL();
	}

	void method_2(int int_0, bool bool_0)
	{
		base._4XV5xPzQUH5ABIwpxH3yf5EIAyL(int_0, bool_0);
	}

	void method_3()
	{
		base._JHfBnmyItvKJDQtdUPp2yLsm4yR();
	}

	void method_4()
	{
		base._oHE0dGUBNplXQia6K85vMaNc8jp();
	}

	void method_5()
	{
		base._paoLItUYkFWaGSDnCAvBagJ1F5T();
	}

	void method_6(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static TimeSpan smethod_11(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	void method_7(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		base._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, skeletonMeshRenderer_0);
	}

	static void smethod_12(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}

	static void smethod_13(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.End();
	}

	void method_8(_qokIrmaaT3Lq6znW10HdrPUO9Fq _qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool bool_0)
	{
		base._eXH4tq2J0DADXDLofA8G8Yw8fau(_qokIrmaaT3Lq6znW10HdrPUO9Fq_0, bool_0);
	}
}
