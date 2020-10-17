using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string intro = "Ouuu I'm feeling quite hacky today ;)" +
                       "\nWhich part of me are you interested in hacking?";
    string question = "\nPress A to hack my grocery store" +
                       "\nPress B to hack my hospital" +
                       "\nPress C to hack the CIA";
    // Start is called before the first frame update
    void Start()
    {
        startingPage(intro, question);
    }   
    void startingPage(string intro, string question)
    {
        Terminal.WriteLine(intro);
        Terminal.WriteLine(question);
    }

    void OnUserInput(string input)
    {
        print(input);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
