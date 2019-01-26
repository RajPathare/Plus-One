using UnityEngine;

public class SwipeScript : MonoBehaviour {

	private float deltaX,deltaY;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.touchCount > 0)

		{
			Touch touch = Input.GetTouch(0);

			Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

			switch(touch.phase)

			{
				case TouchPhase.Began:
				deltaX = touchPos.x - transform.position.x;
				deltaY = touchPos.y - transform.position.y;
				break;


				case TouchPhase.Moved:
				rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));
				break;


				/*case TouchPhase.Ended:
				rb.velocity = Vector2.zero;
				break;*/

			}


		}
		
	}
}
