using System;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public DayOfWeek CurrentDay { get; private set; } = DayOfWeek.Monday;
    public TimeSlot CurrentTimeSlot { get; private set; } = TimeSlot.Dawn;

    public void ProgressTime()
    {
        if (CurrentTimeSlot < TimeSlot.Night)
        {
            CurrentTimeSlot++;
        }
        else
        {
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

    public bool IsPlayerActionTurn()
    {
        return PlayerActionTurnData.IsPlayerActionTurn(CurrentDay, CurrentTimeSlot);
    }
}
