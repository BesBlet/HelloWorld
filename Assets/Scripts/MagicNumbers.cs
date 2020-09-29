using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
	public Text Task;
	public Text YouNumber;
	public Text YouMove;
	int move;
	int min = 1;
	int max = 1000;
	int guess;
	
	// Start is called before the first frame update
    void Start()
    {
	    Task.text = "Загадайте число от " + min + " до " + max;
	    print ("Загадайте число от " + min + "до" + max);
        UpdateGuess();
    }

    // Update is called once per frame
    void Update()
    {
	   
	    
        if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			UpdateGuess();
		}
		 else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			UpdateGuess();
		}
		else if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
	        YouNumber.text = "Ваше число: " + guess;
	        YouMove.text = "Количество ходов: " + move;
			print ("Ваше число: " + guess);
			print("Количество ходов: " + move);
		}
        else if (Input.GetKeyDown(KeyCode.Space))
        {
	        move = 0;
	        min = 1;
	        max = 1000;
	        Start();
	        //Application.Restart();
        }
    }
    
    void UpdateGuess()
    {
	    guess = (min + max) / 2;
	    YouNumber.text = "Ваше число: " + guess + " ?";
	    YouMove.text = "Количество ходов: " + move;
	    print ("Ваше число: " + guess + "?");
	    move++;
    }
}
