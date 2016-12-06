using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CommandButton : MonoBehaviour
{
    Button m_button;

	// Use this for initialization
	void Start ()
    {
        m_button = GetComponent<Button>();
	}

    void OnClick()
    {

    }

    void OnMouseEnter()
    {
        Debug.Log("onmouseenter");
        m_button.Select();
    }
}
