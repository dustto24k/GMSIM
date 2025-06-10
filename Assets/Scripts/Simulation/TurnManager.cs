using System;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public DayOfWeek CurrentDay { get; private set; } = DayOfWeek.Monday;
    public TimeSlot CurrentTimeSlot { get; private set; } = TimeSlot.Dawn;
    public GuildManager guildManager;

    public void ProgressTime()
    {
        if (PlayerActionTurnData.IsPlayerActionTurn(CurrentDay, CurrentTimeSlot))
        {
            HandlePlayerAction();
            CurrentTimeSlot++;
        }
        else if (CurrentTimeSlot == TimeSlot.Dawn)
        {
            GuildMemberRoutineManager.DawnRoutine(guildManager.AllMembers);
            CurrentTimeSlot++;
        }
        else if (CurrentTimeSlot == TimeSlot.Night)
        {
            if (CurrentDay == DayOfWeek.Sunday)
            {
                GuildMemberRoutineManager.WithdrawalDecision(guildManager.AllMembers);
            }
            else if ((CurrentDay == DayOfWeek.Thursday || CurrentDay == DayOfWeek.Saturday))
            {
                GuildMemberRoutineManager.LoyaltyUpdate(guildManager.AllMembers);
            }

            GuildMemberRoutineManager.NightRoutine(guildManager.AllMembers);

            CurrentTimeSlot = TimeSlot.Dawn;
            ProgressDay();
        }
    }

    private void ProgressDay()
    {
        CurrentDay = (DayOfWeek)(((int)CurrentDay + 1) % 7);
    }

    public void LoadTurn(DayOfWeek loadedDay, TimeSlot loadedTimeSlot)
    {
        CurrentDay = loadedDay;
        CurrentTimeSlot = loadedTimeSlot;
    }

    private void HandlePlayerAction()
    {
        ActionType currentAction = PlayerActionTurnData.GetPlayerActionType(CurrentDay, CurrentTimeSlot);

        switch (currentAction)
        {
            case ActionType.CheckDailyReport:
                break;
            case ActionType.PlayerPetEarnPhase:
                break;
            case ActionType.PlayerPetSpendPhase:
                break;
            case ActionType.TownExploration:
                break;
            case ActionType.RaidPlacement:
                break;
            case ActionType.CheckRaidResult:
                break;
            case ActionType.CheckWithdrawalResult:
                break;
            case ActionType.CheckWeeklyReport:
                break;
            default:
                break;
        }
    }
}
