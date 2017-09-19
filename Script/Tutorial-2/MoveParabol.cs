using System.Collections;
using UnityEngine;

public class MoveParabol : MonoBehaviour {

    public float timeMove;
    public float height;

    public Transform target;

    private bool isMoving;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
            StartCoroutine(MoveParabola());
	}

    IEnumerator MoveParabola()
    {
        isMoving = true;

        var startPosition = transform.position;
        var timer = 0f;

        while(timer <= 1f)
        {
            var heightTemp = Mathf.Sin(Mathf.PI * timer) * height;
            transform.position = Vector3.Lerp(startPosition, target.position, timer) + Vector3.up * heightTemp;

            timer += Time.deltaTime / timeMove;
            yield return null;
        }

        transform.position = target.position;

        isMoving = false;
    }
}
