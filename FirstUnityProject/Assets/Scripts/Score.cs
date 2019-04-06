using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {

        //Displays player position on the z axis to the screen
        Debug.Log(Player.position.z);


        //The .ToString basically just convertsthe player Position from a float into a string, the 0 takes out the 
        ScoreText.text = Player.position.z.ToString("0");
    }
}
