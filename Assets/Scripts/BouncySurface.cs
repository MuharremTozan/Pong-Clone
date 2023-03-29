using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        // Burada ball sinifindan ball diye bir degisken uretip baska bir yere degip degmedigini kontrol ediyoruz.
        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            // normal degiskeni yonu ifade ediyor
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
}
