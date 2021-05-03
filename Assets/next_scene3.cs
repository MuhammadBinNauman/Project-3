using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_scene3 : MonoBehaviour
{
    public float time3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time3 = time3 + Time.deltaTime;

        if (time3 > 27)
        {
            Application.Quit();
        }
    }
}
