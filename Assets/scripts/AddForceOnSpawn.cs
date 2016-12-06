using UnityEngine;
using System.Collections;

public class AddForceOnSpawn : MonoBehaviour
{
    Rigidbody2D m_rigidbody;
    public float force;
	// Use this for initialization
	void Start ()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
        m_rigidbody.AddForce(transform.up * force);
	}
}
