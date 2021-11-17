using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoLevel : MonoBehaviour
{
    public GameObject PipeBody;
    public GameObject Large;
    public GameObject Mid;
    public GameObject Small;


    private float respawtime;
    private float respawtime1;
    private float respawtime2;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            StartCoroutine(Spawningast1());
            StartCoroutine(Spawningast2());
        }
        StartCoroutine(SpawningPipe());
    }

    private void Update()
    {

    }

    public void SpawnPipe()
    {
        respawtime = Random.Range(6f, 2f);
        Vector3 viewpos = transform.position;
        viewpos.x = Mathf.Clamp(viewpos.x, 90, -90);

        GameObject a = Instantiate(PipeBody);


        a.transform.position = new Vector2(viewpos.x, Random.Range(26 , -26));
    }

    public void Spwanast()
    {
        respawtime1 = Random.Range(12f, 6f);
        Vector3 viewpos = transform.position;
        viewpos.x = Mathf.Clamp(viewpos.x, 90, -90);


        GameObject b = Instantiate(Large);
        GameObject c = Instantiate(Mid);

        b.transform.Rotate(0, 0, 0.5f);
        b.transform.position = new Vector2(viewpos.x, Random.Range(48, -48));
        c.transform.position = new Vector2(viewpos.x, Random.Range(48, -48));
    }



    public void Spwanast1()
    {
        respawtime2 = Random.Range(3f, 1f);
        Vector3 viewpos = transform.position;
        viewpos.x = Mathf.Clamp(viewpos.x, 90, -90);

        GameObject d = Instantiate(Small);
        
        d.transform.position = new Vector2(viewpos.x, Random.Range(48, -48));
    }

    IEnumerator SpawningPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawtime);

            //Debug.Log(respawtime); // <<-- Can delet...
            SpawnPipe();
        }
    }

    IEnumerator Spawningast1()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawtime1);
            Spwanast();
        }

    }    
    
    IEnumerator Spawningast2()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawtime2);
            Spwanast1();
        }
    }


}
