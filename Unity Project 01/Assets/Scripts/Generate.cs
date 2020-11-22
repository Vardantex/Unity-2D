using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject rocks;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateObstacle() {
        Instantiate(rocks);
      
        score++;

    }

    void OnGUI()
    {
        GUI.color = Color.black; 
        GUILayout.Label("Score:" + score.ToString());


    }
}
