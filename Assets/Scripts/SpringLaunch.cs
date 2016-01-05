using UnityEngine;
using System.Collections;

public class SpringLaunch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionStay(Collision collision)
    {
        print("hello");
        if (collision.gameObject.name == "Ball")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                Vector3 ball_movement = new Vector3(0.0f, 0.0f, -100.0f);

                Main.S.ball.GetComponent<Rigidbody>().AddForce(ball_movement * 10);
            }
        }
    }
}
