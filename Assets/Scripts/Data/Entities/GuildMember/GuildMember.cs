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
    public Pet[] Pets = new Pet[3];

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

    // Ongoings
    public List<int> OngoingTags = new List<int>();
    public List<OngoingHappening> OngoingHappenings = new List<OngoingHappening>();

    // Performance
    public float Proficiency;
    public float Readiness;

    public void UpdateDaily()
    {
        Age += 0.1f;
        UpdateReadiness();
        UpdateProficiency();
    }

    private void UpdateReadiness()
    {
        // ����� �ڿ� ȸ�� or ��ȭ ����
    }

    private void UpdateProficiency()
    {
        // Ŀ��ŧ��/�����ٿ� ���� ���õ� ����
    }

    public void ProgressOngoingHappenings()
    {
        for (int i = OngoingHappenings.Count - 1; i >= 0; i--)
        {
            OngoingHappenings[i].ProgressDay(this);
            if (OngoingHappenings[i].IsExpired())
            {
                OngoingHappenings.RemoveAt(i);
            }
        }
    }
}