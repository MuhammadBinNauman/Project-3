using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_collapse : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator myAnimationController;

    public GameObject object1;
    public GameObject object2;
    public GameObject object3;

    public Material disolve;
    public float intensity;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter (Collider other)
    {
        Debug.Log(other);
        if (other.CompareTag("Player"))
        {
            object1.SetActive(true);
            object2.SetActive(true);
            object3.SetActive(false);

            Debug.Log("trigger");

            myAnimationController.SetBool("trigger", true);

          
        }

  
        
    }

}
