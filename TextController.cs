using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {laying, cell, cell_basic, mirror_0, mirror, cloth_1, cell_cloth, broken_mirror, 
						rat_0, rat_1, rat, door_0, lock_0, lock_1, lock_2, end_life, game_over, game_over_0, game_over_1, dead_rat, 
						nibble, carcass, rat_bone, guard, scrawl, escape};
	private States myState; 		
									

	// Use this for initialization
	void Start () {
		myState = States.laying; 
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.laying)			{state_laying();} 
		else if (myState == States.cell)		{state_cell();}
		
		if (myState == States.cell)				{state_cell();} 
		else if (myState == States.mirror_0)	{state_mirror_0();}
		else if (myState == States.rat_0)		{state_rat_0();} 
		else if (myState == States.cloth_1)		{state_cloth_1();}
		
		if (myState == States.cell_basic)		{state_cell_basic();}
		else if (myState == States.mirror_0)	{state_mirror_0();}
		else if (myState == States.rat_0)		{state_rat_0();} 
		else if (myState == States.cloth_1)		{state_cloth_1();}
		
		if (myState == States.cell_cloth)		{state_cell_cloth();}
		else if (myState == States.rat_1)		{state_rat_1();}
		else if (myState == States.door_0)		{state_door_0();} 
		else if (myState == States.mirror)		{state_mirror();}
		
		if (myState == States.broken_mirror)	{state_broken_mirror();}
		else if (myState == States.lock_0)		{state_lock_0();}
		else if (myState == States.end_life)	{state_end_life();} 
		else if (myState == States.rat)			{state_rat();}
		
		if (myState == States.game_over)		{state_game_over();}
		if (myState == States.guard)			{state_guard();}
		if (myState == States.scrawl)			{state_scrawl();}
		if (myState == States.escape)			{state_escape();}
		
		if (myState == States.dead_rat)			{state_dead_rat();}
		else if (myState == States.lock_1)		{state_lock_1();}
		else if (myState == States.nibble)		{state_nibble();} 
		else if (myState == States.carcass)		{state_carcass();}
		
		if (myState == States.rat_bone)			{state_rat_bone();}
		else if (myState == States.lock_2)		{state_lock_2();}
	} 
		
	void state_laying(){
		text.text = "You are awakened by a throbbing pain pulsing from your head. " + 
					"You begin to stand, only to stumble back down to the ground. " +
					"As your eyes adjust you notice that there are stone brick walls surrounding you. " + 
					"Holding your bloodied knees to your chest you realize how cold you are, and soon after, how frightened. " + 
					"After reality sets in, only one thought crosses your mind, 'Escape at all costs.' \n\n " +
					"Press 'G' key to Get up" ;
		if (Input.GetKeyDown(KeyCode.G))			{myState = States.cell;} 	
	}
	//Stage: Cell
	void state_cell(){
		text.text = "You begin to explore the small confined space. You find a door, but it is locked and cannot be forced open. " + 
					"A rat scurries over your foot towards a corner, and as you follow it you see a tattered cloth. " +
					"As you move to investigate you catch a dark figure shifting in the corner of your eye. " + 
					"After slowly approaching it you recognize your reflection in a mirror hanging off the wall. " + 
					"You realize the only way to escape is to use the resources available. \n\n " +
					"Press 'M' to view mirror, 'C' to view cloth, and 'R' to view rat" ;
		if (Input.GetKeyDown(KeyCode.M))			{myState = States.mirror_0;} 	
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.rat_0;}
		else if (Input.GetKeyDown(KeyCode.C))		{myState = States.cloth_1;}
	
	}
	
	void state_mirror_0(){
		text.text = "You approach the mirror and attempt take it off the wall, but it's well secured and won't budge. " + 
					"You could probably break it but the risk of cutting yourself is dangerously high.\n\n " +
					"Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.Backspace))		{myState = States.cell_basic;}
	}
	
	void state_rat_0(){
		text.text = "You attempt to capture the rat but you can't seem to keep a hold on it. " + 
					"You stop and wonder what you would even do with it once you caught it.\n\n " +
					"Press 'Back Space' to return";
			if (Input.GetKeyDown(KeyCode.Backspace))		{myState = States.cell_basic;}
	} 
		
	void state_cloth_1(){
		text.text = "Although it is in rough shape, you believe that the cloth could have some uses.\n\n " +
					"Press 'T' to take, or Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.T))				{myState = States.cell_cloth;}
		else if (Input.GetKeyDown(KeyCode.Backspace))	{myState = States.cell_basic;}	 	
	}
	//Stage: Cell_Basic
	void state_cell_basic(){
		text.text = "You are trapped in the cell and you need to escape. " + 
					"All you have at your disposal is a mirror, a tattered cloth, and a squeaky rat .\n\n " +
					"Press 'M' to view mirror, 'C' to view cloth, and 'R' to view rat";
		if (Input.GetKeyDown(KeyCode.M))				{myState = States.mirror_0;}
		else if (Input.GetKeyDown(KeyCode.R))			{myState = States.rat_1;}
		else if (Input.GetKeyDown(KeyCode.C))			{myState = States.cloth_1;} 	
	}
	//Stage: Cell_Cloth
	void state_cell_cloth(){
		text.text = "You have obtained the cloth, but now you wonder how you could use it.\n\n " +
					"Press 'M' to view mirror, 'D' to view door, and 'R' to view rat";
		if (Input.GetKeyDown(KeyCode.M))				{myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.R))			{myState = States.rat_1;}
		else if (Input.GetKeyDown(KeyCode.D))			{myState = States.door_0;} 	
	}
	
	void state_rat_1(){
		text.text = "You attempt to capture the rat using the cloth and you are succesful! " + 
					"However, before you can figure out what to do with it, the rat escapes from a hole in the cloth.\n\n " +
					"Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.Backspace))		{myState = States.cell_cloth;}
	} 
	
	void state_door_0(){
		text.text = "You approach the door and begin to study it for any sign of weakness. " + 
					"You discover that the bars are big enough for you to fit your hands through. " + 
					"After feeling around you discover a lock on the other side, but that's it ...\n\n " +
					"Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.Backspace))		{myState = States.cell_cloth;}
	}
	
	void state_mirror(){
		text.text = "Since the mirror can not be ripped from the wall, maybe you can break it and put the shards to use. " + 
					"Now that you have the cloth you have protection from the broken glass! \n\n " +
					"Press 'B' to break, or Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.B))				{myState = States.broken_mirror;}
		else if (Input.GetKeyDown(KeyCode.Backspace))	{myState = States.cell_cloth;}	 	
	} 
	
	//Stage: Broken_Mirror
	void state_broken_mirror(){
		text.text = "The mirror has broken into multiple pieces. You wonder how you can utilize the shards. \n\n " +
					"Press 'L' to view lock, 'S' to view shards, and 'R' to view rat";
		if (Input.GetKeyDown(KeyCode.L))				{myState = States.lock_0;}
		else if (Input.GetKeyDown(KeyCode.S))			{myState = States.end_life;}
		else if (Input.GetKeyDown(KeyCode.R))			{myState = States.rat;} 	
	}
	
	void state_lock_0(){
		text.text = "You use a piece of the glass to get a look at the lock on the outside of the door. " + 
					"It appears to be an old lock that requires an old-fashioned key to open.\n\n " +
					"Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.Backspace))		{myState = States.broken_mirror;}
	} 
	
	void state_end_life(){
		text.text = "You pick up a piece of the mirror and look at the partial reflection of yourself. " + 
					"As you stare into your own bloodshot eyes you begin to recognize an impeding sense of hopelessness. " +
					"All concern of how you came to be here fades away, and all you are left with is the desire to escape. " +
					"Suddenly the answer is clear to you. you have found the way out ... \n\n " +
					"Press 'X' to Escape, Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.Backspace))		{myState = States.broken_mirror;}
		else if (Input.GetKeyDown(KeyCode.X))			{myState = States.game_over;}
	}
	
	void state_game_over(){
		text.text = "Your vision begins to fade and you drop to your knees as you feel yourself slipping out of consciousness. " + 
					"An unfamiliar sensation of warmth slowly envelops you as you lay yourself down, curling into a fetile position. " +
					"You revel in your final moments, 'I have escaped.' \n\n " +
					"GAME OVER \n\n" +
					"Press 'Enter' for main menu";
		if (Input.GetKeyDown(KeyCode.Return))		{Application.LoadLevel ("Start_Menu");}

	}		
	
	void state_rat(){
		text.text = "You chase after the rat and capture it easily using the torn cloth. \n\n " + 
					"Press 'K' to kill, or Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.K))				{myState = States.dead_rat;}
		else if (Input.GetKeyDown(KeyCode.Backspace))	{myState = States.broken_mirror;}	 	
	}
	
	//Stage: Dead_Rat
	void state_dead_rat(){
		text.text = "Using your primal instincts you were able to capture and decapitate the rat. " + 
					"Now you are left holding a carcass wondering how to make use of it.\n\n " +
					"Press 'N' to nibble, 'L' to view lock, and 'C' to view carcass";
		if (Input.GetKeyDown(KeyCode.N))				{myState = States.nibble;}
		else if (Input.GetKeyDown(KeyCode.L))			{myState = States.lock_1;}
		else if (Input.GetKeyDown(KeyCode.C))			{myState = States.carcass;} 	
	}
	
	void state_nibble(){
		text.text = "You look at the blood-covered lifeless lump in your hand when suddenly a frightening noise " +
					"erupts from within you. Shocked, you realize that you cannot remember the last time you have eaten. " +
					"you are quick to realize just how famished you are. On impulse, you take a bite from your prey. " +  
					"You immediately regret your decision as you spit the putrid flesh from your mouth.\n\n " +
					"Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.Backspace))		{myState = States.dead_rat;}
	} 
	
	void state_lock_1(){
		text.text = "You go back to the lock and just stare hopelessly at it. " + 
					"You think to yourself, 'someone must be coming with the key, I need to get that key!' \n\n " +
					"Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.Backspace))		{myState = States.dead_rat;}
	}
	
	void state_carcass(){
		text.text = "You hold the dead rat in your hands and move it around, hoping for inspiration. " + 
					"Suddenly a sharp pain shoots into your hand, and you realize the leg bone is broken " +
					"and has stabbed you. You are surprised at how strong the thin bone actually is. " +
					"It's in this moment that you have a brilliant idea. \n\n " +
					"Press 'B' to butcher, or Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.B))				{myState = States.rat_bone;}
		else if (Input.GetKeyDown(KeyCode.Backspace))	{myState = States.dead_rat;}	 	
	} 
	//Stage: Rat_Bone
	void state_rat_bone(){
		text.text = "Using the left over shards of glass you manage to scavenge a single leg bone from the carcass." +
					"Unfortunately, due to the crude blade the rest of the rat is destroyed. " + 
					"However, this doesn't phase you, because you know exactly what to do from here. \n\n" +
					"Press 'G' to wait for a guard, 'L' to view lock, and 'S' to scrawl a message";
		if (Input.GetKeyDown(KeyCode.G))				{myState = States.guard;}
		else if (Input.GetKeyDown(KeyCode.S))			{myState = States.scrawl;}
		else if (Input.GetKeyDown(KeyCode.L))			{myState = States.lock_2;} 	
	} 
	
	void state_guard(){
		text.text = "You have decided. You wait patiently because you know there must be a keeper watching you. " + 
					"You have no method of telling time other than the slow depletion of remaining energy you have. " +
					"After what you can only assume as days, the cell door opens! You waste no time " + 
					"launching your attack glass and bone shiv in hand, you thrust towards the guard, but the outcome is already clear. " +
					"You are too weak. The guard disarms you and with a swift crack on the head, you are gone. \n\n" +
					"GAME OVER \t\t\t" +
					"Press 'Enter' for main menu.";
		if (Input.GetKeyDown(KeyCode.Return))		{Application.LoadLevel ("Start_Menu");}
	}
	
	void state_scrawl(){
		text.text = "You know by now that escape is hopeless, no one is coming for you. In a last act of self-preservation " + 
					"you take the bone and begin to carve into the brick walls, scratching in your last will and testement. " +
					"Finally, after what can only be days, you finish and drop the remaining nub that was once a rat's femur. " + 
					"You give yourself to the darkness, curling into a ball, and fading away like all the hope you once had. \n\n" +
					"GAME OVER \t\t\t" +
					"Press 'Enter' for main menu.";
		if (Input.GetKeyDown(KeyCode.Return))		{Application.LoadLevel ("Start_Menu");}
		
	}		
	
	void state_lock_2(){
		text.text = "You approach the door and slip your hands between the bars. Using the mirror you can see the keyhole clearly. " +
					"It looks like a very old lock, maybe the bone you scavenged will fit \n\n " + 
					"Press 'P' to pick, or Press 'Back Space' to return";
		if (Input.GetKeyDown(KeyCode.P))				{myState = States.escape;}
		else if (Input.GetKeyDown(KeyCode.Backspace))	{myState = States.rat_bone;}	 	
	} 
	
	void state_escape(){
		text.text = "You push the bone into the keyhole and frantically wiggle it around, trying to get the tumblers in alignment. " + 
					"*Click* Your ears perk, you turn the locking mechanism and push on the door. " +
					" Never has such a high pitched screeching sounded so beautiful to you. " + 
					"You slowly make your way into the corridor.\n" +
					"You have escaped ... for now. \n" +
					"TO BE CONTINUED \n\n" +
					"Press 'Enter' to relive the nightmare";
		if (Input.GetKeyDown(KeyCode.Return))		{Application.LoadLevel ("Start_Menu");}
	} 
	
}
