using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordcollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<SoundManager>().Play("sword_mixdown");
    }
}
