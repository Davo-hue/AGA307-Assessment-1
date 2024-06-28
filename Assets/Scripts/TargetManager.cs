using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    //spawnpoints

    public Transform[] spawnPoints;
    public GameObject[] targetTypes;

    public List<GameObject> targets;

    public void Start()
    {
        

        //SpawnTargets();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            SpawnTargets();

        
    }

    void SpawnTarget()
    {
        int rndTarget = Random.Range(0, targetTypes.Length);
        int rndSpawn = Random.Range(0, spawnPoints.Length);
        GameObject target = Instantiate(targetTypes[rndTarget], spawnPoints[rndSpawn].position, spawnPoints[rndSpawn].rotation);
        targets.Add(target);
        print("Target Count is: " + GetTargetCount());
    }
    void SpawnTargets()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            SpawnTarget();
        }
        
    }

    private int GetTargetCount()
    {
        return targets.Count;
    }


}
