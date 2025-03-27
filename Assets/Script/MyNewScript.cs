using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNewScript : MonoBehaviour
{
    public GameObject myObject;
    //public string playerName;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello" + playerName);
        transform.position = myObject.transform.position - Vector3.forward * 5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
