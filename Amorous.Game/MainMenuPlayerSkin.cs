using System;
using Microsoft.Xna.Framework;

public class MainMenuPlayerSkin : AbstractPlayerSkin
{ // _hiwkgwXJpRLUFatcgZFfH6ECNfm
	private static SpriteLayer _bicep, _bicepStripe, _nails, _hand, _handColor, _forearm,
								 _forearmColorLong, _forearmColorShort, _forearmStripes,
								 _forearmAvian, _bicepAvian, _handAvian;

	public MainMenuPlayerSkin(IAmorous game)
		: base(game)
	{
		_bicep = NewSpriteLayer("Bicep", "Assets/Scenes/MainMenu/Bicep", -240, -135);
		_nails = NewSpriteLayer("Nails", "Assets/Scenes/MainMenu/Nails", -240, -135);
		_hand = NewSpriteLayer("Hand", "Assets/Scenes/MainMenu/Hand", -240, -135);
		_forearm = NewSpriteLayer("Forearm", "Assets/Scenes/MainMenu/Forearm", -240, -135);
		_bicepStripe = NewSpriteLayer("Bicep Stripe", "Assets/Scenes/MainMenu/Stripe bicep", -240, -135);
		_handColor = NewSpriteLayer("Hand Color", "Assets/Scenes/MainMenu/Marking long or short hand", -240, -135);
		_forearmColorLong = NewSpriteLayer("Forearm Color Long", "Assets/Scenes/MainMenu/Marking long forearm", -240, -135);
		_forearmColorShort = NewSpriteLayer("Forearm Color Short", "Assets/Scenes/MainMenu/Marking short forearm", -240, -135);
		_forearmStripes = NewSpriteLayer("Forearm Stripes", "Assets/Scenes/MainMenu/Stripe forearm", -240, -135);
		_forearmAvian = NewSpriteLayer("Forearm Avian", "Assets/Scenes/MainMenu/Avian forearm", -240, -135);
		_bicepAvian = NewSpriteLayer("Bicep Avian", "Assets/Scenes/MainMenu/Avian bicep", -240, -135);
		_handAvian = NewSpriteLayer("Hand Avian", "Assets/Scenes/MainMenu/Avian hand", -240, -135);
	}

	public override void Initialize(PlayerData data)
	{
		_bicep.Color = data.BodyColor;
		_nails.Color = data.NailColor;
		_nails.Visible = data.ShowNails;
		_hand.Color = data.BodyColor;
		_forearm.Color = data.BodyColor;
		_bicepStripe.Color = data.StripesColor;
		_bicepStripe.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes);
		_handColor.Color = data.LongForearmColor;
		_handColor.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm);
		_forearmColorLong.Color = data.LongForearmColor;
		_forearmColorLong.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm);
		_forearmColorShort.Color = data.ShortForearmColor;
		_forearmColorShort.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm);
		_forearmStripes.Color = data.StripesColor;
		_forearmStripes.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes);
		_forearmAvian.Color = data.AvianForearmColor;
		_forearmAvian.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm);
		_bicepAvian.Color = data.AvianForearmColor;
		_bicepAvian.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm);
		_handAvian.Color = data.AvianForearmColor;
		_handAvian.Visible = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm);
	}
}
