using System;
using System.Collections.Generic;

public static class HappeningDeck
{
    public class HappeningEntry
    {
        public HappeningData Data;
        public int Duration;

        public HappeningEntry(HappeningData data, int duration)
        {
            Data = data;
            Duration = duration;
        }
    }

    private static List<HappeningEntry> allHappenings = new List<HappeningEntry>();

    // 초기 DB 세팅 (HappeningData, duration 세트 리스트 전달)
    public static void Initialize(List<HappeningEntry> happeningList)
    {
        allHappenings = new List<HappeningEntry>(happeningList);
    }

    // 랜덤 HappeningEntry 반환
    public static HappeningEntry GetRandomHappening()
    {
        if (allHappenings == null || allHappenings.Count == 0)
            return null;

        var rand = new Random();
        int index = rand.Next(allHappenings.Count);
        return allHappenings[index];
    }

    // 전체 리스트 반환(옵션)
    public static IReadOnlyList<HappeningEntry> GetAll()
    {
        return allHappenings.AsReadOnly();
    }
}
