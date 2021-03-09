using UnityEngine;

// ***** DELEGATE PATTERN CHANGE ***** -> Init delegate method
public delegate void OutOfBoundsHandler();

public class ProjectileController : MonoBehaviour
{
    #region Field Declarations

    public Vector2 projectileDirection;
    public float projectileSpeed;
    public bool isPlayers;

    #endregion

    // ***** DELEGATE PATTERN CHANGE ***** -> Create a delegate instance
    public event OutOfBoundsHandler ProjectileOutOfBounds;

    #region Movement

    // Update is called once per frame
    void Update()
    {
        MoveProjectile();
    }

    private void MoveProjectile()
    {
        transform.Translate(projectileDirection * Time.deltaTime * projectileSpeed, Space.World);

        if (ScreenBounds.OutOfBounds(transform.position))
        {
            if (isPlayers == true)
            {
                // ***** DELEGATE PATTERN CHANGE ***** -> switch from tight coupling to event broadcasting method
                //PlayerController playerShip = FindObjectOfType<PlayerController>();
                //playerShip.EnableProjectile();
                if (ProjectileOutOfBounds != null)
                    ProjectileOutOfBounds(); // Broadcast event
            }

            Destroy(gameObject);
        }
    }

    #endregion
}
