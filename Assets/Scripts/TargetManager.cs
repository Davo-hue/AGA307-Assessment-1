using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : Singleton<TargetManager>
{
    //spawnpoints

    public Transform[] spawnPoints;
    public GameObject[] targetTypes;

    public List<GameObject> targets;

    public TargetSize targetSize;
    public enum TargetSize
    {
        small,
        medium,
        large
    }

    public void Start()
    {
        
        //targetSize = TargetSize.medium;
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
        //_UI.UpdateTargetCount(targets.Count);
        print("Target Count is: " + GetTargetCount());
    }
    void SpawnTargets()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            SpawnTarget();
        }
        
    }

    public int GetTargetCount()
    {
        return targets.Count;
    }


}
