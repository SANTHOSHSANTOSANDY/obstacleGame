using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner1 : MonoBehaviour
{
   [SerializeField]  Vector3 rotateSpeed;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime);
    }
}
