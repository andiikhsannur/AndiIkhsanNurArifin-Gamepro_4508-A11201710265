using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    public GameObject rocks, enemy;
    int score = 0;
    GUIStyle  guitStyle = new GUIStyle();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateObstacle", 1f, 1.5f);
        InvokeRepeating ("CreateEnemy", 3f, 3.5f);
    }

    //
    void CreateObstacle()
    {
        Instantiate (rocks);
        score++;
    }

    //
    void CreateEnemy()
    {
        Instantiate (enemy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //fungsi menampilkan score
    void OnGUI()
    {
        GUI.color = Color.white;
        guitStyle.fontSize = 15;
        GUI.Label (new Rect(0, 0, 300, 50), "Score: " + score.ToString(), guitStyle);
    }
    
}
