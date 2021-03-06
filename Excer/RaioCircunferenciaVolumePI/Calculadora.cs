﻿using System;

namespace RaioCircunferenciaVolumePI
{
    // Sem modificador de acesso - default > internal - Acessivel a um mesmo assembly - Ex: financeiro
    class Calculadora
    {
        // Membros estáticos chama direto pelo nome classe em Program. Sem instancia.
        public static double Pi = 3.14;
        public static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }
        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}
