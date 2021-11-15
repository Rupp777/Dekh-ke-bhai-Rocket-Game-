using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject go;
    private Rigidbody2D rb;
    public float Upforce;
    public Animator animator;
    public GameObject autolevel;
    public ScoreScript sc;
    [SerializeField] GameObject button;

    //[SerializeField] Pipes pipes; // <<-- this is to access the tower script...


    private void Awake()
    {


    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Static;
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
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.AddForce(new Vector2(0, Upforce), ForceMode2D.Impulse);
            rb.velocity = Vector2.up * Upforce;
            animator.SetBool("Up", true);
        }
        else
        {
            animator.SetBool("Up", false);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        sc.IncressScore(1);
        //go.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Dead();
        //pipes.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

    }

    private void Dead()
    {
        //rb.bodyType = RigidbodyType2D.Static;
        this.enabled = false;
        autolevel.SetActive(false);
        button.SetActive(true);

    }


    public void DestroyParent()
    {
        GameObject parant = gameObject.transform.parent.gameObject;
        parant.SetActive(false);
        //Destroy(parant);
    }

    //private void Limitposition()
    //{
    //    Vector3 viewpos = transform.position;
    //    viewpos.y = Mathf.Clamp(viewpos.y, -42, 42);
    //    rb.transform.position = viewpos;
    //}
}
