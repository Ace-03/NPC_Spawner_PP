using UnityEngine;

public class Beggar : INPC
{
    public string Speak()
    {
        Debug.Log("Do you have some change to spare?");
        string str = "Do you have some change to spare?";
        return str;
    }
}