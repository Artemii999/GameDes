using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabTask : MonoBehaviour
{
    public TextAsset All;
    string Text;
    public string TasK;
    public string Answers;
    public Text Tesk;
    public string True;
    public List<Text> t;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = All.text;
        string[] s = Text.Split('/');
        TasK = s[0];
        Answers = s[1];
        True = s[2];
        Tesk.text = TasK;
        string[] A = Answers.Split(';');
        
        while(i<4)
        {
            int R = Random.Range(0, t.Count);
            t[R].text = A[i];
            t.RemoveAt(R);
            i++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
