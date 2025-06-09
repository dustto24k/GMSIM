using System;

[Serializable]
public struct ElementPair
{
    public int Color;
    public int Shape;

    public ElementPair(int color, int shape)
    {
        Color = color;
        Shape = shape;
    }
}

[Serializable]
public class Pet
{
    public ElementPair Element;
    public int CombatPower;

    public void CompleteTraining()
    {
        // 성장 및 경험치 처리
        UpdateCombatPower();
    }

    private void UpdateCombatPower()
    {
        // CombatPower 계산 로직
    }
}