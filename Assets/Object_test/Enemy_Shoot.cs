using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shoot : MonoBehaviour {

    public GameObject Bullet_emiiter;

    public GameObject bullet_sample;

    public float Bullet_Forward_Force;

    public GameObject MainCharacter;

    float counttime = 0.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        counttime += Time.deltaTime;
        if (counttime>2.0f)
        {
            counttime = 0.0f;
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(bullet_sample, Bullet_emiiter.transform.position, Bullet_emiiter.transform.rotation) as GameObject;
            Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

            Rigidbody Temporary_Rigidbody;
            Temporary_Rigidbody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            //Temporary_Rigidbody.AddForce(0, 0, 50);
            //Temporary_Rigidbody.velocity= Temporary_Bullet_Handler.transform.forward * 6;
            Temporary_Rigidbody.AddForce((MainCharacter.transform.position - transform.position) * Bullet_Forward_Force);
            Destroy(Temporary_Bullet_Handler, 20.0f);
        }
    }
}
