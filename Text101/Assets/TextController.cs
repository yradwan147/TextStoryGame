using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	private enum States {cell, sheets_0, sheets_roommate, lock_0, lock_mirror, mirror, cell_mirror, weird_hallway_0, sleep, roommate, killmyself, roommate_death
		,weird_hallway_1, hallway_0, hallway_1, wall_0, wall_1, cell_roommate, cell_roommate_mirror, cell_roommate_wall, lock_roommate, wall_mirror
		,weird_hallway_0_death, weird_hallway_0_death2, hallway_tackle, closet, weird_hallway_1_tackle, betrayer, goodguy, hold_ground, run_away, funny_face
		, scream, improvise, hallway_1_tackle, hallway_1_closet, sheets_mirror, broke_mirror, sleep_mirror};
	private States myState;
	
	// Use this for initialization
	void Start () {
		
		myState = States.cell;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		print (myState);
		if (myState == States.cell) {state_cell();}
		else if (myState == States.sheets_0) {state_sheets_0();}
		else if (myState == States.sheets_roommate) {state_sheets_roommate();}
		else if (myState == States.lock_0) {state_lock();}
		else if (myState == States.lock_mirror) {state_mirror_lock();}
		else if (myState == States.mirror) {state_mirror();}
		else if (myState == States.cell_mirror) {state_cell_mirror();}
		else if (myState == States.weird_hallway_0) {state_weird_hallway_0();}
		else if (myState == States.weird_hallway_1) {state_weird_hallway_1();}
		else if (myState == States.hallway_0) {state_hallway_0();}
		else if (myState == States.hallway_1) {state_hallway_1();}
		else if (myState == States.wall_0) {state_wall_0();}
		else if (myState == States.wall_1) {state_wall_roommate();}
		else if (myState == States.cell_roommate) {state_cell_roommate();}
		else if (myState == States.cell_roommate_mirror) {state_mirror_roommate();}
		else if (myState == States.cell_roommate_wall) {state_wall_roommate();}
		else if (myState == States.lock_roommate) {state_lock_roommate();}
		else if (myState == States.wall_mirror) {state_mirror_wall();}
		else if (myState == States.sleep) {sleep();}
		else if (myState == States.roommate) {state_roommate();}
		else if (myState == States.roommate_death) {roommate_death();}
		else if (myState == States.weird_hallway_0_death) {weird_hallway_0_death();}
		else if (myState == States.weird_hallway_0_death2) {weird_hallway_0_death2();}
		else if (myState == States.hallway_tackle) {hallway_tackle();}
		else if (myState == States.closet) {closet();}
		else if (myState == States.weird_hallway_1_tackle) {weird_hallway_1_tackle();}
		else if (myState == States.betrayer) {Betrayer_Ending();}
		else if (myState == States.goodguy) {GoodGuyEnding();}
		else if (myState == States.hold_ground) {hold_ground();}
		else if (myState == States.run_away) {run_away();}
		else if (myState == States.funny_face) {funny_face();}
		else if (myState == States.scream) {scream();}
		else if (myState == States.improvise) {improvise();}
		else if (myState == States.hallway_1_tackle) {hallway_1_tackle();}
		else if (myState == States.hallway_1_closet) {hallway_1_closet();}
		else if (myState == States.sheets_mirror) {state_sheets_mirror();}		
		else if (myState == States.broke_mirror) {broke_mirror();}	
		else if (myState == States.sleep_mirror) {sleep_mirror();}				
		
	}
	
	void state_cell() {
		text.text = "You are in a prison cell, and you want to escape. Your roommate is sleeping, there are " +
			"some dirty sheets on the bed, a mirror on the wall, and the door " +
				"is locked from the outside.\n\n" +
				"Press S to view Sheets, M to view Mirror, L to view Lock, R to talk to Roommate, W to inspect wall" ;
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.sheets_0;}
		else if (Input.GetKeyDown(KeyCode.M)) {myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.lock_0;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.roommate;}
		else if (Input.GetKeyDown(KeyCode.W)) {myState = States.wall_0;}
	}
	
	void state_sheets_0() {
		text.text = "Holy shit, these sheets smell like dog poop, what were you doing last night?\n\n" + 
			"Press S to Sleep or R to Return";
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.sleep;}
	}
	
	void state_sheets_mirror() {
		text.text = "Holy shit, these sheets smell like dog poop, what were you doing last night?\n\n" + 
			"Press S to Sleep or R to Return";
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.sleep_mirror;}
	}
	
	void sleep_mirror() {
		text.text = "Nibba, we have escaping to do, there's no time to sleep\n\n"+ "Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
	}
	
	void sleep() {
		text.text = "Nibba, we have escaping to do, there's no time to sleep\n\n"+ "Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
	}
	
	void state_lock() {
		text.text = "Just a plain game lock, and no you can't break it with your hands\n\n" + 
			"Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
	}
	
	void state_wall_0() {
		text.text = "Nice wall... You admire it for a while then decide to smash your head in to end your misery, sadly you don't die and you" + 
			" actually loosen the brick revealing a secret hallway\n\n" + 
			"Press G to somehow go through the 1x1 hole because of game logic or R to Return";
		if (Input.GetKeyDown(KeyCode.G)) {myState = States.weird_hallway_0;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
	}
	
	void state_mirror() {
		text.text = "The dirty old mirror on the wall seems loose.\n\n" +
			"Press T to Take the mirror, or R to Return to cell" ;
		if (Input.GetKeyDown(KeyCode.T)) {myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
	}
	
	void state_roommate() {
		text.text = "You go to poke your roommate, you've been roommates for 2 years but have never actually talked" +
		" because you're a pussy or sorry I meant the game character was a pussy, not you ofcourse :D ," +
		" Anyway he agrees to help you as long as you promise him freedom\n\n" +
		"Press P to promise him, R to refuse and insult him, L to just leave";
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell_roommate;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.roommate_death;}
		else if (Input.GetKeyDown(KeyCode.L)){myState = States.cell;}
	}
	
	void roommate_death(){
		text.text = "Oh I forgot to tell you, he's an ex heavyweight champion" +
			" but I don't think that would've changed anything, let's just say that he kills you pretty much\n"+
				"Well sucks to suck but you lost D:\n\n" +
				"Press P to Play again or K to kill yourself" ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.K)) {
		System.Threading.Thread.Sleep(3000);
		text.text = "Sorry I'm only a sarcastic computer narrator, I can't do that\n\n"+
			"Press P to Play Again";}
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
		}
	
	void state_cell_roommate() {
		text.text = "You stand in the room with your roommate, he tells you that he knows how to lockpick so you decide to...\n\n"+
					"Press L to go pick cell lock, S to inspect sheets, M to inspect mirror, W to inspect wall";
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.sheets_roommate;}
		else if (Input.GetKeyDown(KeyCode.M)) {myState = States.cell_roommate_mirror;}
		else if (Input.GetKeyDown(KeyCode.W)) {myState = States.cell_roommate_wall;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.lock_roommate;}
	}
	
	void state_cell_mirror() {
		text.text = "With the slightly shattered mirror in hand, you decide to masturb.. I mean you decide to...\n\n"+
			"Press L to inspect lock, S to inspect sheets, W to inspect wall";
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.sheets_mirror;}
		else if (Input.GetKeyDown(KeyCode.W)) {myState = States.wall_mirror;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.lock_mirror;}
	}
	
	void state_lock_roommate() {
		text.text = "Your roommate is picking the lock but you hear a guard coming, your roommate tells you to do something!\n\n"+
			"Press M to make a funny face, S to scream, I to improvise";
		if (Input.GetKeyDown(KeyCode.M)) {myState = States.funny_face;}
		else if (Input.GetKeyDown(KeyCode.S)) {myState = States.scream;}
		else if (Input.GetKeyDown(KeyCode.I)) {myState = States.improvise;}
	}
	
	void funny_face(){text.text = "You make a funny face, unfortunately the guards aren't amused and so is your roommate so he decides to kick you in the balls and you die\n\n" +
		"What did you think was gonna happen?\n"+
			"Well sucks to suck but you lost D:\n\n" +
				"Press P to Play again or K to kill yourself" ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.K)) {text.text = "Sorry I'm only a sarcastic computer narrator, I can't do that\n\n"+
			"Press P to Play Again";}
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}}
	
	void scream(){text.text = "Suprisingly (note the sarcasm), the guard comes quicker and he catches you and your roommate, you get electrocuted to death, shoutout to my boi coptopus :p\n"+
		"Well sucks to suck but you lost D:\n\n" +
			"Press P to Play again or K to kill yourself" ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.K)) {text.text = "Sorry I'm only a sarcastic computer narrator, I can't do that\n\n"+
			"Press P to Play Again";}
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}}
	
	void improvise(){text.text = "You yell 'Hey guys, RIOOOOTTTT!!', all the inmates start causing trouble for some reason, zeita b2a" +
		" and your roommate was able to pick the lock before the guard came around, good job player :D\n\n" + "Press C to Continue";
		if (Input.GetKeyDown(KeyCode.C)){myState = States.hallway_1;}
		}
	
	void state_sheets_roommate() {
		text.text = "You stare at the bed sheets then at your roommate, raising your eyebrows seducingly. Sadly that lasts for about 3 seconds before your roommate" +
		" slaps you on the face\n\n"+
			"Press R return to cell";
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_roommate;}
}

	void state_mirror_roommate() {
		text.text = "You stare into the mirror and try not to feel pity for your roommate who is so ugly as shit like damn. Unfortunately, this narration can also be heard" +
		" by your roommate and u ded\n"+
		"Well sucks to suck but you lost D:\n\n" +
			"Press P to Play again or K to kill yourself" ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.K)) {text.text = "Sorry I'm only a sarcastic computer narrator, I can't do that\n\n"+
			"Press P to Play Again";}
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
	}
	
	void state_wall_roommate() {
		text.text = "Your roommate thinks its funny to give you a little shove. However your scrawny body can't take it and you launch right into the wall" +
		",breaking your right arm but at least you broke open the wall. It revealed a secret hallway, but breaking the wall also set the alarms off and now all" +
		" guards are converging on your position\n\n"+ 
		"Press H to hold your ground D:< or E to escape through the tunnel";
		if (Input.GetKeyDown(KeyCode.H)) {myState = States.hold_ground;}
		else if (Input.GetKeyDown(KeyCode.E)) {myState = States.weird_hallway_1;}
	}
	
	void hold_ground(){text.text = "You decide to hold your ground, weaponless against an army of ranged military soldiers and without backup as" +
		" your roommate ditched you and ran for the tunnel. And well I think you can guess what happened next... u ded fam\n"+
			"Well sucks to suck but you lost D:\n\n" +
				"Press P to Play again or K to kill yourself" ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.K)) {text.text = "Sorry I'm only a sarcastic computer narrator, I can't do that\n\n"+
			"Press P to Play Again";
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}}
		}
	
	void state_mirror_wall() {
		text.text = "Well, what do you want to do?\n\n"+
				"Press X to smash the mirror into the wall or R return to cell";
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.X)) {myState = States.broke_mirror;}
	}
	
	void broke_mirror(){text.text = "Well you broke it... now what?\n"+
		"Well sucks to suck but you lost D:\n\n" +
			"Press P to Play again or K to kill yourself" ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.K)) {text.text = "Sorry I'm only a sarcastic computer narrator, I can't do that\n\n"+
			"Press P to Play Again";}
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}}
	
	void state_mirror_lock() {
			text.text = "You carefully put the mirror through the bars, and turn it round " +
				"so you can see the lock. You can just make out fingerprints around " +
				"the buttons. You press the dirty buttons, and hear a click.\n\n" +
				"Press O to Open, or R to Return to your cell" ;
		if (Input.GetKeyDown(KeyCode.O)) {myState = States.hallway_0;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
}
	void state_hallway_1() {
			text.text = "You're standing in the hallway, you hear the patrol guards coming, what do you do?\n\n"+
			"Press T to tackle the guards or R to run to the nearby closet" ;
		if (Input.GetKeyDown(KeyCode.T)) {myState = States.hallway_1_tackle;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.hallway_1_closet;}
}

	void hallway_1_tackle(){text.text = "Your roommate made quick work of the guards and now they're unconscious on the floor, you take their" +
		" clothes and walk to the gate\n\n"+
			"Congratulations you escaped!\n" + 
				"The Friendship Ending\n" + "Press P to play again";
				if (Input.GetKeyDown(KeyCode.P)){myState = States.cell;}
				}
				
	void hallway_1_closet(){text.text = "You enter the closet and find spare worker clothes to wear, but there's only one costume...\n"+
		"You both look at each other... then your roommate tells you that he's sorry and with a tear in his eye, he punches you unconscious (so sad), you wake up back in your cell.\n\n" +
			"The Betrayed...\n"+
				"Well sucks to suck but you lost D:\n\n" +
				"Press P to Play again or K to kill yourself" ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.K)) {text.text = "Sorry I'm only a sarcastic computer narrator, I can't do that\n\n"+
			"Press P to Play Again";}
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}}

	void state_hallway_0() {
			text.text = "You're standing in the hallway, you hear the patrol guards coming, what do you do?\n\n"+
			"Press T to tackle the guards or R to run to the nearby closet" ;
		if (Input.GetKeyDown(KeyCode.T)) {myState = States.hallway_tackle;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.closet;}
		}
	
	void closet(){
	text.text = "You enter the closet and find spare worker clothes to wear, you wear them and sneak out to the gate\n\n" +
			"Congratulations you escaped!\n" + 
				"The Sneaky Ending\n" + "Press P to play again";
			if (Input.GetKeyDown(KeyCode.P)){myState = States.cell;}
			}
	
	void hallway_tackle(){
	text.text = "You attempt to tackle the guards but as I've mentioned before, I think, you're a puny 18 year old and" +
		" you get destroyed, no really..like captain america to iron man style\n"+
	"Well sucks to suck but you lost D:\n\n" +
			"Press P to Play again or K to kill yourself" ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.K)) {text.text = "Sorry I'm only a sarcastic computer narrator, I can't do that\n\n"+
															"Press P to Play Again";}
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
		}
		
	
	void state_weird_hallway_0() {
			text.text = "You're standing in the secret hallway, you hear someone coming, they look like cultists! what do you do?\n\n"+
			"Press T to tackle them or R to run away" ;
		if (Input.GetKeyDown(KeyCode.T)) {myState = States.weird_hallway_0_death;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.weird_hallway_0_death2;}
	}
	
	void weird_hallway_0_death2(){text.text = "You try to run away but they just use their ranged magic and one shot you, kinda like Fortnite.\n"+
		"Well sucks to suck but you lost D:\n\n" +
			"Press P to Play again or K to kill yourself" ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.K)) {
		System.Threading.Thread.Sleep(3000);
		text.text = "Sorry I'm only a sarcastic computer narrator, I can't do that\n\n"+
															"Press P to Play Again";}
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}}
	
	void weird_hallway_0_death(){
		text.text = "You attempt to tackle them but as I've mentioned before, I think, you're a puny 18 year old and" +
			" they also have magic wizard powers so you got destroyed, no really..like iron man to captain america style"+
	"Well sucks to suck but you lost D:\n\n" +
		"Press P to Play again or K to kill yourself";
	if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
	else if (Input.GetKeyDown(KeyCode.K)) {
	System.Threading.Thread.Sleep(3000);
	text.text = "Sorry I'm only a sarcastic computer narrator, I can't do that\n\n"+
		"Press P to Play Again";}
	if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}}
	
	void state_weird_hallway_1() {
			text.text = "You catch up with your roommate, you hear someone coming, they look like cultists! what do you do?\n\n"+
			"Press T to tackle them or R to run away" ;
		if (Input.GetKeyDown(KeyCode.T)) {myState = States.weird_hallway_1_tackle;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.run_away;}
	}
	
	void run_away(){text.text = "You try to run away but they just use their ranged magic and one shot you, kinda like Fortnite.\n"+
		"Well sucks to suck but you lost D:\n\n" +
			"Press P to Play again or K to kill yourself" ;
	if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
	else if (Input.GetKeyDown(KeyCode.K)) {text.text = "Sorry I'm only a sarcastic computer narrator, I can't do that\n\n"+
		"Press P to Play Again";
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}}
		}
	
	void weird_hallway_1_tackle(){
	text.text = "You attempt to tackle them but as I've mentioned before, I think, you're a puny 18 year old and" +
		" your roommate did all the work, he was able to kill them but he got injured badly, the gate is at the end of the hallway what do you do?\n\n"+
		"Press T to take roommate with you, R to run away and leave him";
		if(Input.GetKeyDown(KeyCode.R)){myState = States.betrayer;}
		if(Input.GetKeyDown(KeyCode.T)){myState = States.goodguy;}
		}
	
	void Betrayer_Ending(){
		text.text = "You decide to leave him, you ran away with a grin on your face as you showed him your middle finger (dramatic effect)\n\n"+
	"Congratulations you escaped!\n" + 
		"The Betrayer Ending\n" + "Press P to play again";
		if (Input.GetKeyDown(KeyCode.P)){myState = States.cell;}
}

	void GoodGuyEnding(){
	text.text = "You decide to help him out but that greatly reduces your speed. Now if I were evil I would make you die here" +
		" but I'm not that evil so you do manage to escape bearly\n\n"+
			"Congratulations you escaped!\n" + 
				"The Good Guy Ending\n" + "Press P to play again";
		if (Input.GetKeyDown(KeyCode.P)){myState = States.cell;}
		}
}