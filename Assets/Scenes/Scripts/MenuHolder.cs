using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuHolder : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject EpisodesMenu;

    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Button button11;
    public Button button12;
    public Button button13;
    public Button button14;
    public Button button15;
    public Button button16;
    public Button button17;
    public Button button18;
    public Button button19;
    public Button button20;
    public Button button21;
    public Button button22;
    public Button button23;
    public Button button24;
    public Button button25;
    
    void Start()
    {
        
        if(FpsScript.BolumDegeri == 1)
        {
            button2.interactable = true;
        }
        if(FpsScript.BolumDegeri == 2)
        {
            button2.interactable = true;
            button3.interactable = true;
        }
        if(FpsScript.BolumDegeri == 3)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
        }
        if(FpsScript.BolumDegeri == 4)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
        }
        if(FpsScript.BolumDegeri == 5)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
        }
        if(FpsScript.BolumDegeri == 6)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
        }
        if(FpsScript.BolumDegeri == 7)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
        }
        if(FpsScript.BolumDegeri == 8)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
        }
        if(FpsScript.BolumDegeri == 9)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
        }
        if(FpsScript.BolumDegeri == 10)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
        }
        if(FpsScript.BolumDegeri == 11)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
        }
        if(FpsScript.BolumDegeri == 12)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
        }
        if(FpsScript.BolumDegeri == 13)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
        }
        if(FpsScript.BolumDegeri == 14)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
            button15.interactable = true;
        }
        if(FpsScript.BolumDegeri == 15)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
            button15.interactable = true;
            button16.interactable = true;
        }
        if(FpsScript.BolumDegeri == 16)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
            button15.interactable = true;
            button16.interactable = true;
            button17.interactable = true;
        }
        if(FpsScript.BolumDegeri == 17)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
            button15.interactable = true;
            button16.interactable = true;
            button17.interactable = true;
            button18.interactable = true;
        }
        if(FpsScript.BolumDegeri == 18)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
            button15.interactable = true;
            button16.interactable = true;
            button17.interactable = true;
            button18.interactable = true;
            button19.interactable = true;
        }
        if(FpsScript.BolumDegeri == 19)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
            button15.interactable = true;
            button16.interactable = true;
            button17.interactable = true;
            button18.interactable = true;
            button19.interactable = true;
            button20.interactable = true;
        }
        if(FpsScript.BolumDegeri == 20)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
            button15.interactable = true;
            button16.interactable = true;
            button17.interactable = true;
            button18.interactable = true;
            button19.interactable = true;
            button20.interactable = true;
            button21.interactable = true;
        }
        if(FpsScript.BolumDegeri == 21)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
            button15.interactable = true;
            button16.interactable = true;
            button17.interactable = true;
            button18.interactable = true;
            button19.interactable = true;
            button20.interactable = true;
            button21.interactable = true;
            button22.interactable = true;
        }
        if(FpsScript.BolumDegeri == 22)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
            button15.interactable = true;
            button16.interactable = true;
            button17.interactable = true;
            button18.interactable = true;
            button19.interactable = true;
            button20.interactable = true;
            button21.interactable = true;
            button22.interactable = true;
            button23.interactable = true;
        }
        if(FpsScript.BolumDegeri == 23)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
            button15.interactable = true;
            button16.interactable = true;
            button17.interactable = true;
            button18.interactable = true;
            button19.interactable = true;
            button20.interactable = true;
            button21.interactable = true;
            button22.interactable = true;
            button23.interactable = true;
            button24.interactable = true;
        }
        if(FpsScript.BolumDegeri == 24)
        {
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            button7.interactable = true;
            button8.interactable = true;
            button9.interactable = true;
            button10.interactable = true;
            button11.interactable = true;
            button12.interactable = true;
            button13.interactable = true;
            button14.interactable = true;
            button15.interactable = true;
            button16.interactable = true;
            button17.interactable = true;
            button18.interactable = true;
            button19.interactable = true;
            button20.interactable = true;
            button21.interactable = true;
            button22.interactable = true;
            button23.interactable = true;
            button24.interactable = true;
            button25.interactable = true;
        }
        
    }

    public void OpenWebsite()
    {
        Application.OpenURL("https://mamistagames.blogspot.com/2022/12/privacy-policy.html");
    }
    
    public void StartButton()
    {
        
        SceneManager.LoadScene("Level1");
    }

    public void Options()
    {                                            
          MainMenu.SetActive(false); 
          OptionsMenu.SetActive(true);                 
    }


    public void Episodes()
    {                                            
          MainMenu.SetActive(false); 
          EpisodesMenu.SetActive(true);                 
    }

    public void Return()
    {
        MainMenu.SetActive(true);
        EpisodesMenu.SetActive(false); 
        OptionsMenu.SetActive(false); 
    }

    public void Ep1()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
    public void Ep2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1f;
    }
    public void Ep3()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1f;
    }
    public void Ep4()
    {
        SceneManager.LoadScene("Level4");
        Time.timeScale = 1f;
    }
    public void Ep5()
    {
        SceneManager.LoadScene("Level5");
        Time.timeScale = 1f;
    }
    public void Ep6()
    {
        SceneManager.LoadScene("Level6");
        Time.timeScale = 1f;
    }
    public void Ep7()
    {
        SceneManager.LoadScene("Level7");
        Time.timeScale = 1f;
    }
    public void Ep8()
    {
        SceneManager.LoadScene("Level8");
        Time.timeScale = 1f;
    }
    public void Ep9()
    {
        SceneManager.LoadScene("Level9");
        Time.timeScale = 1f;
    }
    public void Ep10()
    {
        SceneManager.LoadScene("Level10");
        Time.timeScale = 1f;
    }
    public void Ep11()
    {
        SceneManager.LoadScene("Level11");
        Time.timeScale = 1f;
    }
    public void Ep12()
    {
        SceneManager.LoadScene("Level12");
        Time.timeScale = 1f;
    }
    public void Ep13()
    {
        SceneManager.LoadScene("Level13");
        Time.timeScale = 1f;
    }
    public void Ep14()
    {
        SceneManager.LoadScene("Level14");
        Time.timeScale = 1f;
    }
    public void Ep15()
    {
        SceneManager.LoadScene("Level15");
        Time.timeScale = 1f;
    }
    public void Ep16()
    {
        SceneManager.LoadScene("Level16");
        Time.timeScale = 1f;
    }
    public void Ep17()
    {
        SceneManager.LoadScene("Level17");
        Time.timeScale = 1f;
    }
    public void Ep18()
    {
        SceneManager.LoadScene("Level18");
        Time.timeScale = 1f;
    }
    public void Ep19()
    {
        SceneManager.LoadScene("Level19");
        Time.timeScale = 1f;
    }
    public void Ep20()
    {
        SceneManager.LoadScene("Level20");
        Time.timeScale = 1f;
    }
    public void Ep21()
    {
        SceneManager.LoadScene("Level21");
        Time.timeScale = 1f;
    }
    public void Ep22()
    {
        SceneManager.LoadScene("Level22");
        Time.timeScale = 1f;
    }
    public void Ep23()
    {
        SceneManager.LoadScene("Level23");
        Time.timeScale = 1f;
    }
    public void Ep24()
    {
        SceneManager.LoadScene("Level24");
        Time.timeScale = 1f;
    }
    public void Ep25()
    {
        SceneManager.LoadScene("Level25");
        Time.timeScale = 1f;
    }
}
