using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPOOSmartPhone.Models
{
  // TODO: Herdar da classe "Smartphone"
  public class Nokia : Smartphone
  {
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando {nomeApp} pela Play Store");
    }
  }
}