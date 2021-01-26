using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyData : MonoBehaviour
{
	public GameObject player1;
	public GameObject player2;
	public int currentPlayer = 1;
	public GameObject thisPlayer;
	// Use this for initialization
	void Start()
	{
		thisPlayer = player1;
		player1.GetComponent<PlayerMove>().enabled = true;
		player2.GetComponent<PlayerMove>().enabled = false;
		
	}

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Q))
		{
			ChangePlayer();
		}
	}
	// Update is called once per frame
	public void ChangePlayer()
	{
		switch (currentPlayer)
		{
			case 1:

				currentPlayer = 2;
				thisPlayer = player2;
				player1.GetComponent<PlayerMove>().enabled = false;
				player2.GetComponent<PlayerMove>().enabled = true;
				break;

			case 2:

				currentPlayer = 1;
				thisPlayer = player1;
				player1.GetComponent<PlayerMove>().enabled = true;
				player2.GetComponent<PlayerMove>().enabled = false;
				break;
		}
	}
}
