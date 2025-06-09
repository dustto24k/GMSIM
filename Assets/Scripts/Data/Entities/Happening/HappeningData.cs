using System;
using System.Collections.Generic;

[Serializable]
public class HappeningData
{
    public int HappeningId;
    public List<HappeningEffect> Effects = new List<HappeningEffect>();
}