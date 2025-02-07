using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    public GameObject playerSprite; // Referensi ke objek yang memiliki Sprite Renderer dan Animator
    public float jumpForce = 5f; // Kekuatan lompatan
    private bool isGrounded = true; // Menandakan apakah pemain berada di tanah atau tidak

    void Start()
    {
        animator = playerSprite.GetComponent<Animator>();
        rb = playerSprite.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Mendapatkan input horizontal
        float move = Input.GetAxis("Horizontal");

        // Menangani pergerakan horizontal
        rb.velocity = new Vector2(move * 5f, rb.velocity.y);

        // Mendapatkan kecepatan horizontal dari Rigidbody2D
        float speed = Mathf.Abs(rb.velocity.x);

        // Menetapkan nilai parameter Speed di Animator
        animator.SetFloat("Speed", speed);

        // Mengatur flip sprite berdasarkan arah pergerakan
        if (move > 0) // Jika bergerak ke kanan
        {
            playerSprite.transform.localScale = new Vector3(0.35f, 0.35f, 0.35f); // Karakter menghadap kanan
        }
        else if (move < 0) // Jika bergerak ke kiri
        {
            playerSprite.transform.localScale = new Vector3(-0.35f, 0.35f, 0.35f); // Karakter menghadap kiri
        }

        // Menangani lompatan
        if (isGrounded && Input.GetButtonDown("Jump")) // Pastikan pemain berada di tanah dan menekan tombol lompat
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce); // Terapkan gaya lompat
            animator.SetBool("IsJumping", true); // Set parameter IsJumping ke True
            isGrounded = false; // Pemain tidak lagi di tanah
        }
    }

    // Cek apakah karakter menyentuh tanah untuk memastikan karakter bisa melompat lagi
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // Cek apakah objek yang terkena adalah tanah
        {
            isGrounded = true; // Pemain kembali berada di tanah
            animator.SetBool("IsJumping", false); // Set parameter IsJumping ke False ketika mendarat
        }
    }
}
