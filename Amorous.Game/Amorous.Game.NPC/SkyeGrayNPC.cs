using System;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.NPC;

public class SkyeGrayNPC : SkyeNPC
{
	public SkyeGrayNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		SkyeGrayNPC.smethod_34((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this, SkyeGrayNPC.smethod_33(SkyeGrayNPC.smethod_32((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this)).Load<Texture2D>("Assets/NPC/Skye/skye expressions (Gray)"));
		SkyeGrayNPC.smethod_36((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, new Type[2]
		{
			SkyeGrayNPC.smethod_35(typeof(SkyeNPC).TypeHandle),
			SkyeGrayNPC.smethod_35(typeof(SkyeBlueNPC).TypeHandle)
		});
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_32(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0)
	{
		return _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static ContentManager smethod_33(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static void smethod_34(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0, Texture2D texture2D_0)
	{
		_tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._1AqpgY4vB6ly5vxOay6j86rcIEo = texture2D_0;
	}

	static Type smethod_35(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static void smethod_36(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, Type[] type_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._rAt6TRbgK04lvrs5QPjcd0n26pk = type_0;
	}
}