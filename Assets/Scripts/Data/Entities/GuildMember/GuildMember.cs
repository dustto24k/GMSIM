using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[System.Serializable]
public class GuildMember
{
    public int Id;
    public string Nickname;
    public int BehaviorType;

    // Social
    public float Age;
    public bool IsMarried;
    public int Income;
    public int SecuredTime;

    // Physical
    public float Cha;
    public float Con;
    public float Dex;
    public float Wis;

    // History
    public int MercenaryYears;
    public int SpendingSatisfaction;
    public int GuildYears;
    public int GuildLoyalty;

    // Ongoing
    public List<OngoingState> OngoingStates = new List<OngoingState>();
    public Pet[] Pets = new Pet[3];

    // Performance
    public float Proficiency;
    public float Readiness;

    public void UpdateDaily()
    {
        IncreaseAge();
        UpdateReadiness();
        UpdateProficiency();
        CheckEvents();
    }

    private void IncreaseAge()
    {
        Age += 0.1f;
    }

    private void UpdateReadiness()
    {
        // 컨디션 자연 회복 or 악화 로직
    }

    private void UpdateProficiency()
    {
        // 커리큘럼/스케줄에 따른 숙련도 성장
    }

    private void CheckEvents()
    {
        // 랜덤 이벤트 발생 로직
    }

    public void ProgressOngoingStates()
    {
        for (int i = OngoingStates.Count - 1; i >= 0; i--)
        {
            OngoingStates[i].ProgressDay(this);
            if (OngoingStates[i].IsExpired())
            {
                OngoingStates.RemoveAt(i);
            }
        }
    }
}