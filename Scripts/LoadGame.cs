using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {
    [System.Obsolete]
    public void next(string a)
	{
		//using Non depricated and non obsolete methods is important,
		//Using SceneManager instead of Applcation.LoadLevel("Start");
		Application.LoadLevel(a);
	}
	
	public void QuitGame()
	{
		Debug.Log("Quit !");
		Application.Quit();
	}

    //public void update()
    //{
    //    if (input.getmousebuttondown(0.5))
    //    {
    //        application.loadlevel("humanbody");
    //    }
    //}
}
