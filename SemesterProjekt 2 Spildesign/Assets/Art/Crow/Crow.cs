using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow : MonoBehaviour
{
    public Animator anim;
    public AudioClip Caw, fly;
    public AudioSource AS;
    float timer;

    // Update is called once per frame
    void Update()
    {
        if(timer>5)
        {
            int temp = Random.Range(0, 100);

            if(temp <30)
            {
                anim.SetTrigger("Caw");
            }else if(temp>=30 && temp <90)
            {
                anim.SetTrigger("Peck");
            }

            timer = 0;
        }

        timer += Time.deltaTime;
    }


    public void caw()
    {
        AS.PlayOneShot(Caw);
    }

    public void Fly()
    {
        AS.PlayOneShot(fly);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            anim.SetTrigger("Fly");
        }
    }
}
