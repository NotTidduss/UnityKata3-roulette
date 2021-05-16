using UnityEngine;
using UnityEngine.UI;

public class TextUpdater : MonoBehaviour
{
    public Text chipsText;
    public Text resultsText;
    public void updateChipsText(string newText) => updateText(chipsText, newText);
    public void updateResultsText(string newText) => updateText(resultsText, newText);
    public void updateText(Text t, string newText) => t.text = newText;
}
