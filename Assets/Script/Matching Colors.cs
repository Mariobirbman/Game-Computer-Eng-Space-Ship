using UnityEngine;

public class PlanetColorMatcher : MonoBehaviour
{
    [Header("Drag the planet you want to match here")]
    public SpriteRenderer planetToMatch;

    [Header("Match Strength")]
    [Range(0, 1)] public float matchIntensity = 0.8f;

    void Start()
    {
        if (planetToMatch != null)
        {
            MatchPlanetColor();
        }
    }

    void Update()
    {
        // Optional: Update color in real-time if planet changes color
        if (planetToMatch != null)
        {
            MatchPlanetColor();
        }
    }

    public void MatchPlanetColor()
    {
        SpriteRenderer myRenderer = GetComponent<SpriteRenderer>();
        Color targetColor = planetToMatch.color;

        // Blend with original color based on intensity
        myRenderer.color = Color.Lerp(myRenderer.color, targetColor, matchIntensity);
    }
}