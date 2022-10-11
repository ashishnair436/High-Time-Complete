using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void US()
    {
            SceneManager.LoadScene(3);
        
    }

    public void Japan()
    {
        SceneManager.LoadScene(4);

    }

    public void India()
    {
        SceneManager.LoadScene(2);

    }

    public void EndCredits()
    {
        SceneManager.LoadScene(5);

    }

    public void MapLoad()
    {
        SceneManager.LoadScene(1);

    }



          
}
