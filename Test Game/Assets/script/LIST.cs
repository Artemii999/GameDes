using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIST : MonoBehaviour
{
    public int I;
    public GameObject[] tasks;
    public GameObject VPR;
    public GameObject[] menu;
    public GameObject[] level;
    public GameObject[] over;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Randowm()
    { 
        tasks = null;
        tasks = GameObject.FindGameObjectsWithTag("TASK");
        I = Random.Range(0, tasks.Length);
        if (tasks.Length == 0)
        {
            StartCoroutine(Wait());
            menu = GameObject.FindGameObjectsWithTag("main");
            menu[0].transform.GetChild(0).gameObject.active = true;

        }
        else
        {
            tasks[I].transform.GetChild(0).gameObject.active = true;
            StartCoroutine(Wait());
        }
    }

    public void Starting()
    {
        tasks = null;
        tasks = GameObject.FindGameObjectsWithTag("TASK");
        I = Random.Range(0, tasks.Length);
        menu = GameObject.FindGameObjectsWithTag("main");
        menu[0].transform.GetChild(0).gameObject.active = false;

        tasks[I].transform.GetChild(0).gameObject.active = true;
    }

    public void Chooseing()
    {
        menu = GameObject.FindGameObjectsWithTag("main");
        menu[0].transform.GetChild(0).gameObject.active = false;

        level = GameObject.FindGameObjectsWithTag("level");
        level[0].transform.GetChild(0).gameObject.active = true;

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        VPR.active = false;
    }

    public void next()
    {
        over = GameObject.FindGameObjectsWithTag("overGod");
        over[0].transform.GetChild(0).gameObject.active = false;
        over = GameObject.FindGameObjectsWithTag("overBad");
        over[0].transform.GetChild(0).gameObject.active = false;
    }

    public void end()
    {
        over = GameObject.FindGameObjectsWithTag("overGameGod");
        over[0].transform.GetChild(0).gameObject.active = false;
        over = GameObject.FindGameObjectsWithTag("overGameBad");
        over[0].transform.GetChild(0).gameObject.active = false;
        menu = GameObject.FindGameObjectsWithTag("main");
        menu[0].transform.GetChild(0).gameObject.active = true;
    }

}
