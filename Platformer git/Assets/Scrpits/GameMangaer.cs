using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMangaer : MonoBehaviour
{
    public PlayerMovement Movement;
    public Flip flip;
    public float restartDelay = 1f;
    public bool gameHasEnded = false;
    public Animator animator;

    public void Endgame()
    {
        animator.SetBool("gameHasEnded", true);
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Movement.enabled = false;
            flip.enabled = false;
            Invoke("restart", restartDelay);
        }
    }

    void Respawn()
    {
        animator.SetBool("gameHasEnded", false);
        gameHasEnded = false;
        Movement.enabled = true;
        flip.enabled = true;
    }

    void restart()
    {
        FindObjectOfType<spawnpoint>().respawn();
        Respawn();
    }


}
