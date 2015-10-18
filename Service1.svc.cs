using System;

namespace AutofacDemoWCF
{
    public class Service1 : IService1
    {
        private ICalculo _calculo;
        private DoLog _log;

        public Service1(ICalculo calculo, DoLog log)
        {
            this._calculo = calculo;
            this._log = log;
        }

        public string GetTeste() => "Desenvolvedor Ninja - Autofac com WCF";

        public double GetSoma(double a, double b)
        {
            _log.Write("Método GetSoma");
            return _calculo.Calcular(a, b);
        }
    }
}