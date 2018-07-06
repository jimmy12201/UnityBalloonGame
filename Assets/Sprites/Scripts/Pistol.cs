using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public Camera cameraMan;
    public float force;
    Vector2 direction;
    public int test;

    // Update is called once per frame

    void Start()
    {
        bulletSpawn = transform.Find("FirePos");
    }

    void Update () {
        try
        { 
            Vector2 target = cameraMan.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Vector2 exitPoint = new Vector2(bulletSpawn.transform.position.x, bulletSpawn.transform.position.y);
            direction = target - exitPoint;
            direction.Normalize();

            Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
            transform.rotation = rotation;
        }
        catch (Exception E)
        {
            print(E);
        }


        if (Input.GetMouseButtonDown(0))
        {
            fire();
        }
	}

    void fire()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(direction * force);
        //bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,20));

    }
}
