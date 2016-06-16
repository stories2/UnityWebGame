using UnityEngine;
using System.Collections;

public class main_proc : MonoBehaviour {

	public GameObject obj_wall,miku;
	public Camera main_cam;
	wall_ctr[] wall;
	player player_character;
	cam_ctr cam;
	io_ctr io;

	// Use this for initialization
	void Start () {
	
		init ();
	}

	public void init()
	{
		int limit = 6, i , degree = 30;
		float r = 30 / 2 * Mathf.Sqrt(3);

		cam = gameObject.AddComponent<cam_ctr> ();
		wall = new wall_ctr[limit];

		for (i = 0; i < limit; i += 1) {
			wall[i] = gameObject.AddComponent<wall_ctr> ();
		}
		player_character = gameObject.AddComponent<player> ();

		cam.set_cam (main_cam);
		cam.set_pos (new Vector3 (0, 0, -60));
		cam.set_rot (new Vector3 (0, 0, 0));

		for (i = 0; i < limit; i += 1) {
			wall[i].set_obj (obj_wall);
			float x, y;
			x = Mathf.Cos ((i * 60 + degree) * (3.14f / 180)) * r + main_cam.transform.position.x;
			y = Mathf.Sin ((i * 60 + degree) * (3.14f / 180)) * r + main_cam.transform.position.y;
			wall [i].set_pos (new Vector3 (x, y, 13));
			wall[i].set_rot (new Vector3 (0, 0, i*60 + 90 + degree));
			wall[i].create ();

			if (i == 4) {
				player_character.set_obj (miku);
				player_character.set_pos (new Vector3 (0, y, 13));
				player_character.set_rot (new Vector3 (0, 180, 0));
				player_character.create ();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
