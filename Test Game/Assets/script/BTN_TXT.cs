using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTN_TXT : MonoBehaviour
{
    public GameObject[] tasks;
    public GameObject VPR;
    public GameObject[] menu;
    public GameObject[] gameOver;
    public Color gr;
    public Color fl;
    public Image th;
    public Text t;
    public LabTask task;
    public TRUE tru;
    public GameObject[] over;
    public int I;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Check()
    {
        if(t.text == task.True)
        {
            th.color = gr;
            StartCoroutine(Wait());
        }
        else
        {
            th.color = fl;
            StartCoroutine(Wait());
            //tru.Score = tru.Score + 1;
        }

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(1);
            VPR.active = false;
        }
    }

    public void CheckTru()
    {
        tasks = null;
        tasks = GameObject.FindGameObjectsWithTag("TASK");
        if (tasks.Length == 0)
        {
            StartCoroutine(Wait());
            gameOver = GameObject.FindGameObjectsWithTag("OverGameGod");
            gameOver[0].transform.GetChild(0).gameObject.active = true;

        }
        else
        {
            StartCoroutine(Wait());
            over = GameObject.FindGameObjectsWithTag("overGod");
            over[0].transform.GetChild(0).gameObject.active = true;
        }

        IEnumerator Wait()
            {
                yield return new WaitForSeconds(1);
                VPR.active = false;
            }
    }

    public void CheckFal()
    {
        tasks = null;
        tasks = GameObject.FindGameObjectsWithTag("TASK");
        if (tasks.Length == 0)
        {
            StartCoroutine(Wait());
            gameOver = GameObject.FindGameObjectsWithTag("OverGameBad");
            gameOver[0].transform.GetChild(0).gameObject.active = true;

        }
        else
        {
            StartCoroutine(Wait());
            over = GameObject.FindGameObjectsWithTag("overBad");
            over[0].transform.GetChild(0).gameObject.active = true;
        }
    
        IEnumerator Wait()
            {
                yield return new WaitForSeconds(1);
                VPR.active = false;
            }
    }

}
