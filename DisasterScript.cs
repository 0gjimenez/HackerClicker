//Disaster for lossing hacks to a system crash. Video is 2d clicker game Unity tutorial #009 Problems & Disaster

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class DisasterScript : MonoBehaviour{

    public GameObject statusBox;
    public float hackCheck;
    public int genChance;
    public bool disasterActive = false;
    public int hackloss;

    void Upate () {
        hackCheck = GlobalHack.HackCount / 10;
        if (disasterActive == false) {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster() {
        disasterActive = true;
        genChance = Random.Range(1, 20);
        if (hackCheck >= genChance) {
            hackloss = Mathf.RoundToInt(GlobalHack.HackCount * 0.25f);
            statusBox.GetComponent<Text>().text = "You Lost " + hackloss + "hacks in a system crash";
            GlobalHack.HackCount -= hackloss;
            yield return new WaitForSeconds(3);
        }
        yield return new WaitForSeconds(10);
        disasterActive = false;
    }
}
//Create disasterObject in Unity project and add DisasterScript.cs into disasterObject