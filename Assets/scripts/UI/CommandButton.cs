using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class CommandButton : EventTrigger
{
    Button m_button;

	// Use this for initialization
	void Start ()
    {
        m_button = GetComponent<Button>();
        m_button.image.color = Color.red;
    }

    public void OnClick()
    {
        Debug.Log(m_button.GetComponentInChildren<Text>().text);
        m_button.image.color = Color.red;
        //call squad functions
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
        m_button.image.color = Color.green;
        CommandMenu.selectedButton = this;
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        m_button.image.color = Color.red;
        CommandMenu.selectedButton = null;
    }
}
