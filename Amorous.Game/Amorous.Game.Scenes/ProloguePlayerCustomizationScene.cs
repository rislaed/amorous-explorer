using System;
using System.Runtime.CompilerServices;
using Squid;

namespace Amorous.Game.Scenes;

public class ProloguePlayerCustomizationScene : PlayerCustomizationScene
{
	string PlayerCustomizationScene._l3SUNsFudHnZpYO0ErWgbTaz1DF => "Back to Prologue";

	public ProloguePlayerCustomizationScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_jIGpzoYLVPw8SPxmJcha832nCXR = true;
	}

	protected override void _n3b8BstkorCsu4TW0U2YVdFbdGp()
	{
		ProloguePlayerCustomizationScene.smethod_55(ProloguePlayerCustomizationScene.smethod_54((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Are you sure this how you want to look in the game?", new string[2] { "Oops, my bad!", "Yes please!" }, 250, (Action<int>)delegate(int int_0)
		{
			if (int_0 == 1)
			{
				_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
				ProloguePlayerCustomizationScene.smethod_58(ProloguePlayerCustomizationScene.smethod_57(ProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric1");
				ProloguePlayerCustomizationScene.smethod_59(ProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Prologue");
			}
		});
	}

	[CompilerGenerated]
	private void _HmcC92wrccEn9iOEGKt7s7lfxJx(int int_0)
	{
		if (int_0 == 1)
		{
			_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			ProloguePlayerCustomizationScene.smethod_58(ProloguePlayerCustomizationScene.smethod_57(ProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric1");
			ProloguePlayerCustomizationScene.smethod_59(ProloguePlayerCustomizationScene.smethod_56((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Prologue");
		}
	}

	static Desktop smethod_54(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._PnkAlVnMv0SZvRBFexqzE5DF9tp;
	}

	static void smethod_55(Desktop desktop_0, string string_0, string[] string_1, int int_0, Action<int> action_0)
	{
		desktop_0._GtkWDtXwQHwgWY4aFkacjfUDyzb(string_0, string_1, int_0, action_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_56(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static _691ooXdgg17CWFkMkjedKBBBfYw smethod_57(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._aJh9CibG5YKhkExxgRyVopdfSeJ;
	}

	static void smethod_58(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, string string_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._vVZVLriSGPExpn1KeobglMabsoi(string_0);
	}

	static void smethod_59(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}
}
