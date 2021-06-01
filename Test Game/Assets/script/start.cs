using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject[] menu;
    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.FindGameObjectsWithTag("main");
        menu[0].transform.GetChild(0).gameObject.active = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
