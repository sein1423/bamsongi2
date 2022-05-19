using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text score;
    GameObject starter;
    public int count = 0;
    float delta = 0f;
    public int scr= 0;
    public bool gamestart = false;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score").GetComponent<Text>();
        starter = GameObject.Find("Count");
        GameStarter();

    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta < 3f)
        {
            GameStarter();
        }
        else if(delta >3f && delta < 4f)
        {
            starter.GetComponent<Text>().text = "Start!!";
        }
        else if(delta > 16f)
        {
            starter.GetComponent<Text>().text = "Score: " + count.ToString()+"0";
        }
        else if(delta > 15f)
        {
            gamestart = false;
            starter.SetActive(true);
            starter.GetComponent<Text>().text = "GameOver";
        }
        
        else
        {
            gamestart = true;
            starter.SetActive(false);
        }
    }

    void GameStarter()
    {
        int timer = 3 - (int)delta;
        starter.GetComponent<Text>().text = timer.ToString();
    }

    public void AddScore(int target)
    {
        count += target;
        scr = count * 10;
        score.text = "Score : " + scr.ToString();
        Debug.Log(count);
    }
}
