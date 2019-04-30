using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWay : MonoBehaviour
{
    public GameManager gm;

    public GameObject wayfather;
    Transform[] ways;
    public int index = 1;
    public float vel = 10;

    Vector3 oldpos;
    Quaternion oldrot;

    public bool follow = true;

    void Start()
    {
        //Pega todos os pontos do caminho
        ways = wayfather.GetComponentsInChildren<Transform>();
        oldpos = transform.position;
        oldrot = transform.rotation;
    }

    void Update()
    {
        if (index < ways.Length && follow)
        {
            //Move o conductor na dirção do próximo ponto
            transform.position = Vector3.MoveTowards(transform.position, ways[index].transform.position, Time.deltaTime * vel);
            Vector3 direction = ways[index].transform.position - transform.position;

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime);

            //Verifica se alcançou o próximo ponto e reinicia o processo
            if (Vector3.Distance(transform.position, ways[index].transform.position) < 1)
            {
                index++;
                oldpos = transform.position;
                oldrot = transform.rotation;
            }
        }
        else if (gameObject.tag == "Conductor")
        {
            gm.CompleteLevel();
        }
        else
        {
            index = 0;
        }
    }
}
