using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class JasonDartsonNPC : LayerNPC<JasonDartsonNPC.EHeads, JasonDartsonNPC.EPoses, JasonDartsonNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Standing
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Jason Dartson";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(122, 53, 54);

	public JasonDartsonNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/JasonDartson", 0.9f)
	{
		JasonDartsonNPC.smethod_16(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Jason Body"), new string[1] { "Jason Cock" });
		JasonDartsonNPC.smethod_18(JasonDartsonNPC.smethod_17(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Jason Pants")));
		JasonDartsonNPC.smethod_20(JasonDartsonNPC.smethod_19(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Jason Shirt")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			JasonDartsonNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			JasonDartsonNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 685f);
			JasonDartsonNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 50f);
			break;
		case NPCLocation.Left:
			JasonDartsonNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			JasonDartsonNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
			JasonDartsonNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 50f);
			break;
		case NPCLocation.Right:
			JasonDartsonNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			JasonDartsonNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1270f);
			JasonDartsonNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 50f);
			break;
		}
	}

	static _NaKchYC4I4GjWR34SfBLAktysCE smethod_16(_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0, string[] string_0)
	{
		return _NaKchYC4I4GjWR34SfBLAktysCE_0._6NcgB9eEKq8eKu8SgNWnKbLsDhB(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_17(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_18(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_19(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_20(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_21(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_22(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_23(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}