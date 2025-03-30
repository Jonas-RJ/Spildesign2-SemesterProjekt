using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Chase : MonoBehaviour
{
    public Transform player;
    [SerializeField] private int speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startChase();
    }

    // Update is called once per frame
    void Update()
    {
        startChase();
    }

    void startChase()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }


}
