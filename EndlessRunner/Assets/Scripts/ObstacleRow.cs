using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRow : MonoBehaviour
{
    [SerializeField] private List<GameObject> obstaclePrefabs;
    [SerializeField] private List<GameObject> obstacleSpawnPoints;

    private int spawnPointToActivate;
    private GameObject obstacleSpawnPoint;
    private void Awake()
    {
        
    }

    void Start()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        spawnPointToActivate = Random.Range(0, obstacleSpawnPoints.Count);
        ActivateSpawnPoint(spawnPointToActivate);
    }

    void Update()
    {

    }

    void ActivateSpawnPoint(int spawnPointIndex)
    {
        transform.GetChild(spawnPointIndex).gameObject.SetActive(true);
    }
}
