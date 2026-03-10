using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // public AnimatorController ControleDoozy;
    // public Controller ControleDoozy;
    // public AnimatorController ControleDoozy;
    // void Start()
    // {
    //     // Get a reference to the Animator component
    //     animator = GetComponent<Animator>();
    // }
    public void MostrarDancinha()
    {
        print("Chamou");
        SceneManager.LoadScene("Dancinha");
    }
    public void MostrarToon()
    {
        print("Chamou");
        SceneManager.LoadScene("DancinhaToon");
    }
    public void MostrarOutline()
    {
        print("Chamou");
        SceneManager.LoadScene("DancinhaToonOutline");
    }
    public void MostrarPixel()
    {
        print("Chamou");
        SceneManager.LoadScene("DancinhaToonOutlinePixel");
    }

    public void isDancing()
    {
        Debug.Log("Chamou");
        ControleDoozy.anim.SetBool("isDancing", true);
    }
}

// DancinhaToonOutlinePixel