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
                { TimeSlot.Noon, ActionType.CheckFaResult },
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

    public bool IsPlayerActionTurn(int day, int timeSlot)
    {
        if (actionTurns.TryGetValue(day, out var dayDict))
        {
            if (dayDict.TryGetValue(timeSlot, out var actionTurn))
            {
                return actionTurn.actionType != ActionType.None;
            }
        }
        return false;
    }

}