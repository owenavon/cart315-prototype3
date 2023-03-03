using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    bool dead = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2f && !dead)
        {
            Die();
        }
    }

    void Die()
    {
        Invoke(nameof(ReloadLevel), 1.0f);
        dead = true; // Boolean will prevent the die function from being called over and over again.
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
