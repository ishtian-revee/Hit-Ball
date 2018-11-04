using UnityEngine;

public class Line : MonoBehaviour
{
    // configerable fields
    public Transform player;
    public float beamSpeed;
    public static bool IsFired;

	// Use this for initialization
	void Start ()
	{
	    IsFired = false;
	}
	
	// Update is called once per frame
	void Update () {

	    if (Input.GetButtonDown("Fire1"))
	    {
	        IsFired = true;
	    }

	    if (IsFired)
	    {
	        transform.localScale = transform.localScale + Vector3.up * beamSpeed * Time.deltaTime;
	    }
	    else
	    {
	        transform.position = player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
	    }
	}
}
