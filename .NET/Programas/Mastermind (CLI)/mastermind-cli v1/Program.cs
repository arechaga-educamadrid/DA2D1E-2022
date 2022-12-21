﻿using System.Diagnostics;

internal class Program
{
    const string UrlBaseServidorMastermind = "http://localhost:5000/";
    static ConfiguracionPartida? _configuracion;

    private static void Main()
    {
        //Console.WriteLine("Hello, World!");

        _configuracion = CrearConfiguracionDefecto();
        ConfigurarPartida();

        var haGanado = false;
        while (!haGanado)
        {
            var jugada = ObtenerJugada();
            var resultado = RealizarJugada();
            MostrarResultado(jugada, resultado);
        } // while
    } // Main

    private static ConfiguracionPartida CrearConfiguracionDefecto()
    {
        return new ConfiguracionPartida()
        {
            Minimo = 1,
            Maximo = 9,
            Casillas = 3,
        };
    } // CrearConfiguracionDefecto

    private static void ConfigurarPartida()
    {
        Debug.Assert(_configuracion != null);

        int minimo = _configuracion.Minimo;
        int maximo = _configuracion.Maximo;
        int casillas = _configuracion.Casillas;

        Console.WriteLine($"La configuración del juego es:");
        Console.WriteLine($"Valor mínimo: {minimo}");
        Console.WriteLine($"Valor máximo: {maximo}");
        Console.WriteLine($"Número de casillas: {casillas}");
        Console.WriteLine();

        Console.Write("¿Quieres cambiar la configuración? (S/N) ");
        var tecla = Console.ReadLine()?.ToUpper();

        if (tecla != "S") return;

        var esCorrecto = false;
        while (!esCorrecto) 
        {
            Console.Write("Valor mínimo: ");
            var texto = Console.ReadLine();
            if (int.TryParse(texto, out minimo))
            {
                esCorrecto = true;
                continue;
            }
            else
            {
                Console.WriteLine("Número erróneo");
            } // if-else
        } // while

        esCorrecto = false;
        while (!esCorrecto) 
        {
            Console.Write("Valor máximo: ");
            var texto = Console.ReadLine();
            if (int.TryParse(texto, out maximo))
            {
                esCorrecto = true;
                continue;
            }
            else
            {
                Console.WriteLine("Número erróneo");
            } // if-else
        } // while

        esCorrecto = false;
        while (!esCorrecto) 
        {
            Console.Write("Número de casillas: ");
            var texto = Console.ReadLine();
            if (int.TryParse(texto, out casillas))
            {
                if ((casillas >=1) && (casillas <=100))
                {
                    esCorrecto = true;
                    break;
                } // if
            } // if

            Console.WriteLine("Número erróneo");
        } // while

        _configuracion = new ConfiguracionPartida()
        {
            Minimo = minimo,
            Maximo = maximo,
            Casillas = casillas,
        };
    } // ConfigurarPartida

    private static Jugada ObtenerJugada()
    {
        return null;
    } // ObtenerJugada

    private static ResultadoJugada RealizarJugada()
    {
        return null;
    } // RealizarJugada

    private static void MostrarResultado(Jugada jugada, ResultadoJugada resultado)
    {

    } // MostrarResultado
} // class Program
