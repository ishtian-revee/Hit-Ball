using UnityEngine;

public class Ball : MonoBehaviour {

    // configurable fields
    public Vector2 startForce;
    public Rigidbody2D rb;
    public GameObject nextBall;

	// Use this for initialization
	void Start ()
	{
		rb.AddForce(startForce, ForceMode2D.Impulse);
	}

    public void Split()
    {
        if (nextBall != null)
        {
            GameObject ball_1 = Instantiate(nextBall, rb.position + Vector2.right/4f, Quaternion.identity);
            GameObject ball_2 = Instantiate(nextBall, rb.position + Vector2.left/4f, Quaternion.identity);

            ball_1.GetComponent<Ball>().startForce = new Vector2(2f, 5f);
            ball_2.GetComponent<Ball>().startForce = new Vector2(-2f, 5f);
        }

        Destroy(gameObject);
    }
}
