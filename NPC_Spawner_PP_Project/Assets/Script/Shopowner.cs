using UnityEngine;

public class Shopowner : INPC
{
    public string Speak()
    {
        Debug.Log("Do you wish to purchase something?");
        string str = "Do you wish to purchase something?";
        return str;
    }
}