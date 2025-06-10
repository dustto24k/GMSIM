using System;
using System.Collections.Generic;

public static class PlayerActionTurnData
{
    public static readonly Dictionary<DayOfWeek, Dictionary<TimeSlot, ActionType>> playerActionTurns
        = new Dictionary<DayOfWeek, Dictionary<TimeSlot, ActionType>>
    {
        { DayOfWeek.Monday, new Dictionary<TimeSlot, ActionType>
            {
                { TimeSlot.Morning, ActionType.CheckDailyReport },
                { TimeSlot.Forenoon, ActionType.PlayerPetEarnPhase },
                { TimeSlot.Noon, ActionType.CheckWithdrawalResult },
                { TimeSlot.Afternoon, ActionType.PlayerPetSpendPhase }
            }
        },
        { DayOfWeek.Tuesday, new Dictionary<TimeSlot, ActionType>
            {
                { TimeSlot.Morning, ActionType.CheckDailyReport },
                { TimeSlot.Forenoon, ActionType.PlayerPetEarnPhase },
                { TimeSlot.Noon, ActionType.TownExploration },
                { TimeSlot.Afternoon, ActionType.PlayerPetSpendPhase }
            }
        },
        { DayOfWeek.Wednesday, new Dictionary<TimeSlot, ActionType>
            {
                { TimeSlot.Morning, ActionType.CheckDailyReport },
                { TimeSlot.Forenoon, ActionType.PlayerPetEarnPhase },
                { TimeSlot.Noon, ActionType.RaidPlacement },
                { TimeSlot.Afternoon, ActionType.PlayerPetSpendPhase }
            }
        },
        { DayOfWeek.Thursday, new Dictionary<TimeSlot, ActionType>
            {
                { TimeSlot.Morning, ActionType.CheckDailyReport },
                { TimeSlot.Forenoon, ActionType.PlayerPetEarnPhase },
                { TimeSlot.Afternoon, ActionType.PlayerPetSpendPhase },
                { TimeSlot.Evening, ActionType.CheckRaidResult }
            }
        },
        { DayOfWeek.Friday, new Dictionary<TimeSlot, ActionType>
            {
                { TimeSlot.Morning, ActionType.CheckDailyReport },
                { TimeSlot.Forenoon, ActionType.PlayerPetEarnPhase },
                { TimeSlot.Noon, ActionType.TownExploration },
                { TimeSlot.Afternoon, ActionType.PlayerPetSpendPhase }
            }
        },
        { DayOfWeek.Saturday, new Dictionary<TimeSlot, ActionType>
            {
                { TimeSlot.Morning, ActionType.CheckDailyReport },
                { TimeSlot.Forenoon, ActionType.PlayerPetEarnPhase },
                { TimeSlot.Afternoon, ActionType.PlayerPetSpendPhase },
                { TimeSlot.Evening, ActionType.CheckWeeklyReport }
            }
        },
        { DayOfWeek.Sunday, new Dictionary<TimeSlot, ActionType>
            {
                { TimeSlot.Morning, ActionType.CheckDailyReport },
                { TimeSlot.Forenoon, ActionType.PlayerPetEarnPhase },
                { TimeSlot.Noon, ActionType.TownExploration },
                { TimeSlot.Afternoon, ActionType.PlayerPetSpendPhase }
            }
        }
    };

    public static bool IsPlayerActionTurn(DayOfWeek day, TimeSlot slot)
    {
        if (playerActionTurns.TryGetValue(day, out var dayDict))
        {
            if (dayDict.TryGetValue(slot, out var actionType))
            {
                return actionType != ActionType.None;
            }
        }
        return false;
    }

    public static ActionType GetPlayerActionType(DayOfWeek day, TimeSlot slot)
    {
        if (playerActionTurns.TryGetValue(day, out var dayDict))
        {
            if (dayDict.TryGetValue(slot, out var actionType))
            {
                return actionType;
            }
        }
        return ActionType.None;
    }
}