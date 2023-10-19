using System;
using System.IO;
using System.Runtime.CompilerServices;

public class Journal{
    List<Entry> _entryList = new List<Entry>();
    Entry _userEntry;
    DateTime theCurrentTime = DateTime.Now;

    public void DisplayJounal(){
        foreach (Entry e in _entryList){
            Console.WriteLine($"Date: {e._dateText} - Prompt: {e._userPromt}");
            Console.WriteLine($"{e._userRespose}");
            Console.WriteLine("");
        }
    }

    public void WriteJournal(){
        string promt;
        _userEntry = new Entry();

        string dateText = theCurrentTime.ToShortDateString();
        promt =_userEntry.DisplayPromtList();

        _userEntry._userRespose = Console.ReadLine();
        _userEntry._userPromt = promt;
        _userEntry._dateText = dateText;
        _entryList.Add(_userEntry);
    }

    public void SaveJournal(){
    {
    Console.Write("ingrese el nombre del archivo : ");
    string nombre=Console.ReadLine();
    string filename=nombre;
  
    using(StreamWriter outputFile=new StreamWriter(filename))
  {
    outputFile.WriteLine(_entryList);
  }

    
    }
}

  

    public void LoadJournal(){
          string filesss= "";
         string[] lines = System.IO.File.ReadAllLines(filesss);


        

    }
}