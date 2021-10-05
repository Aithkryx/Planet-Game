using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class main_menu : MonoBehaviour
{   
    public Button next_button;
    public Button prev_button;
    public Text stagetext;
    public static string sceneName = "";
    public static int selected_stage_index;

    
    // Start is called before the first frame update
    void Start()
    {
        SaveGameManager.Instance.unlock_level(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void buttons_pressed()
    {
        
        StartCoroutine(button_pressed());

    }
    IEnumerator button_pressed()
    {
        next_button.interactable = false;
        prev_button.interactable = false;       
        yield return new WaitForSeconds (0.2f);
        prev_button.interactable = true;
        next_button.interactable = true;

    }
    public void changeScene(){
        if(SaveGameManager.Instance.check_level_unlocked(selected_stage_index)){
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
        }
        
    }
}