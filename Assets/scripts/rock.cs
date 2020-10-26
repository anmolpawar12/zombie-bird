using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class rock :objectstate
{
    public float rockspeed=4f;
    [SerializeField] private Vector3 topposition;
    [SerializeField] private Vector3 bottomposition;
    private void Start()
    {
        StartCoroutine(Move(bottomposition));
    }

    protected override void Update()
    {
        base.Update();
    }

  
    IEnumerator Move(Vector3 target)
    {
        while (Mathf.Abs(target.y - transform.localPosition.y) > 0.2f)
        {
            Vector3 direction = target.y == topposition.y ? Vector3.up : Vector3.down;
            transform.localPosition += direction * Time.deltaTime * rockspeed;
            yield return null;

        }
        yield return new WaitForSeconds(0.5f);
        Vector3 newtarget = target.y == topposition.y ? bottomposition : topposition;
        StartCoroutine(Move(newtarget));
    }


}
