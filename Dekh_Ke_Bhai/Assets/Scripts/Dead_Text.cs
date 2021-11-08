using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead_Text : MonoBehaviour
{
    public void DestroyParent()
    {
        GameObject parant = gameObject.transform.parent.gameObject;
        parant.SetActive(false);
        //Destroy(parant);
    }
}