using UnityEngine;
using static Platformer.Core.Simulation;

public class Card
{
    public string name = "";
    public string description = "";
    public Suit suit;
    public int number = 0;
    public Sprite texture = null;
    public bool isSelected = false;

    public virtual void Init() { }

    public virtual void Content() { }

    protected void GetState()
    {
    }

    public Card()
    {
        Init();
    }

    public string GetInfo()
    {
        return name + " " + suit + " " + number + " " + description;
    }
    
    public enum Suit
    {
        /// <summary>
        /// 红桃
        /// </summary>
        Heart,
        /// <summary>
        /// 黑桃
        /// </summary>
        Spade,
        /// <summary>
        /// 方片
        /// </summary>
        Diamond,
        /// <summary>
        /// 梅花
        /// </summary>
        Club,
        /// <summary>
        /// 无花色
        /// </summary>
        NoColor
    }

    
}
