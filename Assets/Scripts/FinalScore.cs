using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    void Start()
    {
        TextMeshProUGUI textUI = GetComponent<TextMeshProUGUI>();

        textUI.text = $"Final Score: {StaticData.GetPoints()} Points";
    }
}
