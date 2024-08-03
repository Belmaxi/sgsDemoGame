using Platformer.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Platformer.Core.Simulation;

public class SelectCard : Simulation.Event<SelectCard>
{
    public Card card;
    public Player player;
    public override void Execute()
    {
        if (card != null)
        {
            Debug.Log(card.GetInfo() + "触发了选择牌的事件");
            card.Content();
        }
        
    }
}
