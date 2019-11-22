using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetHappinessSystemTest : MonoBehaviour
{
    /// <summary>
    /// These are the starting stats the pet gets when they are bought, these can be shown to the player when they purchase them
    /// These values shouldn't be at the max or min setting of their corresponding current value, but somewhere in between
    /// These should probably be assigned in the pet's class and then referenced
    /// </summary>
#region Base Stats

    /// <summary>
    /// this value is assigned at purchase and shown to the player, it is a number between 25 and 75
    /// </summary>
    float baseHappiness;

    /// <summary>
    /// this value is assigned at purchase and shown to the player, it is a number between 25 and 75
    /// </summary>
    float baseNeediness;

    /// <summary>
    /// this value is assigned at purchase and shown to the player, it is a number between 25 and 75
    /// </summary>
    float baseHunger;
#endregion

    /// <summary>
    /// These are the pets current stats, these are updated based on the players interactions with the pet
    /// </summary>
#region Current Stats

    /// <summary>
    /// Happiness is the most important variable in the game, if it reaches zero the pet dies
    /// It can be increased by interacting with the pet (food, petting, washing, etc)
    /// </summary>
    public float currentHappiness;

    /// <summary>
    /// Neediness affects how often the pet has to be interacted with as well as how quickly their happiness drops
    /// This is increased by the number of times the player interacts with them, too many interactions too quickly, or too few, will cause neediness to rise, Hunger can temporarily increase it
    /// </summary>
    public float currentNeediness;

    /// <summary>
    /// Hunger affects happiness and neediness directly, the longer without food the hungrier the pet gets and the needier they become while happiness falls
    /// </summary>
    public float currentHunger;
#endregion

    /// <summary>
    /// Multipliers are values that increase or decrease how the pets Hunger, Happiness, Neediness are affected, they are unique to each pet and are assigned at purchase
    /// These numbers should not go over 2 and should not equal 0
    /// </summary>
#region Multipliers

    /// <summary>
    /// Multiplied with the pets Neediness value to determine how much the Neediness value affects Happiness
    /// </summary>
    float needinessMult;

    /// <summary>
    /// Multiplied with the pet's Hunger value to determine how much the Hunger value affects Happiness
    /// </summary>
    float hungerMult;

    /// <summary>
    /// Multiplied with the pet's current outfit value to determine how high they can score in a fashion show
    /// </summary>
    float fashionOutfitValueMult;
#endregion


    /// <summary>
    /// This is how long it has been since the player has interacted with the pet, it should keep running even while the player is purchasing items in a store, but not while the pet is involved in an activity
    /// This can affect the neediness of the pet, if the value is too high or too low then the pet's neediness increases
    /// </summary>
    public int timeWithoutInteraction;

    /// <summary>
    /// The amount of time it has been since the pet has been fed.
    /// </summary>
    public int timeWithoutFood;

    /// <summary>
    /// This is how much whatever action is being performed affects the pets happiness
    /// </summary>
    public int interactionHappinessValue;

    /// <summary>
    /// Rewarded to the player per event (fashion show, race)
    /// </summary>
    public int EventHappinessValue;

    /// <summary>
    /// Rewarded to the player per event (fashion show, race)
    /// </summary>
    public int EventMoneyValue;

    private void Start()
    {
        SetStartingHappiness();
        SetStartingHunger();
        SetStartNeediness();
    }

    private void Update()
    {
        CalculateCurrentHunger();
        CalculateCurrentNeediness();
    }

    public void SetStartingHappiness()
    {
        currentHappiness = baseHappiness;
    }
    public void SetStartingHunger()
    {
        currentHunger = baseHunger;
    }
    public void SetStartNeediness()
    {
        currentNeediness = baseNeediness;
    }

    public void CalculateCurrentHunger()
    {
        //TODO: Should these be multiplied or added? Need to test        
        currentHunger = currentHunger * hungerMult * timeWithoutFood;
    }

    public void CalculateCurrentNeediness()
    {
        //TODO: Should these be multiplied or added? Need to test
        currentNeediness = currentNeediness * needinessMult * timeWithoutInteraction;
    }

}