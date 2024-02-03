using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{

    [SerializeField] string characterName = "Enter character name here.";
    [SerializeField] int proficiencyBonus = 2;
    [SerializeField] bool finesseWeapon = false;
    [SerializeField]
    [Range(-5, 5)] int STR = 5;
    [SerializeField]
    [Range(-5, 5)] int DEX = 5;


   // int d20 = Random.Range(0, 20);


    // Start is called before the first frame update
    void Start()
    {
        int hitModifier = 0;
       
            if (finesseWeapon == false)
            {
                hitModifier = STR + proficiencyBonus;

            }
            else if (STR < DEX) 
            {
                hitModifier = DEX + proficiencyBonus;
            }
            else
            {
            hitModifier = STR + proficiencyBonus;
            }

            if (hitModifier > 0)
            {
            Debug.Log(characterName + "'s hit modifier is +" + hitModifier);
            }
            else
            {
            Debug.Log(characterName + "'s hit modifier is " + hitModifier);
            }
        
       
        int enemyAC = Random.Range(10, 20);
        Debug.Log("Enemy AC is " + enemyAC);
        int playerRoll = Random.Range(0, 20);
        Debug.Log(characterName + " rolled a " +  playerRoll);
        int enemyRoll = Random.Range(0, 20);

        if (playerRoll >= enemyAC)
        {
            Debug.Log("Enemy is hit!");
        }
        else
        {
            Debug.Log(characterName + " misses!");
        }
     

 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
