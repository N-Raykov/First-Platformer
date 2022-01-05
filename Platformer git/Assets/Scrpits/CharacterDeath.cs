using UnityEngine;

public class CharacterDeath : MonoBehaviour
{
    public Rigidbody2D _rb;

    private GameMangaer gameManager;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameMangaer>();
    }

    void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        if (collisioninfo.collider.tag == "Trap")
        {
            _rb.AddForce(new Vector2(0, 400));
            gameManager.Endgame();
        }
    }

    private void Update()
    {
        if (_rb.position.y < -5f)
        {
            gameManager.Endgame();
        }
    }
}
