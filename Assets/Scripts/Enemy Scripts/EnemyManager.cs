using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    private EnemyScript[] enemies;
    void Start()
    {
        enemies = GameObject.FindObjectsOfType<EnemyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemies.Length<1)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
