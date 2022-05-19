using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bamsongiController : MonoBehaviour
{
    // Start is called before the first frame update
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    // Update is called once per frame
    void Start()
    {
        //Shoot(new Vector3(0, 200f, 2000f));
    }

    public void OnCollisionEnter(Collision collision)
    {
        GetComponent<ParticleSystem>().Play();
    }
}
