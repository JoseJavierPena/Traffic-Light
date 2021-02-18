using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instant3 : MonoBehaviour
{
    int random;
    public GameObject[] Cars;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateS3", 0, 1.5f);
    }

    void CreateS3()
    {
        if (GameObject.Find("Manager").GetComponent<Manager>().OneThree)
        {
            random = Random.Range(0, 19);
            Instantiate(Cars[random], transform.position, Quaternion.identity);
        }
    }

}
