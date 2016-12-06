using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour
{
    public int equippedWeapon;
    public GameObject weaponPistol;
    public GameObject weaponGrenade;

    bool isCharging;
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

        if (isCharging)
        {
        }
	}

    void Attack()
    {
        if (equippedWeapon == 0)
        {
            Instantiate(weaponPistol, transform.position, transform.rotation);
        }

        else if (equippedWeapon == 1)
        {
            Instantiate(weaponGrenade, transform.position, transform.rotation);
        }
    }
}
