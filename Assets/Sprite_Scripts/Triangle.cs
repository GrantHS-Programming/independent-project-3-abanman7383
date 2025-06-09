using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    public int health = 100;
    public float speed;
    public Transform target;
    private int currentHealth;
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
        float x = (float)Math.Cos( transform.rotation.eulerAngles.z * Mathf.Deg2Rad)*Time.deltaTime * speed;
        float y = (float)Math.Sin( transform.rotation.eulerAngles.z * Mathf.Deg2Rad)*Time.deltaTime * speed;
        transform.position += new Vector3(x,y,0);
        
        
    }

    void ApplyDamage(int damage)
    {
        health -= damage;
        
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
