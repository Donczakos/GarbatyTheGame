using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawełek : MonoBehaviour
{

    [SerializeField] GameObject CamelParent;
    [SerializeField] GameObject Pasieka;
    [SerializeField] List<Transform> Camels;
    [SerializeField] Rigidbody RB;
    [SerializeField] Transform Transform;
    [SerializeField] CamelHopCoOdbiera camelHopCoOdbiera;


    public float MoveSpeed;

    public float Vertical;
    public float Horizontal;

    public bool IsCamel;

    void Start()
    {
        Camels.AddRange(CamelParent.GetComponentsInChildren<Transform>());
    }

    void FixedUpdate()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
        RB.velocity = new Vector3(Horizontal, 0, Vertical) * MoveSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (!IsCamel && Camels.Contains(collision.transform))
        {
            IsCamel = true;
            collision.gameObject.transform.parent = Transform;
            collision.transform.position = Transform.position + new Vector3(0, 0, -12.4f);
            Debug.Log(collision.gameObject);
        }
        else if (collision.gameObject == Pasieka)
        {
            Transform.transform.GetChild(1).transform.parent = collision.gameObject.transform;
            camelHopCoOdbiera.CamelsBox();
            IsCamel = false;
        }
    }
}
