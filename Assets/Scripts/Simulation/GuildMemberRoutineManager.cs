using System.Collections.Generic;

public static class GuildMemberRoutineManager
{
    public static void DawnRoutine(List<GuildMember> guildMembers)
    {
        foreach (var member in guildMembers)
        {
            member.UpdateDaily();
            member.ProgressOngoingHappenings();

            if (member.OngoingHappenings.Count == 0)
            {
                var entry = HappeningDeck.GetRandomHappening();
                if (entry != null)
                {
                    member.OngoingHappenings.Add(
                        new OngoingHappening(entry.Data.HappeningId, entry.Duration)
                    );
                }
            }

            // 출석 여부 결정
        }
    }


    public static void NightRoutine(List<GuildMember> guildMembers) { }

    public static void LoyaltyUpdate(List<GuildMember> guildMembers) { }

    public static void WithdrawalDecision(List<GuildMember> guildMembers) { }
}
