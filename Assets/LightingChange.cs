using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingChange : MonoBehaviour
{

    private float blueComp = 0.8f; 
    private float redComp = 0f;
    private float yellowComp = 0.6f;
    private float initialDistance;
    private Light lt;
    private GameObject player;
    public GameObject finalHotspot;

    // Start is called before the first frame update
    void Start()
    {
        player = Camera.main.transform.parent.gameObject;
        lt = GetComponent<Light>();
        initialDistance = Vector3.Distance(finalHotspot.transform.position, player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(finalHotspot.transform.position, player.transform.position);

        if (distance < initialDistance) {
            blueComp = distance/(initialDistance*2);
            redComp = 0.8f-blueComp;
            yellowComp = blueComp;
        }

        lt.color = new Color(redComp, yellowComp, blueComp, 0.3f);
        RenderSettings.fogColor = new Color(redComp, yellowComp, blueComp, 0.3f);
        
    }
}
