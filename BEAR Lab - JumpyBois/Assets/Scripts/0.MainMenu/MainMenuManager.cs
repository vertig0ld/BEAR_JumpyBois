using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private int samplingRate; // samples per second

    // Main Menu Images
    [SerializeField] private Sprite[] mainMenuSprites;
    [SerializeField] private Button playGameButton;
    [SerializeField] private Button setupButton;
    
    private void Awake()
    {
        // Sets our input rate to our sampling rate
        Time.fixedDeltaTime = 1f / (float)samplingRate;

        int randNum = Random.Range(0, mainMenuSprites.Length);
        this.GetComponent<Image>().sprite = mainMenuSprites[randNum];

        LoadData();
        Debug.Log("TODO: Make Administrator Menu password protected or something, idk");
    }

    // Calibrate grasp signals first if not already done, then let player choose character
    public void PlayGameButton()
    {
        Debug.Log("TODO: Check if already calibrated. If so, play game. If not, go to CalibrationMenu/Setup");
        Debug.Log("TODO: For now, we'll test this by going directly to the character selection menu...");
        SceneManager.LoadSceneAsync("3.CharacterSelection");
    }
    
    // Exit Application
    public void QuitGameButton()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    // Disabled by default unless user has administrator access
    // Select grasps, total number of tests, num of tests per grasp, and input method
    public void AdministratorMenuButton()
    {
        Destroy(GameObject.Find("PlayerData"));
        Destroy(PlayerData.PlayerDataRef);
        Debug.Log("TODO: Make Administrator Menu inactive, when game is deployed, set transparency");
        SceneManager.LoadSceneAsync("1.GraspSelectionMenu");
    }

    // Calibrate grasp signals
    public void SetupButton()
    {
        SceneManager.LoadSceneAsync("5.CalibrationMenu");
    }

    
    // Load saved GameSettings.json data into empty PlayerData object
    private void LoadData()
    {
        string filePath = Application.persistentDataPath + "/GameSettings.json";

        // If a GameSettings.json file exists, load it
        // If there is no file, prompt user to set one up by disabling all buttons but the 'Admin Menu' one
        try
        {
            string gameSettingsData = System.IO.File.ReadAllText(filePath);

            // If the PlayerData object isn't empty, it overwrites the values
            JsonUtility.FromJsonOverwrite(gameSettingsData, PlayerData.PlayerDataRef);

            // Reconstruct the dictionary from the two unpacked arrays
            for (int i = 0; i < PlayerData.PlayerDataRef.graspNumDictValues.Length; i++)
            {
                int graspNum = PlayerData.PlayerDataRef.graspNumDictValues[i];
                if (graspNum == 0)
                    continue;
                GameLookup.graspNamesEnum graspName = PlayerData.PlayerDataRef.graspNameDictKeys[i];
                PlayerData.PlayerDataRef.numTestsPerGrasp.Add(graspName, graspNum);
            }

        }
        catch
        {
            Debug.Log("Doesn't Exist!");
            playGameButton.interactable = false;
            setupButton.interactable = false;
        }
    }
}
