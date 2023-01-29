namespace Amorous.Game.NPC;

public class ClubPoolStaticDNPC : ClubPoolStaticNPC
{
	public ClubPoolStaticDNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "D", shirt: true, pants: true)
	{
		Width = 566;
		Height = 881;
		_rlJEdnItzlU5efWtBjMCaC5Nizb = 350f;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
