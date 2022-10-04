using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projecorInteract : MonoBehaviour
{
    [SerializeField]
    private GameObject particleSys;

    public void displayParticles()
    {
        particleSys.SetActive(true);
    }
}
