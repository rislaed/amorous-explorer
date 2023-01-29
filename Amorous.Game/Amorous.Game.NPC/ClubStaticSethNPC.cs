namespace Amorous.Game.NPC;

public class ClubStaticSethNPC : ClubStaticNPC
{
	public ClubStaticSethNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Seth", bool_0: true, bool_1: true)
	{
		Width = 225;
		Height = 334;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
