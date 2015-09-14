using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private int m_score = 0;
	private float speed = 1;

    // Update is called once per frame
    void Update()
    {
		switch (m_score) {
		case 2:
			speed = 2;
			break;
		case 3:
			transform.Rotate(0,0,1);
			break;
		}
			this.transform.position += Vector3.right * speed * Time.deltaTime;
    }

	public void coinCollected(){
		m_score += 1;
		Debug.Log (m_score);
	}

}
