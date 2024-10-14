using UnityEngine;

public class Farmer : INPC
{
    public string Speak()
    {
        Debug.Log("You reap what you sow!");
        string str = "You reap what you sow!";
        return str;
    }
}
