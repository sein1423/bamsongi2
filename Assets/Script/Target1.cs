using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target1 : MonoBehaviour
{

    GameManager gm;
    float delta = 0f;
    // Start is called before the first frame update
    void Start()
    {

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.gamestart)
        {
            delta += Time.deltaTime;
            if ((int)delta % 2 == 0)
            {

                transform.Translate(0.1f, 0f, 0f);
            }
            else
            {

                transform.Translate(-0.1f, 0f, 0f);
            }

        }
        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        gm.AddScore(1);
    }
}
