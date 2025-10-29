using UnityEngine;
using UnityEngine.TextCore.Text;

public class Idle : IStateable
{
    public void Enter(Character character)
    {
        character.animator.SetInteger("X", 0);
        character.animator.SetInteger("Y", 0);
    }

    public void Exit(Character character)
    {
       
    }

    public void Update(Character character)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.Changestate(new Attack());
        }
        int x = (int)Input.GetAxisRaw("Horizontal");
        int y = (int)Input.GetAxisRaw("Vertical");


        if ((x > 0) || (y > 0))
        {
            character.Changestate(new Walk());
        }
    }
}
