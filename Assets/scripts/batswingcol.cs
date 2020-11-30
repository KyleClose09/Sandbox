using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batswingcol : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<SoundManager>().Play("bat_mixdown");
    }
}
