using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTileTrigger : MonoBehaviour
{
    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private GameObject tileSpawnPoint;
    [SerializeField] private float speedMultiplier = 1.005f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        MovePlayer movePlayer;
        other.TryGetComponent<MovePlayer>(out movePlayer);
        if (movePlayer != null)
        {
            SpawnNewTile();
        }

        movePlayer.SetRunSpeed(movePlayer.GetRunSpeed() * speedMultiplier);
    }

    void SpawnNewTile()
    {
        GameObject newTile = Instantiate(tilePrefab, tileSpawnPoint.transform.position, Quaternion.identity);
        newTile.name = "New Tile";
        Destroy(gameObject.transform.parent.gameObject, 6f);
    }
}
