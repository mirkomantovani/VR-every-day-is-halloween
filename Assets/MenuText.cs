using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuText : MonoBehaviour {

    public static readonly String ELEVATOR_NEED_ACTIVATION = "Activate elevator with key";
    public static readonly String ELEVATOR_ACTIVE = "Elevator activated";
    public static readonly String SPIDER_BURROW = "You are in a spider burrow!";
    public static readonly String CLIMB_HINT = "Climb the wall!";
    public static readonly String ROOM4_HINT = "Find a potion to dispel werewolf!";
    public static readonly String ROOM2 = "Welcome to ROOM II";
    public static readonly String ROOM3 = "Welcome to ROOM III";
    public static readonly String ROOM4 = "Welcome to ROOM IV";
    public static readonly String MISSING_GEMS = "You need more gems! ";
    public static readonly String ALL_GEMS_FOUND = "Enter the tunnel";
    public static readonly String WEREWOLF_DONE = "You did it! Grab the treasure!";
    public static readonly String END = "You escaped!";

    private static String lastMessage = "Escape Reality";

    private static GameObject userMenuObj;
    private static TextMesh userMenu;

    void Start()
    {
        userMenuObj = GameObject.Find("UserMenu");
        userMenu = userMenuObj.GetComponent<TextMesh>();


    }
    internal static void createShortMessage(string message)
    {
        userMenu.text = message;
        lastMessage = message;
    }

    internal static void clearMessage()
    {
        userMenu.text = "";
    }

    public void clearCommand()
    {
        userMenu.text = "";
    }

    public void displayLastMessage(){
        createShortMessage(lastMessage);
    }
}
