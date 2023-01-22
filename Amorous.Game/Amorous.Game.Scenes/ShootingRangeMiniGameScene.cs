using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Spine;

namespace Amorous.Game.Scenes;

public abstract class ShootingRangeMiniGameScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private enum GameState
	{
		None,
		NotStarted,
		Started,
		GameOver
	}

	private class FrameAnimation : IDrawable
	{
		private readonly Texture2D _uZYA4qnOfbVDFtZ6Ih3HawZgErP;

		private Rectangle _NbYrjABARmnikNXQHmmbM8k62UE;

		private Rectangle _jqsWTJ89RIZpjBr65dNZzmpJJKE;

		private readonly Vector2 _QBwNjQE21bfJ9yRo7CynjeYaHRg;

		private readonly float _q2YaOk0V93J3GMeWTOtcGdh9kEA;

		private readonly int _hUTZltYwRfIdEri4M059hyQus5H;

		private int _Lb7cMVSwXw3dYaQEnyADfQZoUedb;

		private float _MZBGPP8CHYYeh1lAhvANLxmu8KVA;

		private float _Q7Kx7ErHf3u1QIUDKfFCKSXbznG;

		public bool _aeQckZZROopp0BqagEZE32fzkyr { get; private set; }

		public FrameAnimation(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, float float_0, int int_0, int int_1, int int_2, float float_1)
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			_uZYA4qnOfbVDFtZ6Ih3HawZgErP = FrameAnimation.smethod_1(FrameAnimation.smethod_0(_7UlnfykmEmZDFt3BmCKZekI43Ih_0)).Load<Texture2D>(string_0);
			_q2YaOk0V93J3GMeWTOtcGdh9kEA = float_0 / (float)int_0;
			_hUTZltYwRfIdEri4M059hyQus5H = int_0;
			_Lb7cMVSwXw3dYaQEnyADfQZoUedb = 0;
			_jqsWTJ89RIZpjBr65dNZzmpJJKE = new Rectangle(0, 0, (int)((float)FrameAnimation.smethod_2(_uZYA4qnOfbVDFtZ6Ih3HawZgErP) / 12f), FrameAnimation.smethod_3(_uZYA4qnOfbVDFtZ6Ih3HawZgErP));
			_NbYrjABARmnikNXQHmmbM8k62UE = new Rectangle(0, 0, (int)((float)_jqsWTJ89RIZpjBr65dNZzmpJJKE.Width * float_1), (int)((float)_jqsWTJ89RIZpjBr65dNZzmpJJKE.Height * float_1));
			_QBwNjQE21bfJ9yRo7CynjeYaHRg = new Vector2((float)int_1, (float)int_2);
		}

		public void _QrgbXEg7MMeD9Ybz12fFVsbmAd9(int int_0, int int_1, float float_0)
		{
			_NbYrjABARmnikNXQHmmbM8k62UE.X = int_0;
			_NbYrjABARmnikNXQHmmbM8k62UE.Y = int_1;
			_MZBGPP8CHYYeh1lAhvANLxmu8KVA = FrameAnimation.smethod_4(float_0);
		}

		public void _tiBFUHPEkedkbgvuX3whdeyjhKo(float float_0)
		{
			if (_Lb7cMVSwXw3dYaQEnyADfQZoUedb >= 0)
			{
				_Q7Kx7ErHf3u1QIUDKfFCKSXbznG += float_0;
				while (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG > _q2YaOk0V93J3GMeWTOtcGdh9kEA)
				{
					_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= _q2YaOk0V93J3GMeWTOtcGdh9kEA;
					_Lb7cMVSwXw3dYaQEnyADfQZoUedb++;
				}
				if (_Lb7cMVSwXw3dYaQEnyADfQZoUedb < _hUTZltYwRfIdEri4M059hyQus5H)
				{
					_jqsWTJ89RIZpjBr65dNZzmpJJKE.X = _Lb7cMVSwXw3dYaQEnyADfQZoUedb * _jqsWTJ89RIZpjBr65dNZzmpJJKE.Width;
				}
				else
				{
					_ymyneWF6dfrtfUI08wyb3KExq0D();
				}
			}
		}

		public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (_Lb7cMVSwXw3dYaQEnyADfQZoUedb >= 0)
			{
				FrameAnimation.smethod_5(spriteBatch_0, _uZYA4qnOfbVDFtZ6Ih3HawZgErP, _NbYrjABARmnikNXQHmmbM8k62UE, (Rectangle?)_jqsWTJ89RIZpjBr65dNZzmpJJKE, Color.get_White(), _MZBGPP8CHYYeh1lAhvANLxmu8KVA, _QBwNjQE21bfJ9yRo7CynjeYaHRg, (SpriteEffects)0, 0f);
			}
		}

		public void _ymyneWF6dfrtfUI08wyb3KExq0D()
		{
			_Lb7cMVSwXw3dYaQEnyADfQZoUedb = -1;
			_aeQckZZROopp0BqagEZE32fzkyr = true;
		}

		static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_0(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
		{
			return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
		}

		static ContentManager smethod_1(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
		}

		static int smethod_2(Texture2D texture2D_0)
		{
			return texture2D_0.get_Width();
		}

		static int smethod_3(Texture2D texture2D_0)
		{
			return texture2D_0.get_Height();
		}

		static float smethod_4(float float_0)
		{
			return MathHelper.ToRadians(float_0);
		}

		static void smethod_5(SpriteBatch spriteBatch_0, Texture2D texture2D_0, Rectangle rectangle_0, Rectangle? nullable_0, Color color_0, float float_0, Vector2 vector2_0, SpriteEffects spriteEffects_0, float float_1)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			spriteBatch_0.Draw(texture2D_0, rectangle_0, nullable_0, color_0, float_0, vector2_0, spriteEffects_0, float_1);
		}
	}

	private class TargetModel : _WBXNT6eIVGk6ZKExRBJ6JxXE6zb
	{
		public enum CollisionType
		{
			None,
			Headshot,
			Bodyshot
		}

		private static Point _4mLyheZBE5398noM999P10uPXyj = new Point(257, 503);

		private static Point _I906IAlfLiodaJFNAL8BXp1P47T = new Point(128, 100);

		private static int _lhuXZkj0cs1oFnjnnY7TNYVWPXe = 64;

		private float _i8C0PwO83NRzGvNoyMhHwLV9HeC;

		private float _JZPZVzDxWQJJNyrQBsinax9LDSh;

		private float _gQiTjWdk9KSBoYLFXR1ELHlQDTk;

		private Point _F61ut0AEUAE7JfCltwE9RXP3TK;

		private Point _OVCuLPSRFKMV6JuYrGeZ5uMUJTC;

		private int _XD9uURBVAJTsK2DKyuCockNh07A;

		private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _pO4d7wyWlp6cYLHahUVYplpUWxw;

		public bool _kf3EbE0B70xGe1szklqAZyCqoLj { get; set; }

		public new float _fO7gSlrDDNMoHR4FO5QXAq8fUyA => _i8C0PwO83NRzGvNoyMhHwLV9HeC;

		public TargetModel(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, int int_0, int int_1, float float_0 = 1f)
			: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, "Target")
		{
			TargetModel.smethod_0((_fAUddQEKfZyemRb327NhM3GGlmzA)this, (Action<GameTime>)delegate(GameTime gameTime_0)
			{
				TargetModel.smethod_9(_pO4d7wyWlp6cYLHahUVYplpUWxw, gameTime_0, 1000f);
			});
			TargetModel.smethod_1((_WBXNT6eIVGk6ZKExRBJ6JxXE6zb)this, (Action<SpriteBatch, SkeletonMeshRenderer>)delegate(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
			{
				TargetModel.smethod_10(_pO4d7wyWlp6cYLHahUVYplpUWxw, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)null, (Color?)null, _i8C0PwO83NRzGvNoyMhHwLV9HeC);
			});
			_pO4d7wyWlp6cYLHahUVYplpUWxw = TargetModel.smethod_4(TargetModel.smethod_3(TargetModel.smethod_2(_7UlnfykmEmZDFt3BmCKZekI43Ih_0)), "Assets/Scenes/ShootingRange/Target", 1f, bool_0: true, (List<SpineEvent>)null);
			_q83Vj1dGmn3NFhPIkk7tO7tyxb(int_0, int_1, float_0);
		}

		private void _q83Vj1dGmn3NFhPIkk7tO7tyxb(int int_0, int int_1, float? nullable_0)
		{
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			TargetModel.smethod_5(_pO4d7wyWlp6cYLHahUVYplpUWxw, (float)int_0);
			TargetModel.smethod_6(_pO4d7wyWlp6cYLHahUVYplpUWxw, (float)int_1);
			_i8C0PwO83NRzGvNoyMhHwLV9HeC = nullable_0 ?? _i8C0PwO83NRzGvNoyMhHwLV9HeC;
			_JZPZVzDxWQJJNyrQBsinax9LDSh = (float)int_0 - (float)_4mLyheZBE5398noM999P10uPXyj.X / 2f * _i8C0PwO83NRzGvNoyMhHwLV9HeC;
			_gQiTjWdk9KSBoYLFXR1ELHlQDTk = (float)int_1 - (float)_4mLyheZBE5398noM999P10uPXyj.Y * _i8C0PwO83NRzGvNoyMhHwLV9HeC;
			_F61ut0AEUAE7JfCltwE9RXP3TK = new Point((int)((float)_4mLyheZBE5398noM999P10uPXyj.X * _i8C0PwO83NRzGvNoyMhHwLV9HeC), (int)((float)_4mLyheZBE5398noM999P10uPXyj.Y * _i8C0PwO83NRzGvNoyMhHwLV9HeC));
			_OVCuLPSRFKMV6JuYrGeZ5uMUJTC = new Point((int)((float)_I906IAlfLiodaJFNAL8BXp1P47T.X * _i8C0PwO83NRzGvNoyMhHwLV9HeC), (int)((float)_I906IAlfLiodaJFNAL8BXp1P47T.Y * _i8C0PwO83NRzGvNoyMhHwLV9HeC));
			_XD9uURBVAJTsK2DKyuCockNh07A = (int)((float)_lhuXZkj0cs1oFnjnnY7TNYVWPXe * _i8C0PwO83NRzGvNoyMhHwLV9HeC);
		}

		public void _edcakvTOp2fd2J9ZHAu9GKjDaN7(Action action_0 = null)
		{
			TargetModel.smethod_7(_pO4d7wyWlp6cYLHahUVYplpUWxw, "Rise", action_0);
		}

		public void _DcBCpcEfsjl4zP1zbrOrd1bwNReb(Action action_0 = null)
		{
			TargetModel.smethod_7(_pO4d7wyWlp6cYLHahUVYplpUWxw, "Headshot", action_0);
		}

		public void _u1yq8F9lG8oMcA9vZO9c7Qbh8vj(Action action_0 = null)
		{
			TargetModel.smethod_7(_pO4d7wyWlp6cYLHahUVYplpUWxw, "Bodyshot", action_0);
		}

		public bool _ZCfNJ0nxXx3YppgLl5SvS2LkQ5B(Point point_0, out CollisionType collisionType_0)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			collisionType_0 = CollisionType.None;
			if (!_kf3EbE0B70xGe1szklqAZyCqoLj)
			{
				return false;
			}
			if ((float)point_0.X >= _JZPZVzDxWQJJNyrQBsinax9LDSh && (float)point_0.X <= _JZPZVzDxWQJJNyrQBsinax9LDSh + (float)_F61ut0AEUAE7JfCltwE9RXP3TK.X && (float)point_0.Y >= _gQiTjWdk9KSBoYLFXR1ELHlQDTk && (float)point_0.Y <= _gQiTjWdk9KSBoYLFXR1ELHlQDTk + (float)_F61ut0AEUAE7JfCltwE9RXP3TK.Y)
			{
				if ((float)point_0.Y >= _gQiTjWdk9KSBoYLFXR1ELHlQDTk + (float)_OVCuLPSRFKMV6JuYrGeZ5uMUJTC.Y + (float)_XD9uURBVAJTsK2DKyuCockNh07A)
				{
					collisionType_0 = CollisionType.Bodyshot;
					return true;
				}
				float num = (float)point_0.X - (_JZPZVzDxWQJJNyrQBsinax9LDSh + (float)_OVCuLPSRFKMV6JuYrGeZ5uMUJTC.X);
				float num2 = (float)point_0.Y - (_gQiTjWdk9KSBoYLFXR1ELHlQDTk + (float)_OVCuLPSRFKMV6JuYrGeZ5uMUJTC.Y);
				double num3 = TargetModel.smethod_8((double)(num * num + num2 * num2));
				if (num3 <= (double)_XD9uURBVAJTsK2DKyuCockNh07A)
				{
					collisionType_0 = CollisionType.Headshot;
					return true;
				}
			}
			return false;
		}

		[CompilerGenerated]
		private void _ADJjrAI33HndiXqXJrA3qKsIyrF(GameTime gameTime_0)
		{
			TargetModel.smethod_9(_pO4d7wyWlp6cYLHahUVYplpUWxw, gameTime_0, 1000f);
		}

		[CompilerGenerated]
		private void _AmJLsnuDUqeR9shOixvB2LU01QD(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
		{
			TargetModel.smethod_10(_pO4d7wyWlp6cYLHahUVYplpUWxw, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)null, (Color?)null, _i8C0PwO83NRzGvNoyMhHwLV9HeC);
		}

		static void smethod_0(_fAUddQEKfZyemRb327NhM3GGlmzA _fAUddQEKfZyemRb327NhM3GGlmzA_0, Action<GameTime> action_0)
		{
			_fAUddQEKfZyemRb327NhM3GGlmzA_0._NC5P3SKqKPpcAYG1mqquUEcUzTg = action_0;
		}

		static void smethod_1(_WBXNT6eIVGk6ZKExRBJ6JxXE6zb _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0, Action<SpriteBatch, SkeletonMeshRenderer> action_0)
		{
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0._Wb2e00OWt8kBwGWEXtOGMVScRPm = action_0;
		}

		static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_2(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
		{
			return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
		}

		static ContentManager smethod_3(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
		}

		static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_4(ContentManager contentManager_0, string string_0, float float_0, bool bool_0, List<SpineEvent> list_0)
		{
			return contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni(string_0, float_0, bool_0, list_0);
		}

		static void smethod_5(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
		}

		static void smethod_6(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
		}

		static void smethod_7(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action action_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._SPUoP3ABwpgQinJfKUM5qBbYSvr(string_0, action_0);
		}

		static double smethod_8(double double_0)
		{
			return Math.Sqrt(double_0);
		}

		static void smethod_9(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, GameTime gameTime_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, float_0);
		}

		static void smethod_10(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Texture2D texture2D_0, Func<int, string, bool> func_0, Color? nullable_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, texture2D_0, func_0, nullable_0, float_0);
		}
	}

	private class GunModel : _WBXNT6eIVGk6ZKExRBJ6JxXE6zb
	{
		private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _XcQKV7iP9Sk10poAFYuakLJaltL;

		public new float _7Xn1C5tjYnmIif1iZKV8AWsEEbL
		{
			set
			{
				GunModel.smethod_0(_XcQKV7iP9Sk10poAFYuakLJaltL, value);
			}
		}

		public new float _bCjZ3VSXGKyhmykd2zCnQBiSpDf
		{
			set
			{
				GunModel.smethod_1(_XcQKV7iP9Sk10poAFYuakLJaltL, value);
			}
		}

		public bool _PXBbI2AED2MyzkuXicgwalICf26
		{
			set
			{
				GunModel.smethod_2(_XcQKV7iP9Sk10poAFYuakLJaltL, value);
			}
		}

		public GunModel(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
			: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, "GunModel")
		{
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0304: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Unknown result type (might be due to invalid IL or missing references)
			//IL_0451: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_052e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0561: Unknown result type (might be due to invalid IL or missing references)
			//IL_0594: Unknown result type (might be due to invalid IL or missing references)
			GunModel.smethod_3((_fAUddQEKfZyemRb327NhM3GGlmzA)this, (Action<GameTime>)delegate(GameTime gameTime_0)
			{
				GunModel.smethod_24(_XcQKV7iP9Sk10poAFYuakLJaltL, gameTime_0, 1000f);
			});
			GunModel.smethod_4((_WBXNT6eIVGk6ZKExRBJ6JxXE6zb)this, (Action<SpriteBatch, SkeletonMeshRenderer>)delegate(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
			{
				GunModel.smethod_25(_XcQKV7iP9Sk10poAFYuakLJaltL, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)null, (Color?)null, _fO7gSlrDDNMoHR4FO5QXAq8fUyA);
			});
			_XcQKV7iP9Sk10poAFYuakLJaltL = GunModel.smethod_7(GunModel.smethod_6(GunModel.smethod_5(_7UlnfykmEmZDFt3BmCKZekI43Ih_0)), "Assets/GUI/Phone/Phone", 1f, bool_0: true, (List<SpineEvent>)null);
			GunModel.smethod_8(_XcQKV7iP9Sk10poAFYuakLJaltL, "Arm rise", 0f);
			GunModel.smethod_9(_XcQKV7iP9Sk10poAFYuakLJaltL, 0f);
			GunModel.smethod_0(_XcQKV7iP9Sk10poAFYuakLJaltL, 0f);
			GunModel.smethod_1(_XcQKV7iP9Sk10poAFYuakLJaltL, 1080f);
			_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = GunModel.smethod_10();
			bool flag = GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongForearm);
			bool flag2;
			Color color_ = ((flag2 = GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortForearm)) ? GunModel.smethod_14(opIJo2jLUqdOL5yAFP4yzXce0DG_) : (flag ? GunModel.smethod_13(opIJo2jLUqdOL5yAFP4yzXce0DG_) : Color.get_White()));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Hoody Sleeve", 0f);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Default Forearm", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Default Forearm", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Marking Forearm", (float)((flag2 || flag) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Marking Forearm", color_);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Striped forearm", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Striped forearm", GunModel.smethod_18(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Forearm", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Forearm", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Hand", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Hand", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Marking Hand", (float)((flag2 || flag) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Marking Hand", color_);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Hand", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Hand", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Index", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Index", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian index", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian index", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Pinky", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Pinky", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Pinky", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Pinky", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Ring", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Ring", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian ring", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian ring", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Rude", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Rude", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Rude", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Rude", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Thumb", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Thumb", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Thumb", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Thumb", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Pinky Nail", (float)(GunModel.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Pinky Nail", GunModel.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Ring Nail", (float)(GunModel.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Ring Nail", GunModel.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Rude Nail", (float)(GunModel.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Rude Nail", GunModel.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Index Nail", (float)(GunModel.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Index Nail", GunModel.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Thumb Nail", (float)(GunModel.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Thumb Nail", GunModel.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Muzzle flash", 1f);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun casing", 1f);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun", 1f);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun Slide", 1f);
		}

		public void _edcakvTOp2fd2J9ZHAu9GKjDaN7(Action action_0 = null)
		{
			GunModel.smethod_22(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun rise", (Action)delegate
			{
				_3AjdlsblH9b6FNnDEW7N5sQ8iHs();
				action_0?.Invoke();
			});
		}

		private void _3AjdlsblH9b6FNnDEW7N5sQ8iHs()
		{
			GunModel.smethod_23(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun Idle", (Action<int>)null);
		}

		public void _e2DHCcfpFNWn5NTzMOw3FBUkwzA()
		{
			GunModel.smethod_22(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun Shoot", (Action)_3AjdlsblH9b6FNnDEW7N5sQ8iHs);
		}

		public void _hAt3H7isKECkVrQjY4L0hESiqLF(Action action_0 = null)
		{
			GunModel.smethod_22(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun reload", (Action)delegate
			{
				_3AjdlsblH9b6FNnDEW7N5sQ8iHs();
				action_0?.Invoke();
			});
		}

		[CompilerGenerated]
		private void _YuaJOFbc3gfp6WZmpnuifHMF9Dh(GameTime gameTime_0)
		{
			GunModel.smethod_24(_XcQKV7iP9Sk10poAFYuakLJaltL, gameTime_0, 1000f);
		}

		[CompilerGenerated]
		private void _0nszBRri8HVNLjGllZgWohYuaOP(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
		{
			GunModel.smethod_25(_XcQKV7iP9Sk10poAFYuakLJaltL, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)null, (Color?)null, _fO7gSlrDDNMoHR4FO5QXAq8fUyA);
		}

		static void smethod_0(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
		}

		static void smethod_1(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
		}

		static void smethod_2(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, bool bool_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._Hwt6L2NJfXmAfG6UOH8NVlNfGCR = bool_0;
		}

		static void smethod_3(_fAUddQEKfZyemRb327NhM3GGlmzA _fAUddQEKfZyemRb327NhM3GGlmzA_0, Action<GameTime> action_0)
		{
			_fAUddQEKfZyemRb327NhM3GGlmzA_0._NC5P3SKqKPpcAYG1mqquUEcUzTg = action_0;
		}

		static void smethod_4(_WBXNT6eIVGk6ZKExRBJ6JxXE6zb _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0, Action<SpriteBatch, SkeletonMeshRenderer> action_0)
		{
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0._Wb2e00OWt8kBwGWEXtOGMVScRPm = action_0;
		}

		static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_5(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
		{
			return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
		}

		static ContentManager smethod_6(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
		}

		static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_7(ContentManager contentManager_0, string string_0, float float_0, bool bool_0, List<SpineEvent> list_0)
		{
			return contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni(string_0, float_0, bool_0, list_0);
		}

		static void smethod_8(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._WPy6ICx3LVoejBaexyOoKGnX9jD(string_0, float_0);
		}

		static void smethod_9(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float_0);
		}

		static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_10()
		{
			return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		}

		static _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U smethod_11(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY;
		}

		static bool smethod_12(Enum enum_0, Enum enum_1)
		{
			return enum_0.HasFlag(enum_1);
		}

		static Color smethod_13(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._1ZKGQXLRAHEJR8v7jhlDsyOVLcz;
		}

		static Color smethod_14(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8rDSn6e9Ip9WdOogjhIn8YlL1oM;
		}

		static void smethod_15(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._aAoZaDNczeScsMfLlGSfAzey9SQ(string_0, float_0);
		}

		static Color smethod_16(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
		}

		static void smethod_17(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Color color_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_0, color_0);
		}

		static Color smethod_18(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
		}

		static Color smethod_19(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._FrsyMDX7TebzFk8nSLTyRDPi1QH;
		}

		static bool smethod_20(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._VmNLhqrIwSnE6JnCYiBcxnSqnEV;
		}

		static Color smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._in5HHYmrdLTFpkgc8aimJpXqAXB;
		}

		static void smethod_22(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action action_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._SPUoP3ABwpgQinJfKUM5qBbYSvr(string_0, action_0);
		}

		static void smethod_23(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
		}

		static void smethod_24(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, GameTime gameTime_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, float_0);
		}

		static void smethod_25(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Texture2D texture2D_0, Func<int, string, bool> func_0, Color? nullable_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, texture2D_0, func_0, nullable_0, float_0);
		}
	}

	private interface IDrawable
	{
		bool _aeQckZZROopp0BqagEZE32fzkyr { get; }

		void _tiBFUHPEkedkbgvuX3whdeyjhKo(float float_0);

		void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0);

		void _ymyneWF6dfrtfUI08wyb3KExq0D();
	}

	private class FloatingFeedbackDrawable : IDrawable
	{
		private const float _HS0I0EgJMjmRXhZ0KDhLBBA2VkE = 0.8f;

		private const float _YBMjlnwxHIEUKERmDSGIKOlw2aM = 100f;

		private readonly SpriteFont _xnYepZuegigJCU2jcbZsfVIakzF;

		private readonly float _nD28BmrDaEzCHelTAa14TKyuSyG;

		private float _LkckKdvuh9GaAwn7XojfbJBd91r;

		private readonly string _eNqfeKhXj4x1FkHQitvzRQ1JLSE;

		private readonly Color _JbGNnZhaeWyNm0aWm7TtSamww4C;

		private float _AQwQu1ldCtpbkD5F9oEByJdCnWaA;

		public bool _aeQckZZROopp0BqagEZE32fzkyr { get; private set; }

		public FloatingFeedbackDrawable(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, int int_0, int int_1, string string_0, Color color_0)
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			_xnYepZuegigJCU2jcbZsfVIakzF = FloatingFeedbackDrawable.smethod_1(FloatingFeedbackDrawable.smethod_0(_7UlnfykmEmZDFt3BmCKZekI43Ih_0)).Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
			_nD28BmrDaEzCHelTAa14TKyuSyG = int_0;
			_LkckKdvuh9GaAwn7XojfbJBd91r = int_1;
			_eNqfeKhXj4x1FkHQitvzRQ1JLSE = string_0;
			_JbGNnZhaeWyNm0aWm7TtSamww4C = color_0;
			_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 1f;
		}

		public void _tiBFUHPEkedkbgvuX3whdeyjhKo(float float_0)
		{
			if (!_aeQckZZROopp0BqagEZE32fzkyr)
			{
				_AQwQu1ldCtpbkD5F9oEByJdCnWaA -= 0.8f * float_0;
				if (_AQwQu1ldCtpbkD5F9oEByJdCnWaA <= 0f)
				{
					_aeQckZZROopp0BqagEZE32fzkyr = true;
				}
				else
				{
					_LkckKdvuh9GaAwn7XojfbJBd91r -= 100f * float_0;
				}
			}
		}

		public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			spriteBatch_0.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, _eNqfeKhXj4x1FkHQitvzRQ1JLSE, new Vector2(_nD28BmrDaEzCHelTAa14TKyuSyG, _LkckKdvuh9GaAwn7XojfbJBd91r), _JbGNnZhaeWyNm0aWm7TtSamww4C * _AQwQu1ldCtpbkD5F9oEByJdCnWaA);
		}

		public void _ymyneWF6dfrtfUI08wyb3KExq0D()
		{
		}

		static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_0(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
		{
			return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
		}

		static ContentManager smethod_1(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
		}
	}

	private class TimedDrawable : IDrawable
	{
		private float _3wk7bXUbhNqSQ9kMD9hieEubOhG;

		private readonly float _x2m0UxhUAD6cdIEszjrShiRmPfx;

		private readonly Action _jokchmUtu5NAXtJsjLfIUXz2XXP;

		public bool _aeQckZZROopp0BqagEZE32fzkyr { get; private set; }

		public TimedDrawable(float float_0, Action action_0)
		{
			_x2m0UxhUAD6cdIEszjrShiRmPfx = float_0;
			_jokchmUtu5NAXtJsjLfIUXz2XXP = action_0;
		}

		public void _tiBFUHPEkedkbgvuX3whdeyjhKo(float float_0)
		{
			if (!_aeQckZZROopp0BqagEZE32fzkyr)
			{
				_3wk7bXUbhNqSQ9kMD9hieEubOhG += float_0;
				if (_3wk7bXUbhNqSQ9kMD9hieEubOhG > _x2m0UxhUAD6cdIEszjrShiRmPfx)
				{
					_ymyneWF6dfrtfUI08wyb3KExq0D();
				}
			}
		}

		public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
		{
		}

		public void _ymyneWF6dfrtfUI08wyb3KExq0D()
		{
			_aeQckZZROopp0BqagEZE32fzkyr = true;
			_jokchmUtu5NAXtJsjLfIUXz2XXP?.Invoke();
		}
	}

	private class RailInfo
	{
		public readonly int _SjhHztt8d5kOtb7Z2BJKnZZxEKh;

		public readonly int _nVnyJkkce6HsdRrKSpRrzUDElg0;

		public readonly int _bCjZ3VSXGKyhmykd2zCnQBiSpDf;

		public readonly float _fO7gSlrDDNMoHR4FO5QXAq8fUyA;

		public readonly int _dPmC8tBC0iph2YBAFmztEsmwUdSA;

		public RailInfo(int int_0, int int_1, int int_2, float float_0, int int_3)
		{
			_SjhHztt8d5kOtb7Z2BJKnZZxEKh = int_0;
			_nVnyJkkce6HsdRrKSpRrzUDElg0 = int_1;
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_2;
			_fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
			_dPmC8tBC0iph2YBAFmztEsmwUdSA = int_3;
		}
	}

	private const int _WXnSCubyydx0vtwfr6EBSBJQ4NH = 0;

	private const int _eZgzZTxD4KGw9TAJWF36UIIrcJE = 1;

	private const int _Dh7DkqYx7ZsfJMMmwN9z46uqQUC = 2;

	private const int _kzJGd7GwiPrw5jq1fce3gSPDlid = 3;

	private const int _MF0mjT8MsvlaCSmH86jNrwPb8Qc = 4;

	private const int _ovABgEeBrYyMKzNKN45fWnoaNJw = 5;

	private const int _wzfl8zBPhdOVuG8akbisiVvuf3A = 6;

	private const int _nIbsE9m4hgh2WAJ3yKmgh39dDjc = 7;

	private const int _fa1AXPP2Dgoofe6mc2z35ZLjDEx = 8;

	private readonly RailInfo[] _HYME5rEMzi5Cag9e7DCXk5lrXwX = new RailInfo[4]
	{
		new RailInfo(710, 1210, 410, 0.3f, 1),
		new RailInfo(650, 1270, 575, 0.4f, 3),
		new RailInfo(270, 1650, 625, 0.6f, 4),
		new RailInfo(330, 1600, 770, 1f, 5)
	};

	private const float _rpuZ6CyEUKzAxwn4okIB41MYvfh = 90f;

	private const float _kaoNHt1lIV2yYLBYfdpVkoSJPXf = 3.5f;

	private const int _1pcAANk13CvJrSXUOZ3qhxtMDku = 6;

	private const string _9RACjV4WJk4KFrnXLYxI9sViikj = "Press <Space/R/Mouse-R> to Reload and begin.";

	private const string _U1HaVdhFZJNSjA4zQOBoTSRBtMl = "Time up, game over! Press <Enter> to retry or <Escape> to continue.";

	private readonly List<IDrawable> _xEG3axnWkco0Erk0PdjakXDULcA;

	private readonly List<IDrawable> _d9mstkVrU6KGDJyOtHGgrr2ZciA;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _vCjkdRWXT5mvEu0c22Hgh93luLg;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _ykeARom1bl7r01BeRXMOSqoJU6o;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _RiMZpLLSGIesSXF8vhSlVQ8SrDg;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _gabFSY9HcJdPu830plKx8W936qG;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _Hsn6Qz2oeKaTkin9XGwBJUJqy1C;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _Oeqego17TDqmByfLbOEB1isMXzJ;

	private readonly bool _WD4Plg5m1AwZ5mVyjQCADcW1ZTk;

	private readonly bool _U8eNAZVBW15ZflhG4fel0hK3Juu;

	private readonly GunModel _85WqOX8OcxbI6g74CaBZtHiHK2m;

	private List<TargetModel> _u8GaIYUzQ65BoFU3NzXBzyvujjbA;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _tvM0bxD4ITME03hjc6seyYclzxf;

	private Point _TcTPQp3KE5mO2mYA6sSQDbHnhAw;

	private readonly Color _AWLddj1Rm2sqiBwYcJDngG0QaQI;

	private readonly Texture2D _m1dNhD2jwJ6iTVUgUzMJUvnQFS;

	private readonly SpriteFont _6YCQhlMaqcDds8uGX1g8fjBKqV4A;

	private readonly SpriteFont _MnMUFBDfrGZBHvrJ30IAQilqivI;

	private bool _nHs33RHZMuYhYev0dQ6ic0aHmvO;

	private bool _eMnDHRem25x38ZqmbzZLc1CLkwlA;

	private int _JvgphfrWtBncPfgb6ERRVKKtlQG;

	private int _dH7hlTzeJboGa5rfpgerBfCmyKO;

	private int _C6cjmtLovCejw2N3OZYswcoYxsd;

	private int _pL6aoe4HLq4X3yQACLFyUH3xwBp;

	private TargetModel.CollisionType _0U2R42Dbf2ddmyfQBv0z7zBWwJm;

	private int _YFr89aAV3UzO9kf7kPKQJilRWED;

	private readonly float _YhybMVqCJnFekEXVbF1huXupDmh;

	private readonly float _MZh3nVRuDktDpIu8X149SF90ZjO;

	private int _M8VVMN3GHWWmFmORCACqNTXVh6b;

	private float _0zKXRrSXqoTAuTYQNrJIgtt7Emq;

	private int _G0GwJ5OWQOA4BjacW3XmFsyMFjz;

	private GameState _dxhbACq6BB89IAMy6ZOALWJgv7L;

	protected bool _F2ao1gdMb4UciyKC7Zly4by95Mn { get; set; }

	protected ShootingRangeMiniGameScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		_WD4Plg5m1AwZ5mVyjQCADcW1ZTk = ShootingRangeMiniGameScene.smethod_14(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
		ShootingRangeMiniGameScene.smethod_15(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, bool_0: false);
		_U8eNAZVBW15ZflhG4fel0hK3Juu = _poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj;
		_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
		ShootingRangeMiniGameScene.smethod_16();
		_vCjkdRWXT5mvEu0c22Hgh93luLg = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		ShootingRangeMiniGameScene.smethod_19(_vCjkdRWXT5mvEu0c22Hgh93luLg, new string[1] { "Assets/Sounds/MiniGames/ShootingRange/Fire" });
		_RiMZpLLSGIesSXF8vhSlVQ8SrDg = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		ShootingRangeMiniGameScene.smethod_19(_RiMZpLLSGIesSXF8vhSlVQ8SrDg, new string[1] { "Assets/Sounds/MiniGames/ShootingRange/Dry" });
		_ykeARom1bl7r01BeRXMOSqoJU6o = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		ShootingRangeMiniGameScene.smethod_19(_ykeARom1bl7r01BeRXMOSqoJU6o, new string[1] { "Assets/Sounds/MiniGames/ShootingRange/Reload" });
		_gabFSY9HcJdPu830plKx8W936qG = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		ShootingRangeMiniGameScene.smethod_19(_gabFSY9HcJdPu830plKx8W936qG, new string[2] { "Assets/Sounds/MiniGames/ShootingRange/Headshot 1", "Assets/Sounds/MiniGames/ShootingRange/Headshot 2" });
		_Hsn6Qz2oeKaTkin9XGwBJUJqy1C = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		ShootingRangeMiniGameScene.smethod_19(_Hsn6Qz2oeKaTkin9XGwBJUJqy1C, new string[3] { "Assets/Sounds/MiniGames/ShootingRange/Impact 1", "Assets/Sounds/MiniGames/ShootingRange/Impact 2", "Assets/Sounds/MiniGames/ShootingRange/Impact 3" });
		_Oeqego17TDqmByfLbOEB1isMXzJ = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		ShootingRangeMiniGameScene.smethod_19(_Oeqego17TDqmByfLbOEB1isMXzJ, new string[3] { "Assets/Sounds/MiniGames/ShootingRange/Ricochete 1", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 2", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 3" });
		_m1dNhD2jwJ6iTVUgUzMJUvnQFS = ShootingRangeMiniGameScene.smethod_17(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)).Load<Texture2D>("Assets/Scenes/ShootingRange/Bullet");
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Backdrop", "Assets/Scenes/ShootingRange/Backdrop", 600, 180), 0);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Background", "Assets/Scenes/ShootingRange/Background", 0, 0), 2);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Countertop", "Assets/Scenes/ShootingRange/Countertop", 0, 0), 6);
		_6YCQhlMaqcDds8uGX1g8fjBKqV4A = ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0).Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
		_MnMUFBDfrGZBHvrJ30IAQilqivI = ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0).Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		_AWLddj1Rm2sqiBwYcJDngG0QaQI = ShootingRangeMiniGameScene.smethod_22(ShootingRangeMiniGameScene.smethod_21());
		_tvM0bxD4ITME03hjc6seyYclzxf = _Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Crosshair", "Assets/Scenes/ShootingRange/Crosshair", 0, 0);
		_tvM0bxD4ITME03hjc6seyYclzxf._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = _AWLddj1Rm2sqiBwYcJDngG0QaQI;
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_tvM0bxD4ITME03hjc6seyYclzxf, 7);
		_85WqOX8OcxbI6g74CaBZtHiHK2m = new GunModel(this)
		{
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1820f,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1080f,
			_fO7gSlrDDNMoHR4FO5QXAq8fUyA = 0.5f,
			_PXBbI2AED2MyzkuXicgwalICf26 = true
		};
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_85WqOX8OcxbI6g74CaBZtHiHK2m, 8);
		_85WqOX8OcxbI6g74CaBZtHiHK2m._edcakvTOp2fd2J9ZHAu9GKjDaN7();
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA = new List<TargetModel>();
		_xEG3axnWkco0Erk0PdjakXDULcA = new List<IDrawable>();
		_d9mstkVrU6KGDJyOtHGgrr2ZciA = new List<IDrawable>();
		_YhybMVqCJnFekEXVbF1huXupDmh = ShootingRangeMiniGameScene.smethod_23(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Press <Space/R/Mouse-R> to Reload and begin.").X;
		_MZh3nVRuDktDpIu8X149SF90ZjO = ShootingRangeMiniGameScene.smethod_23(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Time up, game over! Press <Enter> to retry or <Escape> to continue.").X;
		_0zKXRrSXqoTAuTYQNrJIgtt7Emq = 90f;
		_M8VVMN3GHWWmFmORCACqNTXVh6b = 1;
		ShootingRangeMiniGameScene.smethod_24("Assets/Music/Mittsies - Mech", 0.4f);
		_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.NotStarted;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		float float_ = (float)ShootingRangeMiniGameScene.smethod_25(gameTime_0).Milliseconds / 1000f;
		if (_F2ao1gdMb4UciyKC7Zly4by95Mn && base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)27))
		{
			_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.None;
			_5Z9jaXDcRYm0wNlEm1aTutL9kSH();
		}
		if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq <= 60f)
		{
			if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq > 30f)
			{
				_M8VVMN3GHWWmFmORCACqNTXVh6b = 2;
			}
			else if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq > 0f)
			{
				_M8VVMN3GHWWmFmORCACqNTXVh6b = 4;
			}
		}
		else
		{
			_M8VVMN3GHWWmFmORCACqNTXVh6b = 1;
		}
		if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq <= 0f)
		{
			_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.GameOver;
			_jj3EwaVU5VqWdkXGZXsxWtQcYOv();
		}
		_TcTPQp3KE5mO2mYA6sSQDbHnhAw = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._2j5HjqIBNOwD2br7yBprKdzVhAK(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
		_tvM0bxD4ITME03hjc6seyYclzxf._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _TcTPQp3KE5mO2mYA6sSQDbHnhAw.X - 32;
		_tvM0bxD4ITME03hjc6seyYclzxf._bCjZ3VSXGKyhmykd2zCnQBiSpDf = _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y - 32;
		_85WqOX8OcxbI6g74CaBZtHiHK2m._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 780f + Math.Min(1f, (float)_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X / 1730f) * 1570f;
		_85WqOX8OcxbI6g74CaBZtHiHK2m._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1080f + Math.Min(1f, (float)_TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y / 950f) * 370f;
		_FCyUaxF0GIE1r2fyuYC4b4tGqpJ(float_);
		switch (_dxhbACq6BB89IAMy6ZOALWJgv7L)
		{
		case GameState.NotStarted:
			_fFSom2DrN3XLCdgmD5vZaJmWP7G(float_);
			break;
		case GameState.Started:
			_8GHK7o3vLmG6sThZNN5JsWHoKkE(float_);
			break;
		case GameState.GameOver:
			_g0eYquQ8BcifsIs5UMyAIkXM5paA(float_);
			break;
		}
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	private void _fFSom2DrN3XLCdgmD5vZaJmWP7G(float float_0)
	{
		if (!_eMnDHRem25x38ZqmbzZLc1CLkwlA && (ShootingRangeMiniGameScene.smethod_27(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton) || ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)82) || ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)32)))
		{
			_eMnDHRem25x38ZqmbzZLc1CLkwlA = true;
			_nHs33RHZMuYhYev0dQ6ic0aHmvO = true;
			ShootingRangeMiniGameScene.smethod_29(_ykeARom1bl7r01BeRXMOSqoJU6o, 1f);
			_85WqOX8OcxbI6g74CaBZtHiHK2m._hAt3H7isKECkVrQjY4L0hESiqLF(delegate
			{
				_YFr89aAV3UzO9kf7kPKQJilRWED = 6;
				_eMnDHRem25x38ZqmbzZLc1CLkwlA = false;
				_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
				_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.Started;
				_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
			});
		}
	}

	private void _8GHK7o3vLmG6sThZNN5JsWHoKkE(float float_0)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		_0zKXRrSXqoTAuTYQNrJIgtt7Emq -= float_0;
		if (!_eMnDHRem25x38ZqmbzZLc1CLkwlA && !_nHs33RHZMuYhYev0dQ6ic0aHmvO && ShootingRangeMiniGameScene.smethod_27(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
		{
			if (_YFr89aAV3UzO9kf7kPKQJilRWED != 0)
			{
				_YFr89aAV3UzO9kf7kPKQJilRWED--;
				_nHs33RHZMuYhYev0dQ6ic0aHmvO = true;
				_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0.5f, delegate
				{
					_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
				});
				_85WqOX8OcxbI6g74CaBZtHiHK2m._e2DHCcfpFNWn5NTzMOw3FBUkwzA();
				ShootingRangeMiniGameScene.smethod_29(_vCjkdRWXT5mvEu0c22Hgh93luLg, 1f);
				bool flag = false;
				foreach (TargetModel _OJbyketBmeLlVtChfay03TIx5KM in _u8GaIYUzQ65BoFU3NzXBzyvujjbA)
				{
					if (!_OJbyketBmeLlVtChfay03TIx5KM._ZCfNJ0nxXx3YppgLl5SvS2LkQ5B(_TcTPQp3KE5mO2mYA6sSQDbHnhAw, out _0U2R42Dbf2ddmyfQBv0z7zBWwJm))
					{
						continue;
					}
					_Vu9iV57zUVa3p8WMfOsDaoqv7wL(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, _OJbyketBmeLlVtChfay03TIx5KM._fO7gSlrDDNMoHR4FO5QXAq8fUyA);
					if (_0U2R42Dbf2ddmyfQBv0z7zBWwJm == TargetModel.CollisionType.Headshot)
					{
						_C6cjmtLovCejw2N3OZYswcoYxsd++;
						ShootingRangeMiniGameScene.smethod_29(_gabFSY9HcJdPu830plKx8W936qG, 1f);
						_G0GwJ5OWQOA4BjacW3XmFsyMFjz += 30;
						_xaBDiofMkYNdWQ4me0hnZ4NsCnk(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, "30!", Color.get_Yellow());
						_OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						_OJbyketBmeLlVtChfay03TIx5KM._DcBCpcEfsjl4zP1zbrOrd1bwNReb(delegate
						{
							_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, delegate
							{
								_PFrgvj2zYkmkbPmVfpiUnTvLsoC(_OJbyketBmeLlVtChfay03TIx5KM);
							});
						});
						_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
					}
					else if (_0U2R42Dbf2ddmyfQBv0z7zBWwJm == TargetModel.CollisionType.Bodyshot)
					{
						_pL6aoe4HLq4X3yQACLFyUH3xwBp++;
						ShootingRangeMiniGameScene.smethod_29(_Hsn6Qz2oeKaTkin9XGwBJUJqy1C, 1f);
						_G0GwJ5OWQOA4BjacW3XmFsyMFjz += 10;
						_xaBDiofMkYNdWQ4me0hnZ4NsCnk(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, "10!", Color.get_Red());
						_OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						_OJbyketBmeLlVtChfay03TIx5KM._u1yq8F9lG8oMcA9vZO9c7Qbh8vj(delegate
						{
							_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, delegate
							{
								_PFrgvj2zYkmkbPmVfpiUnTvLsoC(_OJbyketBmeLlVtChfay03TIx5KM);
							});
						});
						_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
					}
					flag = true;
					break;
				}
				if (!flag)
				{
					RailInfo railInfo = _HYME5rEMzi5Cag9e7DCXk5lrXwX.FirstOrDefault((RailInfo railInfo_0) => _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y < railInfo_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf);
					_Kp1esj4V82aePkZwvlresNSkHsC(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, railInfo?._fO7gSlrDDNMoHR4FO5QXAq8fUyA ?? 1f);
					_dH7hlTzeJboGa5rfpgerBfCmyKO++;
					ShootingRangeMiniGameScene.smethod_29(_Oeqego17TDqmByfLbOEB1isMXzJ, 1f);
				}
			}
			else
			{
				ShootingRangeMiniGameScene.smethod_29(_RiMZpLLSGIesSXF8vhSlVQ8SrDg, 1f);
			}
		}
		if (!_eMnDHRem25x38ZqmbzZLc1CLkwlA && (ShootingRangeMiniGameScene.smethod_27(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton) || ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)82) || ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)32)))
		{
			_eMnDHRem25x38ZqmbzZLc1CLkwlA = true;
			_nHs33RHZMuYhYev0dQ6ic0aHmvO = true;
			ShootingRangeMiniGameScene.smethod_29(_ykeARom1bl7r01BeRXMOSqoJU6o, 1f);
			_85WqOX8OcxbI6g74CaBZtHiHK2m._hAt3H7isKECkVrQjY4L0hESiqLF(delegate
			{
				_YFr89aAV3UzO9kf7kPKQJilRWED = 6;
				_eMnDHRem25x38ZqmbzZLc1CLkwlA = false;
				_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
			});
		}
	}

	private void _SeJVPxt5mkxE2oaiV4gLg7Iiar()
	{
		if (_dxhbACq6BB89IAMy6ZOALWJgv7L == GameState.Started)
		{
			int num = _u8GaIYUzQ65BoFU3NzXBzyvujjbA.Count((TargetModel targetModel_0) => targetModel_0._kf3EbE0B70xGe1szklqAZyCqoLj);
			for (int i = num; i < _M8VVMN3GHWWmFmORCACqNTXVh6b; i++)
			{
				_OLpKeyCIa9e3g4oTFOGxKKmVbHJ();
			}
		}
	}

	private void _OLpKeyCIa9e3g4oTFOGxKKmVbHJ()
	{
		RailInfo railInfo = _HYME5rEMzi5Cag9e7DCXk5lrXwX[ShootingRangeMiniGameScene.smethod_30(0, _HYME5rEMzi5Cag9e7DCXk5lrXwX.Length)];
		int int_ = ShootingRangeMiniGameScene.smethod_30(railInfo._SjhHztt8d5kOtb7Z2BJKnZZxEKh, railInfo._nVnyJkkce6HsdRrKSpRrzUDElg0);
		TargetModel _OJbyketBmeLlVtChfay03TIx5KM = new TargetModel(this, int_, railInfo._bCjZ3VSXGKyhmykd2zCnQBiSpDf, railInfo._fO7gSlrDDNMoHR4FO5QXAq8fUyA)
		{
			_kf3EbE0B70xGe1szklqAZyCqoLj = true
		};
		_OJbyketBmeLlVtChfay03TIx5KM._edcakvTOp2fd2J9ZHAu9GKjDaN7();
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA.Add(_OJbyketBmeLlVtChfay03TIx5KM);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_OJbyketBmeLlVtChfay03TIx5KM, railInfo._dPmC8tBC0iph2YBAFmztEsmwUdSA);
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA = _u8GaIYUzQ65BoFU3NzXBzyvujjbA.OrderByDescending((TargetModel targetModel_0) => targetModel_0._ac2H6kMdrgPhXXxabsikjji4SiT).ToList();
		_5b1aUCG2FfD5yQCBUDAoLZYMu7A(3.5f, delegate
		{
			if (_OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj && _dxhbACq6BB89IAMy6ZOALWJgv7L != GameState.GameOver)
			{
				_JvgphfrWtBncPfgb6ERRVKKtlQG++;
				_OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj = false;
				_OJbyketBmeLlVtChfay03TIx5KM._u1yq8F9lG8oMcA9vZO9c7Qbh8vj(delegate
				{
					_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, delegate
					{
						_PFrgvj2zYkmkbPmVfpiUnTvLsoC(_OJbyketBmeLlVtChfay03TIx5KM);
					});
				});
				_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
			}
		});
	}

	private void _PFrgvj2zYkmkbPmVfpiUnTvLsoC(TargetModel targetModel_0)
	{
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA.Remove(targetModel_0);
		ShootingRangeMiniGameScene.smethod_31((_7UlnfykmEmZDFt3BmCKZekI43Ih)this).Remove(targetModel_0);
	}

	private void _g0eYquQ8BcifsIs5UMyAIkXM5paA(float float_0)
	{
		if (ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)13))
		{
			_haICL4qkfkOLhPhofWQH1GmjZx5();
		}
		else if (ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)27))
		{
			_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.None;
			_5Z9jaXDcRYm0wNlEm1aTutL9kSH();
		}
	}

	protected abstract void _5Z9jaXDcRYm0wNlEm1aTutL9kSH();

	private void _haICL4qkfkOLhPhofWQH1GmjZx5()
	{
		_0zKXRrSXqoTAuTYQNrJIgtt7Emq = 90f;
		_G0GwJ5OWQOA4BjacW3XmFsyMFjz = 0;
		_JvgphfrWtBncPfgb6ERRVKKtlQG = 0;
		_dH7hlTzeJboGa5rfpgerBfCmyKO = 0;
		_C6cjmtLovCejw2N3OZYswcoYxsd = 0;
		_pL6aoe4HLq4X3yQACLFyUH3xwBp = 0;
		_YFr89aAV3UzO9kf7kPKQJilRWED = 0;
		_xEG3axnWkco0Erk0PdjakXDULcA.Clear();
		_d9mstkVrU6KGDJyOtHGgrr2ZciA.Clear();
		foreach (TargetModel item in _u8GaIYUzQ65BoFU3NzXBzyvujjbA)
		{
			ShootingRangeMiniGameScene.smethod_31((_7UlnfykmEmZDFt3BmCKZekI43Ih)this).Remove(item);
		}
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA.Clear();
		_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.NotStarted;
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		this.method_0(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
		ShootingRangeMiniGameScene.smethod_32(spriteBatch_0);
		_LSweOA3cIPq1IjLzplF4mDludQf(spriteBatch_0);
		spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Score: " + _G0GwJ5OWQOA4BjacW3XmFsyMFjz, new Vector2(10f, 10f), Color.get_White());
		spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Targets missed: " + _JvgphfrWtBncPfgb6ERRVKKtlQG, new Vector2(10f, 60f), Color.get_White());
		spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Shots missed: " + _dH7hlTzeJboGa5rfpgerBfCmyKO, new Vector2(10f, 80f), Color.get_White());
		spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Bodyshots: " + _pL6aoe4HLq4X3yQACLFyUH3xwBp, new Vector2(10f, 100f), Color.get_White());
		spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Headshots: " + _C6cjmtLovCejw2N3OZYswcoYxsd, new Vector2(10f, 120f), Color.get_White());
		int num = 5;
		int num2 = 0;
		while (num >= 0)
		{
			spriteBatch_0.Draw(_m1dNhD2jwJ6iTVUgUzMJUvnQFS, new Rectangle(1875 - 35 * num, 10, 30, 55), (num2 < _YFr89aAV3UzO9kf7kPKQJilRWED) ? _AWLddj1Rm2sqiBwYcJDngG0QaQI : (_AWLddj1Rm2sqiBwYcJDngG0QaQI * 0.5f));
			num--;
			num2++;
		}
		if (_YFr89aAV3UzO9kf7kPKQJilRWED == 0)
		{
			spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Reload!", new Vector2(1750f, 70f), Color.get_Red());
		}
		switch (_dxhbACq6BB89IAMy6ZOALWJgv7L)
		{
		case GameState.NotStarted:
			spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Press <Space/R/Mouse-R> to Reload and begin.", new Vector2((1920f - _YhybMVqCJnFekEXVbF1huXupDmh) / 2f, 10f), Color.get_Red());
			break;
		case GameState.Started:
			if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq >= 0f)
			{
				if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq > 10f)
				{
					spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, _0zKXRrSXqoTAuTYQNrJIgtt7Emq.ToString("F0"), new Vector2(960f, 10f), Color.get_White());
				}
				else
				{
					spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, _0zKXRrSXqoTAuTYQNrJIgtt7Emq.ToString("F1"), new Vector2(960f, 10f), Color.get_Red());
				}
			}
			break;
		case GameState.GameOver:
			spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Time up, game over! Press <Enter> to retry or <Escape> to continue.", new Vector2((1920f - _MZh3nVRuDktDpIu8X149SF90ZjO) / 2f, 10f), Color.get_Red());
			break;
		}
		spriteBatch_0.End();
	}

	public override void _tO46aYSBLFIuhFNlhbrAeWbFDSf()
	{
		this.method_1();
		ShootingRangeMiniGameScene.smethod_15(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _WD4Plg5m1AwZ5mVyjQCADcW1ZTk);
		_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = _U8eNAZVBW15ZflhG4fel0hK3Juu;
	}

	private void _FCyUaxF0GIE1r2fyuYC4b4tGqpJ(float float_0)
	{
		if (_d9mstkVrU6KGDJyOtHGgrr2ZciA.Any())
		{
			foreach (IDrawable d9mstkVrU6KGDJyOtHGgrr2Zcium in _d9mstkVrU6KGDJyOtHGgrr2ZciA)
			{
				_xEG3axnWkco0Erk0PdjakXDULcA.Remove(d9mstkVrU6KGDJyOtHGgrr2Zcium);
			}
			_d9mstkVrU6KGDJyOtHGgrr2ZciA.Clear();
		}
		foreach (IDrawable item in _xEG3axnWkco0Erk0PdjakXDULcA.ToList())
		{
			if (!item._aeQckZZROopp0BqagEZE32fzkyr)
			{
				item._tiBFUHPEkedkbgvuX3whdeyjhKo(float_0);
			}
			else
			{
				_d9mstkVrU6KGDJyOtHGgrr2ZciA.Add(item);
			}
		}
	}

	private void _LSweOA3cIPq1IjLzplF4mDludQf(SpriteBatch spriteBatch_0)
	{
		using List<IDrawable>.Enumerator enumerator = _xEG3axnWkco0Erk0PdjakXDULcA.GetEnumerator();
		if (enumerator.MoveNext())
		{
			IDrawable current = enumerator.Current;
			current._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		}
	}

	private void _Vu9iV57zUVa3p8WMfOsDaoqv7wL(int int_0, int int_1, float float_0)
	{
		FrameAnimation frameAnimation = new FrameAnimation(this, "Assets/Scenes/ShootingRange/Explosion_12x1", 0.5f, 12, 125, 111, float_0);
		frameAnimation._QrgbXEg7MMeD9Ybz12fFVsbmAd9(int_0, int_1, ShootingRangeMiniGameScene.smethod_33(0f, 360f));
		_xEG3axnWkco0Erk0PdjakXDULcA.Add(frameAnimation);
	}

	private void _Kp1esj4V82aePkZwvlresNSkHsC(int int_0, int int_1, float float_0)
	{
		FrameAnimation frameAnimation = new FrameAnimation(this, "Assets/Scenes/ShootingRange/Smoke_12x1", 0.5f, 12, 122, 129, float_0);
		frameAnimation._QrgbXEg7MMeD9Ybz12fFVsbmAd9(int_0, int_1, 0f);
		_xEG3axnWkco0Erk0PdjakXDULcA.Add(frameAnimation);
	}

	private void _xaBDiofMkYNdWQ4me0hnZ4NsCnk(int int_0, int int_1, string string_0, Color color_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		FloatingFeedbackDrawable item = new FloatingFeedbackDrawable(this, int_0, int_1, string_0, color_0);
		_xEG3axnWkco0Erk0PdjakXDULcA.Add(item);
	}

	private void _5b1aUCG2FfD5yQCBUDAoLZYMu7A(float float_0, Action action_0 = null)
	{
		TimedDrawable item = new TimedDrawable(float_0, action_0);
		_xEG3axnWkco0Erk0PdjakXDULcA.Add(item);
	}

	private void _jj3EwaVU5VqWdkXGZXsxWtQcYOv()
	{
		if (_G0GwJ5OWQOA4BjacW3XmFsyMFjz > 2500)
		{
			ShootingRangeMiniGameScene.smethod_35(ShootingRangeMiniGameScene.smethod_34(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric7");
		}
		if (_C6cjmtLovCejw2N3OZYswcoYxsd > 60)
		{
			ShootingRangeMiniGameScene.smethod_35(ShootingRangeMiniGameScene.smethod_34(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric8");
		}
		if (_dH7hlTzeJboGa5rfpgerBfCmyKO == 0)
		{
			ShootingRangeMiniGameScene.smethod_35(ShootingRangeMiniGameScene.smethod_34(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric9");
		}
		if (_JvgphfrWtBncPfgb6ERRVKKtlQG < 30)
		{
			ShootingRangeMiniGameScene.smethod_35(ShootingRangeMiniGameScene.smethod_34(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric10");
		}
	}

	[CompilerGenerated]
	private void _CLBmDtQD8GSfHJi3Lio90WX7I5b()
	{
		_YFr89aAV3UzO9kf7kPKQJilRWED = 6;
		_eMnDHRem25x38ZqmbzZLc1CLkwlA = false;
		_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
		_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.Started;
		_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
	}

	[CompilerGenerated]
	private void _EW26J2sSnsOIUpghByCO8pofvme()
	{
		_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
	}

	[CompilerGenerated]
	private bool _p7I8EFIr5LBXdItOeFhgKxXbz7H(RailInfo railInfo_0)
	{
		return _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y < railInfo_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf;
	}

	[CompilerGenerated]
	private void _Jo8vcg7RV32DgHkCCWnHeDFNMgV()
	{
		_YFr89aAV3UzO9kf7kPKQJilRWED = 6;
		_eMnDHRem25x38ZqmbzZLc1CLkwlA = false;
		_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
	}

	static bool smethod_14(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._LWcoDwIWvf8DT3nQmNe5z8fkUvI;
	}

	static void smethod_15(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, bool bool_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._LWcoDwIWvf8DT3nQmNe5z8fkUvI = bool_0;
	}

	static void smethod_16()
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._h0KfaNiikKlJV2KkRPIdVDKVJnC();
	}

	static ContentManager smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static _hqmu3NsKXqziXGfVh3dt79G0fye smethod_18(ContentManager contentManager_0)
	{
		return new _hqmu3NsKXqziXGfVh3dt79G0fye(contentManager_0);
	}

	static void smethod_19(_hqmu3NsKXqziXGfVh3dt79G0fye _hqmu3NsKXqziXGfVh3dt79G0fye_0, string[] string_0)
	{
		_hqmu3NsKXqziXGfVh3dt79G0fye_0._cHRhcv3PTfJmYNZAZdcHvbfbkpj(string_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_20(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_21()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static Color smethod_22(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._uOkbmfW26QVAvyEMQakki9kTMDbA;
	}

	static Vector2 smethod_23(SpriteFont spriteFont_0, string string_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return spriteFont_0.MeasureString(string_0);
	}

	static void smethod_24(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	static TimeSpan smethod_25(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static _3FFZvGWTAe7rsviKkDPTXEVjxWf smethod_26(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._RbWJ7YGnYHCSoD44MRW1h5X6E7E;
	}

	static bool smethod_27(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, _PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq_0);
	}

	static bool smethod_28(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._fy5ebLnmRsRXv9v7RKTFU5CGMaH(keys_0);
	}

	static void smethod_29(_hqmu3NsKXqziXGfVh3dt79G0fye _hqmu3NsKXqziXGfVh3dt79G0fye_0, float float_0)
	{
		_hqmu3NsKXqziXGfVh3dt79G0fye_0._xDFlaclLtJxSUU63JEJALvRLdfe(float_0);
	}

	static int smethod_30(int int_0, int int_1)
	{
		return _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(int_0, int_1);
	}

	static List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> smethod_31(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._lstlI8qzZ4KErYKnufdOlj1xVZF;
	}

	void method_0(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		base._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
	}

	static void smethod_32(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}

	void method_1()
	{
		base._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}

	static float smethod_33(float float_0, float float_1)
	{
		return _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(float_0, float_1);
	}

	static _691ooXdgg17CWFkMkjedKBBBfYw smethod_34(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._aJh9CibG5YKhkExxgRyVopdfSeJ;
	}

	static void smethod_35(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, string string_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._vVZVLriSGPExpn1KeobglMabsoi(string_0);
	}
}