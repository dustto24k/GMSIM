using System;
using System.Collections.Generic;

public static class HappeningHolder
{
    private static Dictionary<int, HappeningData> happeningDataDict = new Dictionary<int, HappeningData>();

    public static void RegisterHappening(HappeningData data)
    {
        happeningDataDict[data.HappeningId] = data;
    }

    public static void ApplyEffect(int happeningId, GuildMember member)
    {
        if (!happeningDataDict.TryGetValue(happeningId, out var data))
            return;

        foreach (var effect in data.Effects)
        {
            ApplyStatChange(member, effect.StatName, effect.Amount);
        }
    }

    // 스탯명을 Enum으로 변환해서 switch를 Dictionary<StatId, Action>으로 바꿀 수 있음
    private static void ApplyStatChange(GuildMember member, string statName, float amount)
    {
        switch (statName)
        {
            case "Readiness":
                member.Readiness = Math.Clamp(member.Readiness + amount, 0.0f, 100.0f);
                break;
            case "Proficiency":
                member.Proficiency = Math.Clamp(member.Proficiency + amount, 0.0f, 100.0f);
                break;
            default:
                break;
        }
    }
}