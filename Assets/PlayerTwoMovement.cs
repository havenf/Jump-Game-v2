using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    private GameObject _playerObject;
    private float obstacleRange = 2.0f;
    private float speed;
    private ScoringManager _sm;
    private int colliderCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.3f;
        _sm = GameObject.FindGameObjectWithTag("scoring").GetComponent<ScoringManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        Ray ray = new Ray(transform.position, transform.up);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, obstacleRange) && hit.collider.gameObject != _playerObject)
        {
            if (hit.collider.name == "PlayerOneRB")
            {
                // StartCoroutine(CountJump(hit.collider.name, this.name));
                _sm.playerOneScore += 1;
            }
        }

        if (hit.collider != null)
        {
            if (hit.collider.tag == "Terrain")
            {
                colliderCount += 1;
            }
            if (hit.collider.tag != "Terrain")
            {
                colliderCount -= 1;
            }
            if (colliderCount == 800)
            {
                transform.Translate(Vector3.forward * 50 * Time.deltaTime);
                colliderCount = 0;
            }
        }

    }
}
