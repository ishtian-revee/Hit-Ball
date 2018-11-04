using UnityEngine;

public class LineCollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider)
    {
        Line.IsFired = false;

        if (collider.tag == "Ball")
        {
            collider.GetComponent<Ball>().Split();
        }
    }
}
