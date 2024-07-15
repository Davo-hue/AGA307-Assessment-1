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

    public float reachThreshold = 0.2f;
    public float moveSpeed = 1.0f; // Adjust speed as needed

    private Vector3 targetPosition;


    void Start()
    {
        StartCoroutine(Move());

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



    IEnumerator Move()
    {
        while (true) // Infinite loop for continuous movement
        {
            // Set new random target position
            SetRandomTarget();

            // Move towards the current target position
            while (Vector3.Distance(transform.position, targetPosition) > reachThreshold)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }

            // At this point, we have reached the current target position
            // Wait a bit before switching to the next target
            yield return new WaitForSeconds(0.5f); // Adjust wait time as desired
        }
    }

    void SetRandomTarget()
    {
        // Generate a random position within a range (adjust as needed)
        float randomX = Random.Range(-15f, 15f);
        float randomY = Random.Range(0f, 10f);
        targetPosition = new Vector3(randomX, randomY, 0f);
    }
}
