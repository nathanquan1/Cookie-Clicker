using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsPanel; 
    public Slider volume;
    public cookie_script cookie_script; 
    public TextMeshProUGUI volumeText;


    void Start()
    {
        //Sets volume to the slider volume level by calling the setVolume function in cookie_script
        volume.onValueChanged.AddListener(cookie_script.setVolume);
        volumeText.text = "Volume: " +Mathf.RoundToInt(cookie_script.music.volume*100).ToString()+"%";
    }
    void Update()
    {
        volumeText.text = "Volume: " +Mathf.RoundToInt(cookie_script.music.volume*100).ToString()+"%";
    }

    public void ToggleSettings()
    {
        //Toggles settings panel on/off when clicked
        settingsPanel.SetActive(!settingsPanel.activeSelf); 

    }
}
