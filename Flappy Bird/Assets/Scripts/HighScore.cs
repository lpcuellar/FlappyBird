using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public static int highScore;
    public GameObject newHighScore;
    public GameObject goldMedal;
    public GameObject silverMedal;
    public GameObject bronzeMedal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (highScore >= Score.score)
        {
            GetComponent<UnityEngine.UI.Text>().text = highScore.ToString();

            if (highScore == 0)
            {
                Debug.Log("bronce");
                bronzeMedal.SetActive(true);
            }

            else if (highScore >= 1 && highScore < 10)
            {
                Debug.Log("bronce");
                bronzeMedal.SetActive(true);
            }

            else if (highScore >= 10 && highScore < 20)
            {
                Debug.Log("plata");
                silverMedal.SetActive(true);
            }

            else
            {
                Debug.Log("oro");
                goldMedal.SetActive(true);
            }

        }

        else
        {
            highScore = Score.score;
            GetComponent<UnityEngine.UI.Text>().text = highScore.ToString();

            if(highScore == 0)
            {
                Debug.Log("bronce");
                bronzeMedal.SetActive(true);
            }
            
            else if (highScore >= 1 && highScore < 10)
            {
                Debug.Log("bronce");
                bronzeMedal.SetActive(true);
                newHighScore.SetActive(true);
            }

            else if (highScore >= 10 && highScore < 20)
            {
                Debug.Log("plata");
                silverMedal.SetActive(true);
                newHighScore.SetActive(true);
            }

            else
            {
                Debug.Log("oro");
                goldMedal.SetActive(true);
                newHighScore.SetActive(true);
            }

        }
    }
}
