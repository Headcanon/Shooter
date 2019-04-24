using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 movement, rotatation;
    public GameObject ship;

    void Update()
    {
        //Pega os comandos do jogador
        movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        rotatation = new Vector3(-movement.y, movement.x, -movement.x);

        //Move a nave de acordo com os comandos
        ship.transform.localRotation = Quaternion.Euler(rotatation * 30);
        transform.Translate(movement * Time.deltaTime * 40);
        transform.localPosition = Vector3.Lerp(transform.localPosition, Vector3.zero, Time.deltaTime);
    }
}
