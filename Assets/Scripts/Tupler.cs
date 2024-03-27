using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tupler : MonoBehaviour
{
    public float Speed;
    void Update()
    {
        this.transform.position += Vector3.left * Time.deltaTime * Speed;   
    }

}
