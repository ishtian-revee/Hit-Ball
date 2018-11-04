using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    // configerable fields
    public float speed;
    public Rigidbody2D rb;

    // private fields
    private float movement = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    movement = Input.GetAxis("Horizontal") * speed;
	}

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime, 0f));
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ball")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
