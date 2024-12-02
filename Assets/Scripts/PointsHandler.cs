using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointsHandler : MonoBehaviour
{
    private TextMeshProUGUI textUI;

    private void OnEnable()
    {
        StaticData.OnPointsChanged += ChangePointText;
    }

    private void OnDisable()
    {
        StaticData.OnPointsChanged -= ChangePointText;
    }

    private void Start()
    {
        textUI = gameObject.GetComponent<TextMeshProUGUI>();
        textUI.text = $"Points: {StaticData.GetPoints()}";
    }

    private void ChangePointText()
    {
        textUI.text = $"Points: {StaticData.GetPoints()}";
    }
}
