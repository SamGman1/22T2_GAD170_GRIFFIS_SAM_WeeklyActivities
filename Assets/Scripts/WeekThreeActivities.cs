using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamGriffis
{
    public class WeekThreeActivities : MonoBehaviour
    {

        public int strengthOne = 0;
        public int intelligenceOne = 0;
        public int agilityOne = 0;
        public float playerOnePower;

        public int strengthTwo = 0;
        public int intelligenceTwo = 0;
        public int agilityTwo = 0;
        public float playerTwoPower;









        // Start is called before the first frame update
        void Start()
        {

            strengthOne = Random.Range(0, 10);
            intelligenceOne = Random.Range(0, 10);
            agilityOne = Random.Range(0, 10);

            playerOnePower = (strengthOne * 2 + agilityOne * 1.5f + intelligenceOne) * 10;
            

            strengthTwo = Random.Range(0, 10);
            intelligenceTwo = Random.Range(0, 10);
            agilityTwo = Random.Range(0, 10);

            playerTwoPower = (strengthTwo * 2 + agilityTwo * 1.5f + intelligenceTwo) * 10;


            Debug.Log("Sam Griffis");
            Debug.Log(playerOnePower);
            Debug.Log(playerTwoPower);

            if (playerOnePower > playerTwoPower) Debug.Log("Player 1 Wins!");
            else Debug.Log("Player 2 Wins!");

   


        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


