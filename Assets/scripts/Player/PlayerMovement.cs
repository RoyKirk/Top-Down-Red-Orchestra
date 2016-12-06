using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public GameObject footprintPrefab;
    public Transform footprintLeftPos;
    public Transform footprintRightPos;
    float footprintTimer;
    public float footprintFrequency;
    bool alternateFootstep;
    bool isMoving;

    Vector2 movementDirection;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        movementDirection.x = Input.GetAxis("Horizontal");
        movementDirection.y = Input.GetAxis("Vertical");
        movementDirection.Normalize();

        RotateToMouse();

        transform.position = (Vector3)movementDirection * speed * Time.deltaTime + transform.position;

        footprintTimer += Time.deltaTime;
        if (footprintTimer >= footprintFrequency && (movementDirection.x != 0 || movementDirection.y != 0))
        {
            footprintTimer = 0;
            if (alternateFootstep)
            {
                Instantiate(footprintPrefab, footprintLeftPos.position, transform.rotation);
                alternateFootstep = false;
            }
            else
            {
                Instantiate(footprintPrefab, footprintRightPos.position, transform.rotation);
                alternateFootstep = true;
            }
        }
    }

    void RotateToMouse()
    {
        Vector2 screenPos = Camera.main.WorldToViewportPoint(transform.position); // object pos
        Vector2 mouseScreenPos = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition); //mouse pos

        float angle = Mathf.Atan2(screenPos.y - mouseScreenPos.y, screenPos.x - mouseScreenPos.x) * Mathf.Rad2Deg + 90;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
