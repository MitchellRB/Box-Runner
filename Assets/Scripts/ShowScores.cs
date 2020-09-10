using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HighScoreReader))]
public class ShowScores : MonoBehaviour
{
    private HighScoreReader hsr;
    private List<ScoreEntry> entries;
    private Text text;

#if !UNITY_WEBGL

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();

        // Read score from file
        hsr = gameObject.GetComponent<HighScoreReader>();
        entries = hsr.ReadScores();

        ChangeDisplay(entries);
    }

    public void ChangeDisplay(List<ScoreEntry> entries)
    {
        entries.Sort(entries[0].Compare);

        // Display scores to screen
        StringBuilder sb = new StringBuilder();
        foreach (var item in entries)
        {
            sb.Append(item.name);
            sb.Append(" - ");
            sb.Append(item.score.ToString());
            sb.Append("\n");
        }

        text.text = sb.ToString();
    }
#endif
}
