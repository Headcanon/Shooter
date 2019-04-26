using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameManager gm;

    private void OnParticleCollision(GameObject other)
    {
        gm.Lose();
        Destroy(gameObject);
    }
}
