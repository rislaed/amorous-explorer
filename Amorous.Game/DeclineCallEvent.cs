using Amorous.Game.Data.Cutscenes;

public class DeclineCallEvent : AbstractContactEvent<DeclineCallEventData>
{ // _Dnydk9Zm2nHPasHm6MocjcpA0az
	public DeclineCallEvent(Cutscene cutscene) : base(cutscene) {}

	public override void Start()
	{
		base.Start();
		PhoneOverlay.GetSingleton().DeclineCall(Contact);
	}
}
