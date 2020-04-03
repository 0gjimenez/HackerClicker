using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHacks: MonoBehaviour
{
    public static int HackCount;
    public GameObject HackDisplay;
    public int InternalHack;

    void Update()
    {
        InternalHack = HackCount;
        HackDisplay.GetComponent<Text>().text = "Hacks:" + InternalHack;

    }
}
