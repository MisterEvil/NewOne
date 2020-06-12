using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200f;

    public Transform levelPart_1;
    public Transform levelPart_Start;

   

    private Vector3 lastEndPosition;

    private void Update() {
        if (Vector3.Distance(GameObject.FindWithTag("Player").transform.position, lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            SpawnLevelPart();
        }
    }

    private void Awake() {
        lastEndPosition = levelPart_Start.Find("EndLevel").position;
        int startingSpawnLevelParts = 5;
        for (int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart() {
        Transform lastLevelPartTransform = SpawnLevelPart(lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndLevel").position;
    }
     
    private Transform SpawnLevelPart(Vector3 spawnPosition) {
        Transform levelPartTransform = Instantiate(levelPart_1, spawnPosition, Quaternion.identity);
        return levelPartTransform;

    }
}
