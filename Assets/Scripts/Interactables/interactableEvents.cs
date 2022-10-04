using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactableEvents : MonoBehaviour
{
    public Material highlight;
    private Color defaultColor;
    private Material changinColor;

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = GetComponent<Renderer>().material.color;
        changinColor = GetComponent<Renderer>().material;
    }


    public void enterHover()
    {
        changinColor.SetColor("_Color", highlight.color);
    }


    public void exitHover()
    {
        changinColor.SetColor("_Color", defaultColor);
    }
}
