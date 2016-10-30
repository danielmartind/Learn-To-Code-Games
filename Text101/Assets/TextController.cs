using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{

	public Text text;
	private enum States { cell, sheets_0, lock_0, mirror, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;
	// Use this for initialization
	void Start ()
	{
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
	{
		print(myState);
		if(myState==States.cell)
		{
			State_Cell();
		}	
		else if(myState==States.sheets_0)
		{
			State_Sheets_0();
		}
		else if (myState == States.sheets_1)
		{
			State_Sheets_1();
		}
		else if (myState == States.lock_0)
		{
			State_Lock_0();
		}
		else if (myState == States.lock_1)
		{
			State_Lock_1();
		}
		else if (myState == States.mirror)
		{
			State_Mirror();
		}
		else if (myState == States.cell_mirror)
		{
			State_Cell_Mirror();
		}
		else if (myState == States.freedom)
		{
			State_Freedom();
		}
	}

	void State_Cell()
	{
		text.text = "You are in a prison cell, and you want to escape. There are " +
						"some dirty sheets on the bed, a mirror on the wall, and the door " +
						"is locked from the outside.\n\n" +
						"Press S to view Sheets, M to view Mirror or L to view Lock";
		if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.sheets_0;
		}
		else if (Input.GetKeyDown(KeyCode.M))
		{
			myState = States.mirror;
		}
		else if (Input.GetKeyDown(KeyCode.L))
		{
			myState = States.lock_0;
		}
	}

	void State_Sheets_0()
	{
		text.text = "You can't beleive you sleep in these things. Surely it's "+
					"time somebody changed them. The pleasures of prison life " +
					"I guess!\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell;
		}
	}

	void State_Sheets_1()
	{
		text.text = "Holding a mirror in your hand doesn't make the sheets look " +
					"any better.\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell_mirror;
		}
	}

	void State_Lock_0()
	{
		text.text = "This is one of those button locks. You have no idea what the " +
					"combination is. You wish you could somehow see where the dirty " +
					"fingerprints were, maybe that would help.\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell;
		}
	}

	void State_Lock_1()
	{
		text.text = "You carefully put the mirror through the bars, and turn it round " +
					"so that you can see the lock. You can just make out fingerprints around " +
					"the buttons. You press the dirty buttons, and here a click.\n\n" +
					"Press O to Open or R to Return to your cell";
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell_mirror;
		}
		else if (Input.GetKeyDown(KeyCode.O))
		{
			myState = States.freedom;
		}
	}
	void State_Mirror()
	{
		text.text = "The dirty old mirror on the wall seems loose.\n\n " +
					"Press T to Take the mirror or R to Return to your cell";
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell;
		}
		else if (Input.GetKeyDown(KeyCode.T))
		{
			myState = States.cell_mirror;
		}
	}

	void State_Cell_Mirror()
	{
		text.text = "You are still in your cell and you STILL want to excape! There are "+
					"some dirty sheets on the bed, a mark where the mirror was "+
					"and that pesky door is still there and firmly locked!\n\n " +
					"Press S to view Sheets or L to view Lock";
		if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.sheets_1;
		}
		else if (Input.GetKeyDown(KeyCode.L))
		{
			myState = States.lock_1;
		}
	}

	void State_Freedom()
	{
		text.text = "You are FREE!\n\n " +
					"Press P to play again";
		if (Input.GetKeyDown(KeyCode.P))
		{
			myState = States.cell;
		}
	}
}
