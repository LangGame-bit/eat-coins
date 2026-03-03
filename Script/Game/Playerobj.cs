using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerobj : MonoBehaviour
{
	public float velocity = 10;
	public int force;
	private Rigidbody rb;
	public int height;
	private bool inAir;
	public CustomGUITexture textureNone;

	private void Start()
	{
		if (SceneManager.GetActiveScene().name == "GameScene")
		{
			Camera.main.transform.SetParent(this.transform, false);
			rb = GetComponent<Rigidbody>();
		}
		print(this.transform.up);
		print(Vector3.up);
	}

	private void Update()
	{
		this.transform.Translate(Vector3.forward * velocity * Time.deltaTime * Input.GetAxis("Vertical"));
		this.transform.Translate(Vector3.right * velocity * Time.deltaTime * Input.GetAxis("Horizontal"));
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (rb != null && !inAir)
			{
				rb.AddForce(Vector3.up * force);
			}
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.CompareTag("StepElastic"))
		{
			float newVy = Mathf.Sqrt(2 * Physics.gravity.magnitude * height);
			rb.velocity = new Vector3(rb.velocity.x, newVy, rb.velocity.z);
		}
		else if (collision.transform.CompareTag("Step"))
		{
			inAir = false;
		}
		else if (collision.transform.CompareTag("Ground"))
		{
			GamePanel.Instance.HideMe();
			GamePanel.Instance.life--;
			if (GamePanel.Instance.life > 0)
			{
				DeadPanel.Instance.labelWord.content.text = "";
				DeadPanel.Instance.labelLife.content.text = "X" + GamePanel.Instance.life;
			}
			else
			{
				DeadPanel.Instance.labelLife.content.text = "";
				DeadPanel.Instance.textureHeart.content.image = textureNone.content.image;
				DeadPanel.Instance.textureHeart.guiPos.pos = new Vector2(0, 200);
				DeadPanel.Instance.labelWord.content.text = "再来一次，你一定可以成功";
			}
			DeadPanel.Instance.ShowMe();
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision.transform.CompareTag("Step"))
		{
			inAir = true;
		}
	}
}
