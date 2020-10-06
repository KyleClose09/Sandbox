using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Renderer rend;
    private Material mat;
    public Color[] colors;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        mat = rend.material;

    }
    private void OnMouseDown()
    {
        mat.SetColor("_Color", Color.cyan);
    }
}
