// Mediator pattern



class Center : ICenter
{
    private List<Airplane> _airplanes { get; set; } = new();

    public void AddAirplane(Airplane airplane)
    {
        _airplanes.Add(airplane);
    }

    public void LandingPermission(Airplane airplane)
    {
        for (int i = 0; i < _airplanes.Count(); i++)
        {
            Airplane next = _airplanes[i];
            if (next.GetType() != airplane.GetType())
            {
                airplane.HandleMessage(next, "Landing permission");
            }
        }
    }

    public void TakeOffPermission(Airplane airplane)
    {
        for (int i = 0; i < _airplanes.Count(); i++)
        {
            Airplane next = _airplanes[i];
            if (next.GetType() != airplane.GetType())
            {
                airplane.HandleMessage(next, "Take off permission");
            }
        }
    }
}


