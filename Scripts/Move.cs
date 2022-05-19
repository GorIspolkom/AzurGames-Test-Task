using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private Vector3 moveVector;


    private void Awake()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        _rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        Debug.Log("Mouse pos " + Camera.main.ScreenToViewportPoint(Input.mousePosition));
        if (Input.GetMouseButton(1))
            Movee();
        else
            _rb.velocity = Vector3.zero;
    }

    //private void Movee()
    //{
    //    Vector3 tangage;
    //    float tangag;

    //    tangage = Camera.main.ScreenToViewportPoint(Input.mousePosition);

    //    if(tangage != moveVector)
    //    {
    //        if (tangage.x < 0.5f)
    //            tangag = tangage.x * -1;
    //        else
    //            tangag = tangage.x;

    //        _rb.velocity = new Vector3(tangag * 10f, 0f, 10f);
    //    }
    //    else
    //        _rb.velocity = Vector3.forward * 10f;
    //}

    private void Movee()
    {
        Vector3 tangage;
        float tangag;

        tangage = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        if (tangage.x <= 0.4 || tangage.x >= 0.6)
        {
            tangag = tangage.x;
            if(tangage.x < 0.5)
            {
                tangag = -(1 - tangage.x);
            }
            _rb.velocity = new Vector3(tangag, 0f, 1f) * 10f;
        }
        else
            _rb.velocity = Vector3.forward * 10f;
    }

    private void OnDestroy()
    {
        
    }
}
