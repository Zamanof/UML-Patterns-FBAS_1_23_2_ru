
// Mediator pattern


interface ICenter
{
    void AddAirplane(Airplane airplane);
    void LandingPermission(Airplane airplane);
    void TakeOffPermission(Airplane airplane);
}


