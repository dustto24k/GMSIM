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
        // ����� �ڿ� ȸ�� or ��ȭ ����
    }

    private void UpdateProficiency()
    {
        // Ŀ��ŧ��/�����ٿ� ���� ���õ� ����
    }

    private void CheckEvents()
    {
        // ���� �̺�Ʈ �߻� ����
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