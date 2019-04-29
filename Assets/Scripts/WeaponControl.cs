using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    public ParticleSystem fireweapon;
    public AudioSource source;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fireweapon.Emit(1);
            //source.Play();
        }
    }
}
