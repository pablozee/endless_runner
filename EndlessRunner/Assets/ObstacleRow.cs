using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRow : MonoBehaviour
{
    [SerializeField] private List<GameObject> obstaclePrefabs;
    [SerializeField] private List<GameObject> obstacleSpawnPoints;

    private int spawnPointToActivate;

    private void Awake()
    {
        foreach(GameObject spawnPoint in obstacleSpawnPoints)
        {
            spawnPoint.SetActive(false);
        }
        spawnPointToActivate = Random.Range(0, obstacleSpawnPoints.Count);
        ActivateSpawnPoint(spawnPointToActivate);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void ActivateSpawnPoint(int spawnPointIndex)
    {
        GameObject obstacleSpawnPoint = obstacleSpawnPoints[spawnPointIndex];
        obstacleSpawnPoint.SetActive(true);
        int obstacleToSpawn = Random.Range(0, obstaclePrefabs.Count);
        GameObject obstacleGameObject = Instantiate(obstaclePrefabs[obstacleToSpawn], obstacleSpawnPoint.transform);

    }
}
