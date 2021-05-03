using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{

    public int player_health = 5;
    public Text scoretext;
    private void Start()
    {
      
        player_health = GameObject.Find("Player (1)").GetComponent<SuperHotScript>().player_health;
    }
    void Update()
    {
        player_health = GameObject.Find("Player (1)").GetComponent<SuperHotScript>().player_health;
        scoretext.text = player_health.ToString();
    }


}
