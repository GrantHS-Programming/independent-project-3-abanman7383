using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public int level;
    public GameObject triangle;
    public static bool fighting;
    public GameObject player;
    public GameObject bullet;
    
    void Start()
    {
        score = 0;
        level = 1;
        player = GameObject.FindGameObjectWithTag("Player");
        bullet = GameObject.FindGameObjectWithTag("Bullet");
        fighting = false;
    }

    void Update()
    {
        if (level <= 5 && !fighting)
        {
            for (int x = 0; x < level; x++)
            {
                float randomangle = UnityEngine.Random.Range(0f, 360f);
                Instantiate(triangle,
                    new Vector3(Mathf.Cos(randomangle * Mathf.Deg2Rad) * 20,
                        Mathf.Sin(randomangle * Mathf.Deg2Rad) * 20, 0), Quaternion.identity);
            }
            fighting = true;
        }
    }
}
