using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Astroid : MonoBehaviour
{
    [SerializeField] float spin;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, spin));
    }
}