using UnityEngine;
using System.Collections;

public class CommandMenu : MonoBehaviour
{
    public GameObject menuWheel;

	// Use this for initialization
	void Start ()
    {
        menuWheel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButton(1))
        {
            menuWheel.SetActive(true);
        }

        else if (menuWheel.activeInHierarchy == true)
        {
            menuWheel.SetActive(false);
        }
	}
}
