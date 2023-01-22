using System;

namespace Amorous.Game.Scenes;

public class SkyeBedroomScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	public SkyeBedroomScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		SkyeBedroomScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/SkyeBedroom/interactable bedroom - Backround", 0, 0);
		SkyeBedroomScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Door", "Assets/Scenes/SkyeBedroom/interactable bedroom - Door", 1534, 70, (Action)delegate
		{
			if (_003C_003Ec__DisplayClass0_0.smethod_1(_003C_003Ec__DisplayClass0_0.smethod_0(), "SkyeDate") == 55)
			{
				_003C_003Ec__DisplayClass0_0.smethod_2(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "SkyeDate");
			}
		});
		SkyeBedroomScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Mirror", "Assets/Scenes/SkyeBedroom/interactable bedroom - Mirror", 1008, 289, (string)null, 0, 0, "<i>That's me!</i>");
		SkyeBedroomScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Mangas", "Assets/Scenes/SkyeBedroom/interactable bedroom - Mangas", 982, 483, (string)null, 0, 0, "<i>A collection of comic books and mangas.░ The mangas haven't even been translated to English,░ can she read in Japanese?</i>");
		SkyeBedroomScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Anime Wolf", "Assets/Scenes/SkyeBedroom/interactable bedroom - Anime Wolf", 1215, 424, (string)null, 0, 0, "Plush animal: <i>A plush of a fox character with a pompadour.░ Another obscure anime reference perhaps?");
		SkyeBedroomScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Droor Left", "Assets/Scenes/SkyeBedroom/interactable bedroom - Droor Left", 964, 542, (string)null, 0, 0, "<i>I probably shouldn't be trifling through her private stuff,░ but there's a tonne of cosplay material in here.░ I could dye myself the entire colour spectrum here.</i>");
		if (!SkyeBedroomScene.smethod_17())
		{
			SkyeBedroomScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Droor Right", "Assets/Scenes/SkyeBedroom/interactable bedroom - Droor Right", 1166, 547, (string)null, 0, 0, "<i>Woops,░ I guess I found where she keeps her toys!░ There are some pretty exotic looking panties in here too.░ I should probably close this one...</i>");
		}
		else
		{
			SkyeBedroomScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Droor Right", "Assets/Scenes/SkyeBedroom/interactable bedroom - Droor Right SFW", 1166, 547, (string)null, 0, 0, "<i>Wow,░ there are some pretty exotic looking panties in here.░ I should probably close this one...</i>");
		}
		SkyeBedroomScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Frame", "Assets/Scenes/SkyeBedroom/interactable bedroom - Frame", 698, 214, (string)null, 0, 0, "<i>A risqué poster of a popular video game character laying nude in a field of grass.░ She must be very proud of this one, It's even framed!</i>");
		SkyeBedroomScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Wallscroll", "Assets/Scenes/SkyeBedroom/interactable bedroom - Wallscroll", 450, 171, (string)null, 0, 0, "<i>Looks like a cosplay poster,░ I don't recognise the character but the pose is very flamboyant.</i>");
		SkyeBedroomScene.smethod_18("Assets/Music/4U - Long Gone", 0.4f);
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _z20t8IpBINiJtljSeTIkNoKUOkx smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2CHUZ5vSi5NbJYJ4gGtr3C2VVEo(string_0, string_1, int_0, int_1, action_0);
	}

	static _x1wxbalqqw8qtEqHC1UaGdv59Od smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, string string_2, int int_2, int int_3, string string_3)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2VwdavpaoNVxohFKsz1eYBmnxyh(string_0, string_1, int_0, int_1, string_2, int_2, int_3, string_3);
	}

	static bool smethod_17()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
	}

	static void smethod_18(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}
}