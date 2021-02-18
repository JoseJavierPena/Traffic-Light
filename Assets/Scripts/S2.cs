using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2 : MonoBehaviour
{
    public bool run;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0f, 0f, 90f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Manager").GetComponent<Manager>().OneThree || run)
        {
            gameObject.transform.position += new Vector3(0f, -2 * Time.deltaTime, 0f);
        }
        else if (!GameObject.Find("Manager").GetComponent<Manager>().OneThree || run)
        {
            gameObject.transform.position = gameObject.transform.position;
        }
    }

    private void OnTriggerEnter2d(Collider2d collision)
    {
        if (collision.tag == "controlS1")
        {
            run = true;
            print("Control On");
        }
        else if (collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
    }
}
