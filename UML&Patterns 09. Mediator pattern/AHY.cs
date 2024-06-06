// Mediator pattern



class AHY : Airplane
{
    public AHY(ICenter center): base(center)
    {
        Code = "AHY";
    }
    public override void LandingPermission()
    {
        Center.LandingPermission(this);
    }

    public override void TakeOffPermission()
    {
        Center.TakeOffPermission(this);
    }
}


