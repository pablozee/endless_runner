using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Game over");
            GameManager.Instance.SetIsAlive(false);
            SceneManager.LoadScene("GameScene");
        }    
    }
}
