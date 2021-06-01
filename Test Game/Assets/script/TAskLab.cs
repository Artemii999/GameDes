using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TAskLab : MonoBehaviour
{
   /* public TextAsset All;
    string Text;
    public string TasK;
    public string Answers;
    public Text Tesk;
    public string True;
    public List<Sprite> t;
    public int i = 0;
    public Sprite[] SpitePic;
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

        while (i < 4)
        {
            int R = Random.Range(0, t.Count);
            t[R] = SpitePic[i];
            t.RemoveAt(R);
            i++;
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
