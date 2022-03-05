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
            GameManager.Instance.SetIsAlive(false);


            // Play collision audio to be implemented later
            PlayerAudioController playerAudio = collision.gameObject.GetComponent<PlayerAudioController>();
        //    playerAudio.PlayCollisionAudio();

            AudioSource playerAudioSource = collision.gameObject.GetComponent<AudioSource>();
            StartCoroutine(LoadSceneOnMusicComplete(playerAudioSource));
        }    
    }

    IEnumerator LoadSceneOnMusicComplete(AudioSource audioSource)
    {
        while (audioSource.isPlaying)
        {
            yield return null;
        }

        SceneManager.LoadScene("GameOver");
    }
}
