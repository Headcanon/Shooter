using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Death : MonoBehaviour
{
    public float vida = 100.0f;
    public GameManager gm;
    public Slider barraVida;

    private void OnParticleCollision(GameObject other)
    {
        if (gameObject.tag == "Player")
        {
            vida -= 25.0f;
            barraVida.value = vida / 100;

            if (vida <= 0)
            {
                gm.Lose();
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
}
