using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject go;
    private Rigidbody2D rb;
    public float Upforce;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        //Limitposition();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.AddForce(new Vector2(0, Upforce), ForceMode2D.Impulse);
            rb.velocity = Vector2.up * Upforce;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        go.SetActive(true);
    }


    //public void DestroyParent()
    //{
    //    GameObject parant = gameObject.transform.parent.gameObject;
    //    parant.SetActive(false);
    //    //Destroy(parant);
    //}

    //private void Limitposition()
    //{
    //    Vector3 viewpos = transform.position;
    //    viewpos.y = Mathf.Clamp(viewpos.y, -42, 42);
    //    rb.transform.position = viewpos;
    //}
}
