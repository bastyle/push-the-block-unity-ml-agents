using UnityEngine;
using UnityEngine.UI;

public class DropdownHandler : MonoBehaviour
{
    public Dropdown dropdown; // Set this in the Inspector
    private string mode;

    void Start()
    {
        // Add listener for when the value of the Dropdown changes, to take action
        dropdown.onValueChanged.AddListener(delegate
        {
            DropdownValueChanged(dropdown);
        });

        mode = PlayerPrefs.GetString("mode", "Competition");
        Debug.Log("Initial mode: " + mode);
        // Find the index of the option with the saved mode
        int index = dropdown.options.FindIndex(option => option.text == mode);

        // If the mode was found in the options, select it
        if (index != -1)
        {
            dropdown.value = index;
        }
        else
        {
            Debug.LogError("Mode not found in dropdown options: " + mode);
        }

        Debug.Log("Initial mode: " + mode);
    }

    // Output the new value of the Dropdown into the console
    void DropdownValueChanged(Dropdown change)
    {
        mode = change.options[change.value].text;
        Debug.Log("Selected mode: " + mode);
        PlayerPrefs.SetString("mode", mode);
    }

    public void OnValueChanged(int value)
    {
        // Get the text of the selected option
        string selectedValue = dropdown.options[value].text;

        // Do something with the selected value, e.g., display it in a Text object
        //Debug.Log("Selected value: " + selectedValue);
    }
}
