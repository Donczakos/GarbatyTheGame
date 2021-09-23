using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamelHopCoOdbiera : MonoBehaviour
{
    [SerializeField] Transform Transform;
    [SerializeField] GameObject BufforCamel;
    [SerializeField] GameObject Boxs;
    [SerializeField] List<Transform> CamelBox;


    private void Start()
    {
        CamelBox.AddRange(Boxs.GetComponentsInChildren<Transform>());
    }

    public void CamelsBox()
    {
        BufforCamel = Transform.GetChild(0).gameObject;
        for (int i = 0; i < CamelBox.Count; ++i) 
        {
            if (CamelBox[i].transform.childCount == 0 )
            {
                BufforCamel.transform.position = CamelBox[i].transform.position;
                BufforCamel.transform.parent = CamelBox[i].transform;
                break;
            }
        }
    }

}
