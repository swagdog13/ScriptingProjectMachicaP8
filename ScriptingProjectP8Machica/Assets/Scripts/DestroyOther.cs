using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{
    public GameObject other;
    // Start is called before the first frame update



    void Update()
    {
       if(Input.GetKey(KeyCode.Space))
       {
            Destroy(other); 
       }
    }
}
