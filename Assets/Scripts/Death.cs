using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameManager gm;

    private void OnParticleCollision(GameObject other)
    {
        if (gameObject.tag == "Player") { gm.Lose(); }
        Destroy(gameObject);
    }
    
}
