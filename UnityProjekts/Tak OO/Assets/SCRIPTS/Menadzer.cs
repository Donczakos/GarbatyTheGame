using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menadzer : MonoBehaviour
{

    [SerializeField] GameObject panelBuild;
    [SerializeField] AudioSource audioSource;
    private bool Bool=true;

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            panelBuild.SetActive(Bool);
            audioSource.Play();
            Bool = !Bool;
        }

    }

}
