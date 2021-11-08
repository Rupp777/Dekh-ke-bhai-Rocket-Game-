using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    //private Vector2 screenbound;

    void Start()
    {
        //    screenbound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //    Vector2 viewpos = transform.position;
        //    viewpos.x = Mathf.Clamp(viewpos.x, screenbound.x, screenbound.x * -1);
        //    viewpos.y = Mathf.Clamp(viewpos.y, screenbound.y, screenbound.y * -1);
        //    rb.transform.position = viewpos;
        Limitposition();
    }

    private void Limitposition()
    {
        Vector3 viewpos = transform.position;
        viewpos.y = Mathf.Clamp(viewpos.y, -42, 42);
        rb.transform.position = viewpos;
    }
}
