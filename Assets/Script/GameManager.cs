using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public float MaxPath;
    public float Speed;

    public Transform Player;

    public GameObject m_Button;
    public GameObject Bola;

    public string restartScene;
    public string completedScene;

    bool Completed;
    bool Fail;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.position.z >= MaxPath)
        {
            Finish();
        }
	}

    void Finish()
    {

    }

    public void GameOver()
    {
        m_Button.SetActive(true);
        Bola.SetActive(false);
        Speed = 0;
        Fail = true;
    }

    public void Clicking()
    {
        if (Fail)
        {
            Application.LoadLevel(restartScene);
        }
    }
}
