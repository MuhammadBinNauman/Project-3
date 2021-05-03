using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_deload : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.CompareTag("Player"))
        {
            object1.SetActive(false);
            object2.SetActive(true);

            Debug.Log("trigger 2");
        }



    }
}
