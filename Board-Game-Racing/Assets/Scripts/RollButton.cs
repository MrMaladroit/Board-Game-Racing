using UnityEngine;
using TMPro;

public class RollButton : MonoBehaviour
{
    public int numberOfSpacesToMove { get; private set; }

    private void GenerateRandomNumber()
    {
        numberOfSpacesToMove = Random.Range(1, 7);
    }

    public void DisplayNumberOfSpacesToMove()
    {
        GenerateRandomNumber();
        TextMeshProUGUI rollButtonDisplay = GetComponentInChildren<TextMeshProUGUI>();
        rollButtonDisplay.text = numberOfSpacesToMove.ToString();
    }
}