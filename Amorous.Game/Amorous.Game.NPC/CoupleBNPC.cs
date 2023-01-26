using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class CoupleBNPC : SpineNPC<CoupleBNPC.EHeads, CoupleBNPC.EPoses, CoupleBNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Waving
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public CoupleBNPC(IAmorous game)
		: base(Game, "Assets/Scenes/Intro/Couple B", 1f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("Waving");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Waving, "Dark arm", "Characters right", "fem arms");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Waving, EClothes.Shirt, "Shirts right")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Waving, EClothes.Pants, "Pants right")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
