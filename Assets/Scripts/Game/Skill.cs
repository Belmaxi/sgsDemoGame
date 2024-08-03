using System.Collections.Generic;

public abstract class Skill
{
    public string name;
    public string description;
    public string trigger;
    public Player player;

    public List<string> audio = new List<string>();

    public abstract void Content();
    public abstract void Init();

    public virtual bool Filter()
    {
        return true;
    }
}
