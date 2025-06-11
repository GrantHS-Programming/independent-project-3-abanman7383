using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : MonoBehaviour
{
    public float speed;
    public float cooldown;
    public int damage;

    void Update()
    {
        float x = (float)Math.Cos( transform.rotation.eulerAngles.z * Mathf.Deg2Rad)*Time.deltaTime * speed;
        float y = (float)Math.Sin( transform.rotation.eulerAngles.z * Mathf.Deg2Rad)*Time.deltaTime * speed;
        transform.position += transform.right * x;
        transform.position += transform.up * y;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        collision.gameObject.SendMessage("ApplyDamage", damage);
        Destroy(gameObject);
    }
}
