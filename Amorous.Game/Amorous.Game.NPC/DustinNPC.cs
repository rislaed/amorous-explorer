using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class DustinNPC : SpineNPC<DustinNPC.EHeads, DustinNPC.EPoses, DustinNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Neutral,
		Angry,
		Blush,
		Sad
	}

	public enum EPoses
	{
		None,
		Neutral,
		Gesture
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string Name = "Dustin";

	public static Color Color = new Color(242, 208, 150);

	public DustinNPC(IAmorous game)
		: base(Game, "Assets/NPC/Dustin/Dustin", 1f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("Idle");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Neutral, "Neutral Mane", "Neutral eye back", "Neutral pupil", "Neutral jaw", "Neutral head")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Neutral blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, "Angry mane", "Angry eyeback", "Angry pupil", "Angry head")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Angry blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blush, "Blush mane", "Blush eye back", "Blush pupil", "Blush head")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blush blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad earback", "Sad mane", "Sad eyeback", "Sad pupils", "Sad head")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Sad blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Body Neutral", "Neutral thumb")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Gesture, "Body Gesture")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Shirt, "Neutral shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Shirt, "Gesture shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			FlipX = false;
			X = 960f;
			Y = 1100f;
			break;
		case NPCLocation.Left:
			FlipX = false;
			X = 400f;
			Y = 1100f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1520f;
			Y = 1100f;
			break;
		}
	}
}
