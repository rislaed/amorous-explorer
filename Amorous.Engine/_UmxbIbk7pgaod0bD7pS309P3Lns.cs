using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

public class _UmxbIbk7pgaod0bD7pS309P3Lns : _RlrsL89bialFQa9mzWurgsdr6FK<float>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _N94aLVGUDYCfmJQohqS7o05wjPB
	{
		public static readonly _N94aLVGUDYCfmJQohqS7o05wjPB _003C_003E9 = new _N94aLVGUDYCfmJQohqS7o05wjPB();

		public static Func<string, int> _003C_003E9__10_0;

		internal int _6VTY1QgG5nNEBJE6zmVBbO3BB2L(string string_0)
		{
			return _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G();
		}
	}

	private readonly ContentManager _7FoDc5IeOhkrJIekU2AAQQKZqefA;

	private static _UmxbIbk7pgaod0bD7pS309P3Lns _6T55wit7MiGfAWRkPwjNbJ8N8lG;

	private string _wx0H9mDGCmUNsmV59Nj48JPJkEc;

	private string[] _eT7BaYRygkyX4kj8h6aEwrq2uN;

	private int _bTbQqsABbUefrkPeEqkxzxUsr8F;

	private bool _avz8WSjNjL0U8mdfRNAb5mHaApV;

	public _UmxbIbk7pgaod0bD7pS309P3Lns(ContentManager contentManager_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG = this;
		_7FoDc5IeOhkrJIekU2AAQQKZqefA = contentManager_0;
		_eT7BaYRygkyX4kj8h6aEwrq2uN = new string[0];
		_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_1((EventHandler<EventArgs>)delegate
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if ((int)_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_8() == 0 && _eT7BaYRygkyX4kj8h6aEwrq2uN.Length > 1)
			{
				_bTbQqsABbUefrkPeEqkxzxUsr8F++;
				if (_bTbQqsABbUefrkPeEqkxzxUsr8F >= _eT7BaYRygkyX4kj8h6aEwrq2uN.Length)
				{
					if (!_avz8WSjNjL0U8mdfRNAb5mHaApV)
					{
						return;
					}
					_bTbQqsABbUefrkPeEqkxzxUsr8F = 0;
				}
				_wx0H9mDGCmUNsmV59Nj48JPJkEc = _eT7BaYRygkyX4kj8h6aEwrq2uN[_bTbQqsABbUefrkPeEqkxzxUsr8F];
				Song song_ = _7FoDc5IeOhkrJIekU2AAQQKZqefA.Load<Song>(_wx0H9mDGCmUNsmV59Nj48JPJkEc);
				_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_5(song_);
			}
		});
	}

	protected override float _Gs9QTlqmpM6Jpgrjf53LUcRTbM(float float_0, float float_1, float float_2)
	{
		return _UmxbIbk7pgaod0bD7pS309P3Lns.smethod_2(float_0, float_1, float_2);
	}

	public void _LcX2y4hMIzQST4uGT2Q5Ce7vaGg()
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_3(_eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._DF24JUrPFA6rJ2cQrOTlpC3I4FF * _eJWqL2MhFZHNHP960nsWLJJmyPD._Hnb6mPvrZFgOMCIApIeMW88jSsF._7NidKjx61ui5CP7JojwfqxH4aKC * base._SWODlbUkQEqfwrtprjLPOeGF7HO);
	}

	public void _nqn4Aw4hEsNL81QdtrDK2OwS6Kr(string string_0, float float_0, bool bool_0)
	{
		if (_eT7BaYRygkyX4kj8h6aEwrq2uN.Length != 1 || !_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_4(string_0, _wx0H9mDGCmUNsmV59Nj48JPJkEc))
		{
			_eT7BaYRygkyX4kj8h6aEwrq2uN = new string[1] { string_0 };
			_wx0H9mDGCmUNsmV59Nj48JPJkEc = string_0;
			_bTbQqsABbUefrkPeEqkxzxUsr8F = 0;
			_avz8WSjNjL0U8mdfRNAb5mHaApV = bool_0;
			Song song_ = _7FoDc5IeOhkrJIekU2AAQQKZqefA.Load<Song>(_wx0H9mDGCmUNsmV59Nj48JPJkEc);
			_98dbKZq4dvkw2wLkjZ77Y5Ih4xP(float_0);
			_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_5(song_);
			_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_6(bool_0);
		}
	}

	public void _nqn4Aw4hEsNL81QdtrDK2OwS6Kr(string[] string_0, float float_0, bool bool_0, bool bool_1)
	{
		if (string_0.Length == 0 || (string_0.Length == _eT7BaYRygkyX4kj8h6aEwrq2uN.Length && ((IEnumerable<string>)_eT7BaYRygkyX4kj8h6aEwrq2uN).All((Func<string, bool>)((IEnumerable<string>)string_0).Contains)))
		{
			return;
		}
		if (bool_1)
		{
			_eT7BaYRygkyX4kj8h6aEwrq2uN = string_0.OrderBy((string string_0) => _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G()).ToArray();
		}
		else
		{
			_eT7BaYRygkyX4kj8h6aEwrq2uN = string_0;
		}
		_wx0H9mDGCmUNsmV59Nj48JPJkEc = string_0[0];
		_bTbQqsABbUefrkPeEqkxzxUsr8F = 0;
		_avz8WSjNjL0U8mdfRNAb5mHaApV = bool_0;
		Song song_ = _7FoDc5IeOhkrJIekU2AAQQKZqefA.Load<Song>(_wx0H9mDGCmUNsmV59Nj48JPJkEc);
		_98dbKZq4dvkw2wLkjZ77Y5Ih4xP(float_0);
		_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_5(song_);
		_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_6(bool_0: false);
	}

	public static void _QrgbXEg7MMeD9Ybz12fFVsbmAd9(string string_0, float float_0, bool bool_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._nqn4Aw4hEsNL81QdtrDK2OwS6Kr(string_0, float_0, bool_0: false);
	}

	public static void _QrgbXEg7MMeD9Ybz12fFVsbmAd9(string[] string_0, float float_0, bool bool_0, bool bool_1)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._nqn4Aw4hEsNL81QdtrDK2OwS6Kr(string_0, float_0, bool_0, bool_1);
	}

	public static void _h0KfaNiikKlJV2KkRPIdVDKVJnC()
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._eT7BaYRygkyX4kj8h6aEwrq2uN = new string[0];
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._wx0H9mDGCmUNsmV59Nj48JPJkEc = null;
		_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_7();
	}

	public static void _l94kUraQ13OohoVwwxKC37hG7Pc(string string_0, float float_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._nqn4Aw4hEsNL81QdtrDK2OwS6Kr(string_0, float_0, bool_0: true);
	}

	public static void _PYAXEqRAOkDRRNqm1k71R7GJTJK(Action action_0 = null)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._9JRBBOsuQbaGxb3DQypwWYtojV0(0f, action_0);
	}

	public static void _FegL010tc92iskjjyD0T33dDwNE(Action action_0 = null)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._9JRBBOsuQbaGxb3DQypwWYtojV0(1f, action_0);
	}

	public static void _7d2DAwjp6FutkJY09U0Mlk43Nmn(float float_0, Action action_0 = null)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._9JRBBOsuQbaGxb3DQypwWYtojV0(float_0, action_0);
	}

	public static void _E7yBM68AWt7OGHJ5D6xYA8RK8tAA(float float_0)
	{
		_6T55wit7MiGfAWRkPwjNbJ8N8lG._98dbKZq4dvkw2wLkjZ77Y5Ih4xP(float_0);
	}

	[CompilerGenerated]
	private void _fI217APzl4Tapt53WowQWN9Ipyi(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if ((int)_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_8() != 0 || _eT7BaYRygkyX4kj8h6aEwrq2uN.Length <= 1)
		{
			return;
		}
		_bTbQqsABbUefrkPeEqkxzxUsr8F++;
		if (_bTbQqsABbUefrkPeEqkxzxUsr8F >= _eT7BaYRygkyX4kj8h6aEwrq2uN.Length)
		{
			if (!_avz8WSjNjL0U8mdfRNAb5mHaApV)
			{
				return;
			}
			_bTbQqsABbUefrkPeEqkxzxUsr8F = 0;
		}
		_wx0H9mDGCmUNsmV59Nj48JPJkEc = _eT7BaYRygkyX4kj8h6aEwrq2uN[_bTbQqsABbUefrkPeEqkxzxUsr8F];
		Song song_ = _7FoDc5IeOhkrJIekU2AAQQKZqefA.Load<Song>(_wx0H9mDGCmUNsmV59Nj48JPJkEc);
		_UmxbIbk7pgaod0bD7pS309P3Lns.smethod_5(song_);
	}

	static void smethod_1(EventHandler<EventArgs> eventHandler_0)
	{
		MediaPlayer.add_ActiveSongChanged(eventHandler_0);
	}

	static float smethod_2(float float_0, float float_1, float float_2)
	{
		return MathHelper.Lerp(float_0, float_1, float_2);
	}

	static void smethod_3(float float_0)
	{
		MediaPlayer.set_Volume(float_0);
	}

	static bool smethod_4(string string_0, string string_1)
	{
		return string_0.Equals(string_1);
	}

	static void smethod_5(Song song_0)
	{
		MediaPlayer.Play(song_0);
	}

	static void smethod_6(bool bool_0)
	{
		MediaPlayer.set_IsRepeating(bool_0);
	}

	static void smethod_7()
	{
		MediaPlayer.Stop();
	}

	static MediaState smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return MediaPlayer.get_State();
	}
}