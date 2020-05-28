using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menubuttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadpaint() { }

    public void loadpuzzle() {
        SceneManager.LoadScene("puzzleeasy");
    }

    public void loadmaze() {

        SceneManager.LoadScene("mazeeasy");
    }

}
