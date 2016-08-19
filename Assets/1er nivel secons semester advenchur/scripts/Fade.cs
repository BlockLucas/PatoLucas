using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {

	public LevelManager levelManager;

	public float fadeSpeed = 1.5f;          // Speed that the screen fades to and from black.


	private bool sceneStarting = true;      // Whether or not the scene is still fading in.

	private bool sceneRestarting = false;

	// Use this for initialization
	void Start()
	{
		levelManager = FindObjectOfType<LevelManager>();

	}


	void Awake()
	{
		// Set the texture so that it is the the size of the screen and covers it.
		GetComponent<GUITexture>().pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
	}


	void Update()
	{
		// If the scene is starting...
		if (sceneStarting)
			// ... call the StartScene function.
			StartScene();
		if (sceneRestarting)
			EndScene();
	}


	void FadeToClear()
	{
		Debug.Log("FadeToClear Called");
		// Lerp the colour of the texture between itself and transparent.
		GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.clear, fadeSpeed * Time.deltaTime);
	}


	void FadeToBlack()
	{
		Debug.Log("FadeToBlack Called");
		// Lerp the colour of the texture between itself and black.
		GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.black, fadeSpeed * Time.deltaTime);
	}


	public void StartScene()
	{
		Debug.Log("EndScene Called");
		// Fade the texture to clear.
		FadeToClear();


		// If the texture is almost clear...
		if (GetComponent<GUITexture>().color.a <= 0.05f)
		{
			// ... set the colour to clear and disable the GUITexture.
			GetComponent<GUITexture>().color = Color.clear;
			GetComponent<GUITexture>().enabled = false;

			// The scene is no longer starting.
			sceneStarting = false;
		}
	}


	public void EndScene()
	{
		Debug.Log("EndScene Called");
		sceneRestarting = true;
		// Make sure the texture is enabled.
		GetComponent<GUITexture>().enabled = true;

		// Start fading towards black.
		FadeToBlack();

		// If the screen is almost black...
		if (GetComponent<GUITexture>().color.a >= 0.95f)
		{
			// ... reload the level.
			sceneRestarting = false;
			sceneStarting = true;
			levelManager.RespawnPlayer();
		}
	}

}
