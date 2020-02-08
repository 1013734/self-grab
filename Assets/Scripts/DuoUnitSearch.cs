using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuoUnitSearch : MonoBehaviour {

	
	// need state machine, moving, searching, attacking, dead, enraged.
	// if partner is not within radius && not in combat, begin searching for them.
	// if partner is inside radius && in combat, attack same enemy.
	// if partner dies while inside radius, state enraged (boosted stats).
	// if partner dies outside of radius, ignore partner details and continues as solo unit with moving, attack, dead states.

}
