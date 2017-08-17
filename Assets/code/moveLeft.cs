using UnityEngine;
using System.Collections;

public class moveLeft : MonoBehaviour {

	[SerializeField]
	private float _speed = 5f;
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * Time.deltaTime * _speed);
		if (transform.position.x < -15)
		{
			float randomYPosition = UnityEngine.Random.Range(-3, 3);
			transform.position = new Vector3(15, randomYPosition, 0);
			//Debug.Log (randomYPosition);
		}
	}
}