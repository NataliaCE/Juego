using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text vidaTxt;
    public Text manzanaTxt;
    public RedHood pj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaTxt.text = pj.Vidas.ToString();
        manzanaTxt.text = pj.Manzanas.ToString();

        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Muerte");
        }
    }
}
