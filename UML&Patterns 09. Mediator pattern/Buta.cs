// Mediator pattern



class Buta : Airplane
{
    public Buta(ICenter center) : base(center)
    {
        Code = "Buta";
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


