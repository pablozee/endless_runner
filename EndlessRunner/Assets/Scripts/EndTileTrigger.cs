using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTileTrigger : MonoBehaviour
{
    [SerializeField] private MovePlayer movePlayer;
    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private GameObject tileSpawnPoint;
    [SerializeField] private float speedMultiplier = 1.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
            Debug.Log("Spawning new tile");
        }
    }

    void SpawnNewTile()
    {
        GameObject newTile = Instantiate(tilePrefab, tileSpawnPoint.transform.position, Quaternion.identity);
        newTile.name = "New Tile";
        float newRunSpeed = movePlayer.GetRunSpeed() * speedMultiplier;
        movePlayer.SetRunSpeed(newRunSpeed);
        Destroy(gameObject.transform.parent.gameObject, 6f);
    }
}
