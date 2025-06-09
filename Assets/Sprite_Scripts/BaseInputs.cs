using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class BaseInputs : MonoBehaviour
{
    public Normal normal;
    public float angle;
    public float time;
    void Start()
    {
        transform.position=new Vector3(0f,0f,1f);
        time = normal.cooldown;
    }
    void Update()
    {
        
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 direction = mousePos - transform.position;
        direction.z = 0;

        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        
        time += Time.deltaTime;

        if (Input.GetMouseButton(0) && normal.cooldown <= time)
        {
            Click();
            time = 0;
        }
    }

    void Click()
    {
        Instantiate(normal, transform.position, transform.rotation);
    }
}