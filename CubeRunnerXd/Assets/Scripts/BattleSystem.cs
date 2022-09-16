using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, PLAYERONE, PLAYERTWO, WON, LOST }//Create states
public class BattleSystem : MonoBehaviour
{
    public GameObject playerOnePrefab;
    public GameObject playerTwoPrefab;

    public Transform playerOneBattleStation;
    public Transform playerTwoBattleStation;

    
    public BattleState state;
    

 
    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();

    }

    void SetupBattle()
    {
       GameObject playerOneGo = Instantiate(playerOnePrefab, playerOneBattleStation); //Referencing the object on where to spawn
       playerOneGo.GetComponent<Unit>();
       GameObject playerTwoGo = Instantiate(playerTwoPrefab, playerTwoBattleStation);

    }
}
