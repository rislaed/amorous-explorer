using System;

namespace Amorous.Game.Scenes;

public class SkyeBedroomScene : AbstractScene
{
	public SkyeBedroomScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/SkyeBedroom/interactable bedroom - Backround", 0, 0);
		AddClickableLayer("Door", "Assets/Scenes/SkyeBedroom/interactable bedroom - Door", 1534, 70, delegate
		{
			if (PlayerPreferences.GetPlayerData().GetState(AmorousData.SkyeDate) == 55)
			{
				Game.StartCutscene(AmorousData.SkyeDate);
			}
		});
		AddInteractableLayer("Mirror", "Assets/Scenes/SkyeBedroom/interactable bedroom - Mirror", 1008, 289, null, 0, 0, "<i>That's me!</i>");
		AddInteractableLayer("Mangas", "Assets/Scenes/SkyeBedroom/interactable bedroom - Mangas", 982, 483, null, 0, 0, "<i>A collection of comic books and mangas.░ The mangas haven't even been translated to English,░ can she read in Japanese?</i>");
		AddInteractableLayer("Anime Wolf", "Assets/Scenes/SkyeBedroom/interactable bedroom - Anime Wolf", 1215, 424, null, 0, 0, "Plush animal: <i>A plush of a fox character with a pompadour.░ Another obscure anime reference perhaps?");
		AddInteractableLayer("Droor Left", "Assets/Scenes/SkyeBedroom/interactable bedroom - Droor Left", 964, 542, null, 0, 0, "<i>I probably shouldn't be trifling through her private stuff,░ but there's a tonne of cosplay material in here.░ I could dye myself the entire colour spectrum here.</i>");
		if (!Censorship.Censored)
		{
			AddInteractableLayer("Droor Right", "Assets/Scenes/SkyeBedroom/interactable bedroom - Droor Right", 1166, 547, null, 0, 0, "<i>Woops,░ I guess I found where she keeps her toys!░ There are some pretty exotic looking panties in here too.░ I should probably close this one...</i>");
		}
		else
		{
			AddInteractableLayer("Droor Right", "Assets/Scenes/SkyeBedroom/interactable bedroom - Droor Right SFW", 1166, 547, null, 0, 0, "<i>Wow,░ there are some pretty exotic looking panties in here.░ I should probably close this one...</i>");
		}
		AddInteractableLayer("Frame", "Assets/Scenes/SkyeBedroom/interactable bedroom - Frame", 698, 214, null, 0, 0, "<i>A risqué poster of a popular video Game character laying nude in a field of grass.░ She must be very proud of this one, It's even framed!</i>");
		AddInteractableLayer("Wallscroll", "Assets/Scenes/SkyeBedroom/interactable bedroom - Wallscroll", 450, 171, null, 0, 0, "<i>Looks like a cosplay poster,░ I don't recognise the character but the pose is very flamboyant.</i>");
		FadingMediaPlayer.PlayOnRepeat(AmorousData.LongGoneTrack, 0.4f);
	}
}
