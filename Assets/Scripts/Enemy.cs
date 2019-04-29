using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    enum Estado { patrulha, berserk};
    Estado estadoInimigo = Estado.patrulha;

    GameObject target;

    float vel;
    FollowWay patr;

    ParticleSystem tiros;

    //Start
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Conductor");

        patr = GetComponent<FollowWay>();
        vel = patr.vel;

        tiros = gameObject.GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(estadoInimigo == Estado.berserk && target !=null)
        {
            transform.LookAt(target.transform);
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, vel * Time.deltaTime);
        }

        //Debug.Log(estadoInimigo);
    }

    //Trigger enter
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            estadoInimigo = Estado.berserk;
            patr.follow = false;
            tiros.Play();
        }
    }

    //Trigger exit
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            estadoInimigo = Estado.patrulha;
            patr.follow = true;
            tiros.Stop();
        }
    }

}
