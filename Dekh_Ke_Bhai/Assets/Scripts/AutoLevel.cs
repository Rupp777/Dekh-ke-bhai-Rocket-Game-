using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLevel : MonoBehaviour
{
    public GameObject PipeBody;


    private float respawtime;
    // Start is called before the first frame update
    void Start()
    {
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

    IEnumerator SpawningPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawtime);
            //Debug.Log(respawtime); // <<-- Can delet...
            SpawnPipe();
        }
    }


}
