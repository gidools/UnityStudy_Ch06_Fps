using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController2 : MonoBehaviour
{
    Transform aimtr;

    void Start()
    {
        aimtr = GameObject.Find("AimSpot").GetComponent<Transform>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(aimtr.position, aimtr.transform.forward, out hit))
            {
                if (hit.collider.CompareTag("enemy"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
