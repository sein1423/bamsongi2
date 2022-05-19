using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    GameManager gm;
    public GameObject BamsongiPreafebs;
    bool canThrow = true;
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

            if (delta >= 1f)
            {
                delta = 0f;
                canThrow = true;
            }

            if (canThrow)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject bam = Instantiate(BamsongiPreafebs);

                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    Vector3 WorldDir = ray.direction;

                    bam.GetComponent<bamsongiController>().Shoot(WorldDir * 2000f);

                    canThrow = false;
                }

            }
        }



    }
}
