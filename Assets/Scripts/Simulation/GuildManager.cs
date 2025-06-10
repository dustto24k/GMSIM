using System.Collections.Generic;

public class GuildManager
{
    public List<GuildMember> AllMembers { get; private set; } = new List<GuildMember>();

    public void AddMember(GuildMember member)
    {
        if (!AllMembers.Contains(member))
            AllMembers.Add(member);
    }

    public void RemoveMember(GuildMember member)
    {
        if (AllMembers.Contains(member))
            AllMembers.Remove(member);
    }

    public IReadOnlyList<GuildMember> GetAllMembers()
    {
        return AllMembers.AsReadOnly();
    }

    // 기타: 초기화/불러오기/저장 등 추후 필요시 추가
}