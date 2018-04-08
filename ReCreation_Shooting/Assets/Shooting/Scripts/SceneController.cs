using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text;

[System.Serializable]
public static class SceneName
{
	public const string TITLE = "Title";
	public const string SCENE1 = "Scene1";
	public const string SCENE2 = "Scene2";
	public const string SCENE3 = "Scene3";
}

public class SceneController : SingletonMono<SceneController>
{
	public GameObject m_loadScreen;

	AsyncOperation m_async;
	StringBuilder m_sceneName;

	Material fadeMaterial {
		get { return m_loadScreen.GetComponent<Renderer> ().sharedMaterial;}
	}
	Color fadeInColor;
	Color fadeOutColor;
	public string activeSceneName { get { return SceneManager.GetActiveScene ().name; } }

	public bool IsPlaying { get; set; }
	public bool IsPlayScene { get { return activeSceneName.IndexOf ("Stage") >= 0; } }
	public bool NotSelectScene { get { return activeSceneName != "StageSelect"; } }

	public int stageNum{ get; set; }
	public float clearRecord { get; set; }
	public string viewTime { get; set; }

	private void Start ()
	{
		m_sceneName = new StringBuilder ();
		fadeInColor = new Color (fadeMaterial.color.r, fadeMaterial.color.g, fadeMaterial.color.b, 0);
		fadeOutColor = new Color (fadeMaterial.color.r, fadeMaterial.color.g, fadeMaterial.color.b, 1);
	}

	// Scene.Instanse.LoadScene(SceneName.****)
	public void LoadScene (string sceneName)
	{
		m_sceneName.Length = 0;
		m_sceneName.Append (sceneName);
		StartCoroutine (LoadStart ());
	}

	public void ReloadScene() {
		m_sceneName.Length = 0;
		m_sceneName.Append (activeSceneName);
		StartCoroutine (LoadStart ());
	}

	IEnumerator LoadStart ()
	{
		IsPlaying = false;
		m_async = SceneManager.LoadSceneAsync (m_sceneName.ToString ());
		m_async.allowSceneActivation = false;
		yield return FadeOut ();
		m_async.allowSceneActivation = true;
	}

	public IEnumerator FadeOut() {
		fadeMaterial.color = fadeOutColor;
		for(int i = 1; i <= 64; i++) {
			var a = 0.015625f * i;
			fadeMaterial.color = new Color (fadeInColor.r, fadeInColor.g, fadeInColor.b, a);
			yield return null;
		}
	}

	public IEnumerator FadeIn() {
		fadeMaterial.color = fadeInColor;
		for(int i = 64; i >= 1; i--) {
			var a = 0.015625f * i;
			fadeMaterial.color = new Color (fadeInColor.r, fadeInColor.g, fadeInColor.b, a);
			yield return null;
		}
	}

	public void StageInit(){
		IsPlaying = true;
		clearRecord = 0;
		var activeScene = SceneManager.GetActiveScene ();
		stageNum = activeScene.buildIndex - 2;
		viewTime = "";
	}

}
