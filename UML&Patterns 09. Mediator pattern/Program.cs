// Mediator pattern
ICenter center = new Center();
AHY ahy = new AHY(center);
Buta buta = new Buta(center);

center.AddAirplane(ahy);
center.AddAirplane(buta);

ahy.LandingPermission();
buta.TakeOffPermission();

buta.LandingPermission();
ahy.TakeOffPermission();


