using System;
using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class RemyNPC : SpineNPC<RemyNPC.EHeads, RemyNPC.EPoses, RemyNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Blushing,
		Happy,
		Sad,
		Shocked
	}

	public enum EPoses
	{
		None,
		LeftArm,
		RightArm,
		BothArms,
		Shy
	}

	public enum EClothes
	{
		None,
		Apron,
		Pants,
		Sweater,
		Swimsuit
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Remy";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(255, 102, 51);

	public RemyNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Remy/Remy", 0.75f, bool_0: true)
	{
		RemyNPC.smethod_19(RemyNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "animation", (Action<int>)null);
		string[] first = new string[5] { "Fringe", "Ponytail", "Ear left", "Ear right", "Eyes back" };
		RemyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blushing, first.Union(new string[2] { "Head Blush", "Default pupils" }).ToArray()), "Head blush blink");
		RemyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, first.Union(new string[2] { "Head Happy", "Default pupils" }).ToArray()), "Head happy blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, first.Union(new string[2] { "Head Sad", "Sad pupils" }).ToArray());
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Shocked, first.Union(new string[2] { "Head Shock", "Default pupils" }).ToArray());
		string[] first2 = new string[5] { "Body", "Breasts", "Torso", "Hair", "Tail" };
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.LeftArm, first2.Union(new string[3] { "Gesture forearm left", "Gesture hand left", "Gesture shoulder left" }).ToArray());
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.RightArm, first2.Union(new string[3] { "Shy arms back", "Gesture forearm right", "Gesture hand right" }).ToArray());
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.BothArms, first2.Union(new string[5] { "Gesture forearm left", "Gesture hand left", "Gesture shoulder left", "Gesture forearm right", "Gesture hand right" }).ToArray());
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Shy, first2.Union(new string[1] { "Shy arms back" }).ToArray());
		RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Apron, "Apron")));
		RemyNPC.smethod_23(RemyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Pants, "Pants")));
		RemyNPC.smethod_24(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater Gesture shoulder left")));
		RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Swimsuit, "Swimsuit")));
		RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Apron, "Apron")));
		RemyNPC.smethod_23(RemyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Pants, "Pants")));
		RemyNPC.smethod_24(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater shy arms back", "Sweater Gesture forearm right")));
		RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Swimsuit, "Swimsuit")));
		RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Apron, "Apron")));
		RemyNPC.smethod_23(RemyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Pants, "Pants")));
		RemyNPC.smethod_24(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater Gesture shoulder left", "Sweater Gesture forearm right")));
		RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Swimsuit, "Swimsuit")));
		RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Apron, "Apron")));
		RemyNPC.smethod_23(RemyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Pants, "Pants")));
		RemyNPC.smethod_24(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater shy arms back")));
		RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Swimsuit, "Swimsuit")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			RemyNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			RemyNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1000f);
			RemyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1200f);
			break;
		case NPCLocation.Left:
			RemyNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			RemyNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 380f);
			RemyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1200f);
			break;
		case NPCLocation.Right:
			RemyNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			RemyNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1540f);
			RemyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1200f);
			break;
		}
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_18(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0)
	{
		return _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
	}

	static void smethod_19(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}

	static _xmfdPa5IagU3cXbLL61gyoXAV7gA smethod_20(_xmfdPa5IagU3cXbLL61gyoXAV7gA _xmfdPa5IagU3cXbLL61gyoXAV7gA_0, string string_0)
	{
		return _xmfdPa5IagU3cXbLL61gyoXAV7gA_0._qL2MEiFtBpbdxqUUTSqOgOsEK4j(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_21(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_22(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._B19pyNfKCkJxZB1oCC3WzfkqEQF();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_24(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._KCZzL8xtjbw97bTOV0k8JDz3olE();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_26(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}