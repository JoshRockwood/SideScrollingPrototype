using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerJumpSound : MonoBehaviour
{
    public AudioClip jumpSound; // Assign your jump sound effect here.

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = jumpSound;
    }

    private void Update()
    {
        if (IsJumpButtonPressed() && IsGrounded())
        {
            Jump();
        }
    }

    private bool IsJumpButtonPressed()
    {
        // Customize this based on your input setup.
        return Input.GetButtonDown("Jump"); // Change "Jump" to match your input setup (e.g., spacebar).
    }

    private bool IsGrounded()
    {
        // Implement your grounded check here (e.g., raycasting or collision detection).
        // For simplicity, this example assumes that the player can jump if the "IsGrounded" condition is met.
        return true;
    }

    private void Jump()
    {
        // Play the jump sound effect.
        audioSource.Play();
        // Add your jump logic here (e.g., applying force to the Rigidbody).
    }
}