using UnityEngine;

public abstract class Player
{
    public string name = "";
    public int hp;
    public int maxHp;
    public string kindom;
    public Gender gender;

    public Texture2D texture;

    public abstract void Init();
    public void AddSkill()
    {

    }

    public virtual void Draw(int number = 1)
    {
        for(int i = 0;i<number;i++)
        {
            Game.Instance.GetTop();
        }
        
    }

    public enum Gender
    {
        Male,
        Female,
    }
}
