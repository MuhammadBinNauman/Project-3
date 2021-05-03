using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hotspot : MonoBehaviour
{
    private GameObject player;
    private Material material;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public bool isFinal = false;

    // Start is called before the first frame update
    void Start()
    {
        player = Camera.main.transform.parent.gameObject;
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance <= 10f) {      
           material.color = Color.red;             
        }
        else {
            material.color  = Color.white;
            if (isFinal) {
                material.color = Color.yellow;
            }
        }
    }

    public void OnPointerClick() 
    {
        Debug.Log("hotspot!");
        //disable navmesh
        player.GetComponent<NavMeshAgent>().enabled = false;
        //move from one hotspot to another
        float distance = Vector3.Distance(transform.position, player.transform.position);
        //change the (10f) in this line to change how far away the hotspot can be accessed from
        if (distance <= 10f) {  
            audioSource.PlayOneShot(audioClip);    
            //change the (120f) in this line to change the speed you travel to a hotspot at
            LeanTween.move(player, transform.position, distance/120f).setOnComplete(() =>
            {
                //enable navmesh after the tween is finished
                player.GetComponent<NavMeshAgent>().enabled = true;
            });      
        }
    }
}
