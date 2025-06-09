using System;

[Serializable]
public class OngoingHappening
{
    public int StateId;
    public int DaysRemaining;

    public OngoingHappening(int stateId, int duration)
    {
        StateId = stateId;
        DaysRemaining = duration;
    }

    public bool IsExpired()
    {
        return DaysRemaining < 0;
    }

    public void ProgressDay(GuildMember member)
    {
        HappeningHolder.ApplyEffect(StateId, member);

        DaysRemaining--;
    }
}
