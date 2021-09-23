using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{

    [SerializeField] Surowce surowce;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        surowce.AddWood();
    }
}
