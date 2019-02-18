using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] normalObstacles;

    [SerializeField]
    private GameObject[] lethalObstacles;
    //TODO: Create ScriptableObject powerups

    private const int OBJECTS_PER_POOL = 10;
    private List<Queue<GameObject>> normalObstaclePools = new List<Queue<GameObject>>();
    private List<Queue<GameObject>> lethalObstaclePools = new List<Queue<GameObject>>();

    // Start is called before the first frame update
    void Awake()
    {
        CreatePool(normalObstacles, normalObstaclePools);
        CreatePool(lethalObstacles, lethalObstaclePools);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreatePool(GameObject[] GOarr, List<Queue<GameObject>> Pools)
    {
        for (int i = 0; i < GOarr.Length; i++)
        {
            Pools.Add(new Queue<GameObject>());
            for (int j = 0; j < OBJECTS_PER_POOL; j++)
            {
                GameObject tempObj = Instantiate(GOarr[i]);
                tempObj.SetActive(false);
                Pools[i].Enqueue(tempObj);
            }
        }


    }
}
