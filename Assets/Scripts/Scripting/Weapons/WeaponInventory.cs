using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{
    public List<Weapon> activeWeapons = new List<Weapon>(2); //stores the left hand weapon at index 0 and the right hand weapon at index 1
    public List<Weapon> weaponList; //a list of all weapons

    /*public HandActual leftHA;
    public HandActual rightHA;


    private void Update() {
        if(leftHA =)
    }*/

    private void Start() {
        activateWeapons();
    }

    public void addWeapon(Weapon weapon)
    {
        weaponList.Add(weapon);
    }


    public void activateWeapons()
    {
        setActiveWeapon(weaponList[0], Hand.LEFT);
        setActiveWeapon(weaponList[1], Hand.RIGHT);
    }


    public void setActiveWeapon(Weapon weapon, Hand h)
    {
        activeWeapons[(int) h] = weapon;
        weapon.setHand(h);
    }


    //returns the active weapon in the given hand
    public Weapon getActiveWeapon(Hand h)
    {
        return activeWeapons[(int) h];
    }

    //make w2 the active weapon of the hand for which w1 was previously the active weapon
    //returns if the swap was successful
    public bool swapActiveWeapon(Weapon replaceWeapon, Weapon newWeapon)
    {
        if(weaponList.Contains(newWeapon) && activeWeapons.Contains(replaceWeapon))
        {
            setActiveWeapon(newWeapon, (Hand) activeWeapons.IndexOf(replaceWeapon));
            //activeWeapons[activeWeapons.IndexOf(replaceWeapon)] = newWeapon;
            return true;
        }
        return false;
    }

    //places weapon w into the given hand
    //returns if the swap was successful
   /* public bool swapActiveWeapon(Weapon w, Hand h)
    {
        if(weaponList.Contains(w))
        {
            setActiveWeapon()
            return true;
        }    
        return false;
    }*/

}