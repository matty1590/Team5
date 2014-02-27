using UnityEngine;
using System.Collections;

public class StatsCode : MonoBehaviour
{
	int counter = 0;
	public int seconds = 0;
	public int minutes = 10;
	public int cycleseconds = 1000;
	// player 1 stats
	public int player1hunger = 100;
	public int player1health = 100;
	public int player1thirst = 100;
	public int player1happiness = 100;
	public int player1money = 1000;
	// player 2 stats
	public int player2hunger = 80;
	public int player2health = 100;
	public int player2thirst = 80;
	public int player2happiness = 100;
	public int player2money = 0;
	
	bool timerEnd = false;
	
	void Start() { } // Use this for initialization
	
	void Update() // Update is called once per frame
	{
		player1happiness = ((player1money/10)+player1health + ((player1health+player1thirst)/2))/2;
		player2happiness = ((player2money/2)+player2health + ((player2health+player2thirst)/2))/2;
		counter++;

		// timer for the game clock
		if (timerEnd == false)
		{
			if (minutes <= 0 && seconds <= 0)
			{
				timerEnd = true;
			}
			
			if (seconds <= 0)
			{
				minutes--; //add one to minutes
				seconds = 59; //reset seconds to 0
			}
			
			if (counter >= 60) //replace '60' with number of ticks per second 
			{
				seconds--; //add one to seconds
				counter = 0; //reset counter to 0
			}
		}
		// do an action if the timer reaches 0
		if (timerEnd == true)
		{
			//do the thing
		}

		updateplayerstats();


	}

	// function to update the stats of each player
	public void updateplayerstats()
	{
		cycleseconds--;
		if(cycleseconds==0)
		{
			player1hunger = player1hunger- 10;
			player1thirst = player1thirst-10;
			player2hunger = player2hunger- 10;
			player2thirst = player2thirst-10;
			cycleseconds = 600;
			playerstarvationcheck();
		}


	}

	public void playerstarvationcheck()
	{
		
		if (player1hunger < 40)
		{
			player1health = player1health-4;
			if(player1hunger<30)
			{
				player1health = player1health-4;
			}
			if(player1hunger<20)
			{
				player1health = player1health-4;
			}

		}
		
		if (player1thirst < 40)
		{
			player1health = player1health-4;
			if(player1thirst<30)
			{
				player1health = player1health-4;
			}
			if(player1thirst<20)
			{
				player1health = player1health-4;
			}
			
		}
		if (player2hunger < 40)
		{
			player2health = player2health-4;
			if(player2hunger<30)
			{
				player2health = player2health-4;
			}
			if(player2hunger<20)
			{
				player2health = player2health-4;
			}
			
		}
		if (player2thirst < 40)
		{
			player2health = player2health-4;
			if(player2thirst<30)
			{
				player2health = player2health-4;
			}
			if(player2thirst<20)
			{
				player2health = player2health-4;
			}
			
		}

		if (player1health<0)
		{
			// insert death event here
		}

		if (player2health<0)
		{
			// insert death event here
		}
	}


}
