using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] private GameObject obstacleRow;
    [SerializeField] private GameObject startingPoint;
    [SerializeField] private GameObject endingPoint;
    [SerializeField] private float distanceBetweenObstacleRows = 12f;

    void Start()
    {
        SpawnObstacleRows(); 
    }

    void Update()
    {
        
    }

    void SpawnObstacleRows()
    {
        float startingLocalX = startingPoint.transform.position.x;
        float endingLocalX = endingPoint.transform.position.x;

        int rowsToSpawn = Mathf.FloorToInt((Mathf.Abs(endingLocalX) - Mathf.Abs(startingLocalX)) / distanceBetweenObstacleRows);
        Debug.Log(rowsToSpawn);

        for (int i = 0; i < rowsToSpawn; i++)
        {
            Debug.Log("Spawning obstacle");
            GameObject row = Instantiate(obstacleRow, startingPoint.transform.position, Quaternion.Euler(0f, 90f, 0f));
            row.name = "New Obstacle";
            row.transform.parent = transform.parent;
            Vector3 rowOldLocalPos = row.transform.localPosition;
            rowOldLocalPos.x = startingLocalX + ((i + 1) * distanceBetweenObstacleRows);

            row.transform.localPosition = rowOldLocalPos;
        }
    }
}
