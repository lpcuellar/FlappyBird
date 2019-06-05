using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedScores : MonoBehaviour
{
    public int thisScore;


    // Start is called before the first frame update
    void Start()
    {
        thisScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = Score.score.ToString();
    }
}
