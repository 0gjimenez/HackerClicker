using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellInformation : MonoBehaviour
{

    public GameObject textBox;

    public void ClickTheButton()
    {
        GlobalHacks.HackCount -= 1;
        GlobalCash.CashCount += 1;
    }
}
