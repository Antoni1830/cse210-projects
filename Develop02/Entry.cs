using System;
using System.IO; 

public class Entry{    
    public string _userPromt;
    public string _userRespose;    
    public string _dateText;


    public string getUserPromt(){
        return _userPromt;
    }

    public string getUserResponse(){
        return _userRespose;
    }

    public string getUserDateText(){
        return _dateText;
    }

    public void SetEntry(string userP, string userR, string dateR){
        _userPromt = userP;
        _userRespose = userR;
        _dateText = dateR;
    }

    public string DisplayPromtList(){
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 5);
        string promt = "";

        switch (number){
            case 1:
                Console.Write("Who was the most interesting person I interacted with today? ");
                promt = "Who was the most interesting person I interacted with today?";
                break;
            case 2:
                Console.Write("What was the best part of my day? ");
                promt = "What was the best part of my day?";
                break;                
            case 3:
                Console.Write("How did I see the hand of the Lord in my life today? ");
                promt = "How did I see the hand of the Lord in my life today?";
                break;                 
            case 4:
                Console.Write("What was the strongest emotion I felt today? ");
                promt = "What was the strongest emotion I felt today?";
                break;                
            case 5:
                Console.Write("If I had one thing I could do over today, what would it be? ");
                promt = "If I had one thing I could do over today, what would it be?";
                break;
                
            default:
                break;
        }
        return promt;

    }
}