using System;
using UnityEngine;

public class Sha : Card
{
    public override void Content()
    {

    }
    public override void Init()
    {
        name = "杀";
        description = "选择一名攻击范围内的其他角色，对其造成1点伤害";
        texture = Resources.Load<Sprite>("Game/Cards/shan");
    }
}
