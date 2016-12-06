using UnityEngine;
using System.Collections;

public class PlayerCommandingTroops : MonoBehaviour {

    public static GameObject[] troops;
	// Use this for initialization
	void Start () {
        GameObject[] troopTemp = GameObject.FindGameObjectsWithTag("Troop");
        troops = troopTemp;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
