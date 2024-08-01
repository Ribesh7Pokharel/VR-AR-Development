using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public float canFire = 0f;
	public float fireRate = 9.0f;
	public GameObject laserprefab;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.Space))
		{
			transform.position += new Vector3(0.00f, +0.05f, 0.0f);
		}

		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += new Vector3(+0.02f, 0.00f, 0.00f);
		}

		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(0.0f, 0.0f, -0.02f);
		}

		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3(0.0f, 0.0f, +0.02f);
		}

		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3(-0.02f, 0.0f, 0.00f);
		}
		if (Input.GetKey(KeyCode.Q) && Time.time > canFire)
		{
			FireLaser();
		}
	}

	public void FireLaser()
	{
			canFire = Time.time + fireRate;
			GameObject laser = Instantiate(laserprefab,
				transform.position + new Vector3(0.0f, 0.6f, 0.0f),
				transform.rotation);
	}
}
