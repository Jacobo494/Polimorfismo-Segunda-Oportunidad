using bancoPolimorfismo.ConsoleApp;


Console.WriteLine("Aplicacion el concepto de polimorfismo para la definición de clases abstractas e interfaces que permitan reutilización de código.");
var cuentaBasica = new CuentaBasica(300);
var cuentaAhorro = new Ahorro(3000);
var cuentaCheques = new Cheques(6000);

cuentaBasica.Depositar(200);
cuentaAhorro.Retirar(500);
cuentaCheques.EmitirCheque(400);

Console.WriteLine($"Saldo cuenta básica: {cuentaBasica.Saldo}");
Console.WriteLine($"Saldo cuenta de ahorro: {cuentaAhorro.Saldo}");
Console.WriteLine($"Saldo cuenta de cheques: {cuentaCheques.Saldo}");
Console.WriteLine($"Interés mensual cuenta de cheques: {cuentaCheques.CalcularInteresMensual()}");


