using Amorous.Game.Data.Cutscenes;

public class OpenIMEvent : AbstractContactEvent<OpenIMEventData>
{ // _OmxR1Ps1AJAAL6AUU25LTaSVyRJ
	public OpenIMEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void Start()
	{
		base.Start();
		PhoneOverlay.Get().OpenIM(Contact);
	}
}
