using System.Drawing;
using UnityEngine;
using System.Collections;
using static TargetManager;

public class Target : MonoBehaviour
{
    //target size
    public TargetSize targetSize;

    //Movement
    GameObject[] moveToPositions;
     
    
    

    void Start()
    {
        switch (targetSize)
        {
            case TargetSize.small:
                transform.localScale = new Vector3(1f, 1f, 1f);
                break;
            case TargetSize.medium:
                transform.localScale = new Vector3(2f, 2f, 2f);
                break;
            case TargetSize.large:
                transform.localScale = new Vector3(3f, 3f, 3f);
                break;
            default:
                Debug.LogWarning("Unknown size: " + targetSize);
                break;
        }


    }



    //private IEnumerator Move()
    //{
        
    //    yield return new WaitForSeconds(Random.Range(1, 3));
    //    StartCoroutine(Move());
    //}

    private int GetRandomMoveToPos()
    {
        int i = Random.Range(0, moveToPositions.Length);
        return i;
    }
    private void MoveLoop()
    {
        
    }
}
