using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonScript : MonoBehaviour {
    public PokemonScript text;

    private enum States {intro, field, battle}
    private States playerState;
	// Use this for initialization
	void Start () {
        playerState = States.intro;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerState == States.intro)
        {
            intro();
        }
	}

    void intro (){
        text.text = "You begin your journey as a Pokemon trainer in the Kanto region. You see Pidgey's and Sparrows flying around, Rattatas running through the tall grass, you are ready to begin your adventure.\n\n" +
            "[ ] Press ";
    }
}
