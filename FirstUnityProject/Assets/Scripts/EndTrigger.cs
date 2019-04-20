
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject completeLevelUi;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        completeLevelUi.SetActive(true);

    }


}
