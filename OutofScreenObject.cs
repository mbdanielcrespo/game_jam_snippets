using UnityEngine;

/**
*	Script responsable for checking if a given object in a topdown view
		is elegible for detruction and deleting it if so.
*/
public class OutofScreenObject : MonoBehaviour
{
	private const float zOutOfScreenMax = 25;
	private const float zOutOfScreenMin = -6;
	private const float xOutOfScreen = 28;

	// Update is called once per frame
	void Update()
	{
		//transform is inherited from MonoBehaviour, references the object the script is attached
		if (transform.position.x < -xOutOfScreen || transform.position.x > xOutOfScreen
			|| transform.position.z < zOutOfScreenMin || transform.position.z > zOutOfScreenMax)
			Destroy(gameObject);
	}
}
