using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        startingPage();
    }   
    void startingPage()
    {
        string intro = "Ouuu I'm feeling quite penetrable today ;)" +
                           "\nWhich part of me are you interested in hacking?";
        string question = "\nPress A to hack my grocery store" +
                           "\nPress B to hack my hospital" +
                           "\nPress C to hack the CIA";
        Terminal.WriteLine(intro);
        Terminal.WriteLine(question);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
