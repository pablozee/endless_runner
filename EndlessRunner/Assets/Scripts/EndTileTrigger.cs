using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTileTrigger : MonoBehaviour
{
    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private GameObject tileSpawnPoint;

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
        Instantiate(tilePrefab, tileSpawnPoint.transform.position, Quaternion.identity);
        Destroy(gameObject.transform.parent.gameObject, 6f);
    }
}
