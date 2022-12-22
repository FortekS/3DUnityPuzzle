using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : Activator
{
    [SerializeField] KeyCode keyOne;
	[SerializeField] KeyCode keyTwo;
	[SerializeField] Vector3 moveDirection;

	private void FixedUpdate()
	{
		if (Input.GetKey(keyOne))
		{
			GetComponent<Rigidbody>().velocity += moveDirection;
		}
		if (Input.GetKey(keyTwo))
		{
			GetComponent<Rigidbody>().velocity -= moveDirection;
		}
		if (Input.GetKey(KeyCode.R))
		{
		    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		if(Input.GetKey(KeyCode.R))
        {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		if (Input.GetKey(KeyCode.Q))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

	private void OnTriggerExit(Collider other)
    {
		if (this.CompareTag("Cube") && other.CompareTag("Cube"))
		{
			foreach (Activator button in FindObjectsOfType<Activator>())
			{
				button.canPush = true;
			}
		}
	}
}