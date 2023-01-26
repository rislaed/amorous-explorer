using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Game.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public class ClubPoolScene : AbstractScene
{
	private class FrameAnimationLayer : _fAUddQEKfZyemRb327NhM3GGlmzA
	{
		private readonly Texture2D _animationTexture;

		private Rectangle _destinationRectangle;

		private Rectangle _sourceRectangle;

		private readonly Vector2 _origin;

		private readonly float _timePerFrame;

		private readonly int _numberOfFrames;

		private int _currentFrame;

		private float _angle;

		private float _time;

		public FrameAnimationLayer(AbstractScene scene, string string_0, float float_0, int int_0, int int_1, int int_2, float float_1)
			: base(scene, "FrameAnimationLayer")
		{
			_animationTexture = scene.Game.Content.Load<Texture2D>(string_0);
			_timePerFrame = float_0 / (float)int_0;
			_numberOfFrames = int_0;
			_currentFrame = 0;
			_sourceRectangle = new Rectangle(0, 0, (int)((float)_animationTexture.Width / (float)int_0), _animationTexture.Height);
			_destinationRectangle = new Rectangle(0, 0, (int)((float)_sourceRectangle.Width * float_1), (int)((float)_sourceRectangle.Height * float_1));
			_origin = new Vector2(int_1, int_2);
			base._NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate(GameTime time)
			{
				MyUpdate((float)time.ElapsedGameTime.Milliseconds / 1000f);
			};
			base._B6VrMlmWofCGqEzjzgFJiAliCge = MyDraw;
		}

		public void Play(int x, int y, int startFrame, float angle)
		{
			_destinationRectangle.X = x;
			_destinationRectangle.Y = y;
			_currentFrame = startFrame;
			_angle = MathHelper.ToRadians(angle);
		}

		private void MyUpdate(float deltaTime)
		{
			if (_currentFrame >= 0)
			{
				_time += deltaTime;
				while (_time > _timePerFrame)
				{
					_time -= _timePerFrame;
					_currentFrame++;
				}
				if (_currentFrame < _numberOfFrames)
				{
					_sourceRectangle.X = _currentFrame * _sourceRectangle.Width;
				}
				else
				{
					_currentFrame = 0;
				}
			}
		}

		private void MyDraw(SpriteBatch spriteBatch)
		{
			if (_currentFrame >= 0)
			{
				spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, base._3TrGrUra7cqeIXkbZOrfaoQaD5F);
				spriteBatch.Draw(_animationTexture, _destinationRectangle, _sourceRectangle, Color.White, _angle, _origin, SpriteEffects.None, 0f);
				spriteBatch.End();
			}
		}
	}

	private ClubStaticRemyNPC _remy;

	private readonly bool _showRemy;

	public ClubPoolScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ClubPool/Club Pool main", -1677, 0);
		AddClickableLayer("Door", "Assets/Scenes/ClubPool/Pool door selectable", -691, 0, OnDoorClick);
		_lnXs1JfCeIBNCpFYs8XVRorc0h4 gparam_ = new _lnXs1JfCeIBNCpFYs8XVRorc0h4(this)
		{
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc = 1525f,
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY = 890f
		};
		AddLayer(gparam_, 2);
		FrameAnimationLayer frameAnimationLayer = new FrameAnimationLayer(this, "Assets/Scenes/ClubPool/ShowerParticle", 0.5f, 5, 200, 30, 1.5f);
		frameAnimationLayer.Play(-1420, 200, 0, 10f);
		FrameAnimationLayer frameAnimationLayer2 = new FrameAnimationLayer(this, "Assets/Scenes/ClubPool/ShowerParticle", 0.5f, 5, 200, 30, 1.5f);
		frameAnimationLayer2.Play(-1170, 200, 2, 10f);
		AddLayer(frameAnimationLayer, 2);
		AddLayer(frameAnimationLayer2, 2);
		AddForegroundTexturedLayer("Foreground", "Assets/Scenes/ClubPool/Club Pool top", -1677, 0);
		AddForegroundTexturedLayer("Foreground", "Assets/Scenes/ClubPool/Club Pool railing", 2041, 351);
		Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._wFfc7xL7eKxed7i9gWtao7pgsnm(-1677, 1677, 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		PlayerData data = PlayerPreferences.GetPlayerData();
		_showRemy = !data.GetBit("RemyLeftClub");
		if (_showRemy)
		{
			AddTexturedLayer("Shadow", "Assets/Scenes/ClubPool/ShadowRemy", 995, 517);
		}
	}

	public override void Start()
	{
		base.ResetVariation();
		ClubPoolStaticANPC clubPoolStaticANPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticANPC>(LayerOrder.Background);
		clubPoolStaticANPC.X = -1400f;
		clubPoolStaticANPC.Y = 910f;
		ClubPoolStaticBNPC clubPoolStaticBNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticBNPC>(LayerOrder.Background);
		clubPoolStaticBNPC.X = -1401f;
		clubPoolStaticBNPC.Y = 230f;
		ClubPoolStaticENPC clubPoolStaticENPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticENPC>(LayerOrder.Background);
		clubPoolStaticENPC.X = 106f;
		clubPoolStaticENPC.Y = 397f;
		ClubPoolStaticCNPC clubPoolStaticCNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticCNPC>(LayerOrder.Foreground);
		clubPoolStaticCNPC.X = -180f;
		clubPoolStaticCNPC.Y = 450f;
		ClubPoolStaticCNPC2 clubPoolStaticCNPC2 = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticCNPC2>(LayerOrder.Background);
		clubPoolStaticCNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticCNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		clubPoolStaticCNPC2.X = clubPoolStaticCNPC.X;
		clubPoolStaticCNPC2.Y = clubPoolStaticCNPC.Y;
		ClubPoolStaticFNPC clubPoolStaticFNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticFNPC>(LayerOrder.Foreground);
		clubPoolStaticFNPC.X = 500f;
		clubPoolStaticFNPC.Y = 180f;
		ClubPoolStaticGHINPC clubPoolStaticGHINPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticGHINPC>(LayerOrder.Foreground);
		clubPoolStaticGHINPC.X = 370f;
		clubPoolStaticGHINPC.Y = 450f;
		ClubPoolStaticGHINPC2 clubPoolStaticGHINPC2 = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticGHINPC2>(LayerOrder.Background);
		clubPoolStaticGHINPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticGHINPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		clubPoolStaticGHINPC2.X = clubPoolStaticGHINPC.X;
		clubPoolStaticGHINPC2.Y = clubPoolStaticGHINPC.Y;
		ClubPoolStaticDNPC clubPoolStaticDNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticDNPC>(LayerOrder.Foreground);
		clubPoolStaticDNPC.X = 50f;
		clubPoolStaticDNPC.Y = 690f;
		ClubPoolStaticDNPC2 clubPoolStaticDNPC2 = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticDNPC2>(LayerOrder.Background);
		clubPoolStaticDNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticDNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		clubPoolStaticDNPC2.X = clubPoolStaticDNPC.X;
		clubPoolStaticDNPC2.Y = clubPoolStaticDNPC.Y;
		if (_showRemy)
		{
			_remy = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticRemyNPC>(LayerOrder.Foreground);
			_remy.X = 1010f;
			_remy.Y = 150f;
			_remy.Click = OnRemyClick;
		}
		ClubPoolStaticJKNPC clubPoolStaticJKNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticJKNPC>(LayerOrder.Foreground);
		clubPoolStaticJKNPC.X = 1269f;
		clubPoolStaticJKNPC.Y = 383f;
		ClubPoolStaticJKNPC2 clubPoolStaticJKNPC2 = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticJKNPC2>(LayerOrder.Background);
		clubPoolStaticJKNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticJKNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		clubPoolStaticJKNPC2.X = clubPoolStaticJKNPC.X;
		clubPoolStaticJKNPC2.Y = clubPoolStaticJKNPC.Y;
		ClubPoolStaticLNPC clubPoolStaticLNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticLNPC>(LayerOrder.Background);
		clubPoolStaticLNPC.X = 1630f;
		clubPoolStaticLNPC.Y = 106f;
		ClubPoolStaticMNPC clubPoolStaticMNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticMNPC>(LayerOrder.Background);
		clubPoolStaticMNPC.X = 1879f;
		clubPoolStaticMNPC.Y = 106f;
		ClubPoolStaticNNPC clubPoolStaticNNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticNNPC>(LayerOrder.Background);
		clubPoolStaticNNPC.X = 2039f;
		clubPoolStaticNNPC.Y = 106f;
		ClubPoolStaticOPNPC clubPoolStaticOPNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticOPNPC>(LayerOrder.Foreground);
		clubPoolStaticOPNPC.X = 2223f;
		clubPoolStaticOPNPC.Y = 442f;
		ClubPoolStaticOPNPC2 clubPoolStaticOPNPC2 = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticOPNPC2>(LayerOrder.Background);
		clubPoolStaticOPNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticOPNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		clubPoolStaticOPNPC2.X = clubPoolStaticOPNPC.X;
		clubPoolStaticOPNPC2.Y = clubPoolStaticOPNPC.Y;
		ClubPoolStaticQRNPC clubPoolStaticQRNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticQRNPC>(LayerOrder.Foreground);
		clubPoolStaticQRNPC.X = 2694f;
		clubPoolStaticQRNPC.Y = 97f;
	}

	public override void Update(GameTime gameTime)
	{
		if (IsOrderingChanged)
		{
			List<AbstractLayer> list = base.Layers.Where((AbstractLayer x) => x is NPCLayer NPCLayer && (!(NPCLayer.NPC is ClubStaticNPC) || !(NPCLayer.NPC is ClubStaticSpineNPC))).ToList();
			list.ForEach(delegate(AbstractLayer x)
			{
				x.ZOrder = 3;
			});
		}
		base.Update(gameTime);
	}

	private void OnDoorClick()
	{
		base.Game.StartScene<ClubUpstairsScene>();
	}

	private void OnRemyClick()
	{
		base.Game.RequestScene("RemyPreDate");
	}
}
