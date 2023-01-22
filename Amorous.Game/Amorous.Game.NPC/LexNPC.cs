using System;
using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class LexNPC : SpineNPC<LexNPC.EHeads, LexNPC.EPoses, LexNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Happy,
		Angry,
		Sad,
		Embarrassed
	}

	public enum EPoses
	{
		None,
		Neutral,
		Gesture,
		GestureDrink,
		GestureSigaret
	}

	public enum EClothes
	{
		None,
		Jacket,
		Jeans,
		Panties,
		Boxers,
		DickSoft,
		DickHard
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Lex";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(255, 128, 0);

	public LexNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Lex/Lex", 1f, bool_0: true)
	{
		LexNPC.smethod_19(LexNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "animation", (Action<int>)null);
		string[] first = new string[5] { "Fringe", "Hair back", "Pupils", "Eyes back", "Ear" };
		LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, first.Union(new string[1] { "Head happy" }).ToArray()), "Blink");
		LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, first.Union(new string[1] { "Head angry" }).ToArray()), "Blink");
		LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, first.Union(new string[1] { "Head sad" }).ToArray()), "Blink");
		LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Embarrassed, first.Union(new string[1] { "Head blush" }).ToArray()), "Blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Body neutral", "Shoulder neutral", "Forearm neutral", "Tail");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Gesture, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand gesture", "Tail");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.GestureDrink, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand drink", "Tail");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.GestureSigaret, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand cig", "Tail");
		LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Jacket, "Jacket", "Shoulder neutral jacket", "Forearm neutral jacket"));
		LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket"));
		LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket"));
		LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket"));
		LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Jeans, "Jeans")));
		LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Jeans, "Jeans")));
		LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Jeans, "Jeans")));
		LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Jeans, "Jeans")));
		LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Panties, "Panties"));
		LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Panties, "Panties"));
		LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Panties, "Panties"));
		LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Panties, "Panties"));
		LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Boxers, "Boxers"));
		LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Boxers, "Boxers"));
		LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Boxers, "Boxers"));
		LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Boxers, "Boxers"));
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.DickSoft, "Male balls", "Male dick soft");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.DickSoft, "Male balls", "Male dick soft");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.DickSoft, "Male balls", "Male dick soft");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.DickSoft, "Male balls", "Male dick soft");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.DickHard, "Male balls", "Male dick hard");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.DickHard, "Male balls", "Male dick hard");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.DickHard, "Male balls", "Male dick hard");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.DickHard, "Male balls", "Male dick hard");
		LexNPC.smethod_24(LexNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Male dick soft", "Jacket");
		LexNPC.smethod_24(LexNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Male dick hard", "Male dick soft");
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			LexNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			LexNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
			LexNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
			break;
		case NPCLocation.Left:
			LexNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			LexNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
			LexNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
			break;
		case NPCLocation.Right:
			LexNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			LexNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
			LexNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
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

	static void smethod_24(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, string string_1)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._eCEWplYE5FdfYPYTrwfyRlIfd6i(string_0, string_1);
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