using UnityEngine;
using System.Collections;


public class zombiestuff : MonoBehaviour {

	public Rigidbody zrbody;
	public AudioClip hitsound ;
	private int randommove;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		zrbody = GetComponent<Rigidbody>();
		audio = GetComponent<AudioSource>();

		randommove = Random.Range(1, 4);

		Debug.Log(randommove);
		whatmove(randommove);
	}
	
	// Update is called once per frame
	void Update () {

	}
    //Zombie Rises from the grave
    //Play animation rise from grave
    //Play sound rise from grave
    //Turns in regular zombie object

	void OnMouseOver () {
        //This is where zombie is killed 
		if(Input.GetMouseButtonDown(0)){
            //Head animation Big bulgy squash....
            //Gets smaller when pressed to stimulate pressure on its head... 
            //gameObject.zombiehead shrinks 25%
            //gameObject.zombiehead expands 5%  20% of original size 
            //This is the pinch and bulge to never have a linear animation and to making things feel squishy like in disney to over extend then bring back 5%
            //When player depresses his face
            //gameObject.zombiehead expands to 125% original size 
            //Then to pull back in to Original 120%
            //Pops  
            Destroy(this.gameObject);
            //Plays the most satisfying pops 
			audio.PlayOneShot(hitsound, 0.7F);
            //audio.PlayOneShot((AudioClip)Resources.Load("smw_coin"));
            //Vibrate to give haptic feeback
            //Adds +1 Score
            //Take 1 from clipsize

            //Adds +1 to chain this is to count how many successive zombies in a row the player has shot
            //OnMouseMiss Reset Chain Score
            //             Place bullet decal in centre of press
            //             Play bullet miss sound 

            //If they have shot 10 in a row +10% spawn rate. 
            //For every time speed reaches a milestone, every 50% it stays at that speed 20 seconds , though this will be chnaged in testing. This is to stop it just ramping up crazy fast and build them

            //If they have missed 2 in a row -10% spawn rate

            //If the have shot 15 in a row enter Star mode
            //Music changes to highlight new bonus mode
            //Lights and fireworks go off make this shit look pretty  
            //Heads now into glowing balls (glowing effect added to their object)
            //They can now be swipped into the nets
            //Disable current controls for shooting
            //Hide any Gui with Shooting
            //Camera pans back revealing the two nets
            //Create two net objects
            //Create 2 smoke particle effects to spawn on top
            //Play Spawing sounds
            //Nets buldge and appear in 
            //Play mash 4 cash annoucher sound to notify gamer mode has starter
            //Should there be a wind and each level wind changes making it harder?


            //Particle trail from the zombie heads as they fly towards the net
            //Let the head bounce off the sids of the screen
            //Create collision box for ball based upon camera view.
            //Create null object to parent to Collision box
            //Null object to be based upon the center of camera view 
            //Fireworks go off when goal goes in
            //GOAL appear on screen
            //+1 is added to score multiplier b for when(a x b)= score when a = current score, This is the only place for now where you can add to b , this is all subject for now and will play test to see how the scores fare



            Debug.Log ("hello");
		}
		if(Input.GetMouseButtonDown(1)){
			moveleft(500);
		}
		if(Input.GetMouseButtonDown(2)){
			moveright(500);
		}
        
    }



    void whatmove(int randommove){
		switch(randommove){
		case 1:
			moveup(500);
			break;
		case 2:
			moveright(500);
			break;
		case 3:
			moveleft(500);
			break;
		case 4:
			movedown(500);
			break;
		}

	}
    //I think this controls the spawner direction and force 
	void moveup(int zforce){
		zrbody.AddForce(transform.forward * zforce);
	}

    //For now they need to just go left
    //Have several planes that which they could come out of , 3 lanes on the right and then 3 spots that they can pull themselves up from
    
	void moveright(int zforce){
		zrbody.AddForce(transform.right * zforce);
	}
	void moveleft(int zforce){
		zrbody.AddForce(-transform.right * zforce);
	}
	void movedown(int zforce){
		zrbody.AddForce(-transform.forward * zforce);

        //Added secret special bonus to slow zombies 20% for the last inch they are on the screen to create more tension

        //if player hits trigger boxes then slow movement 20%
        //Play audio sound of zombies going aaaaaa but in like a way you got no teeth or a tounge or a will to live this as subtle hint
        //5 Zombie grunts sounds to randonmly select from 
    }

    //If they get to 10% Danger area , thinking of either having a tower which they can maul down, or just walk free to eat all the people we just left in the side room
    //This will be how they lose life or enter end game state
    //Fot now they get to 10% and stop but start attackign the side
    //PLay Zombie attacking animation
    //Play Zombie attacking sound
    //Play Smoke particle effect
    //Take Damage from Zombie but add a random chance to miss to mix it up a little
    //Play white flash when Damage take 

   


    //Bonus 5 headshots in a row and hold to get grenade head explosion
    //Additional splash damage to hit surround zombies
    //Play lovely satisfying explsion sound

}
