// ExamenPerifericos.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//
/*********************************************************************************************
*                       Universidad Politecnica de Tulancingo                                *
*        	       Ingenieria en Electronica y Telecomunicaciones                            *
*                          ALUMNO: JOSE ADAN ISLAS VILLEDA                                   *
*                             Programacion De Periféricos                                    *
*                              Arturo Negrete Medellin                                       *
**********************************************************************************************
*    Este programa nos mostrara un archivo de texto en cadena y mostrando el genero de la    *
*                                  persona seleccionada.                                     *
*********************************************************************************************/
#include "pch.h"
#include <iostream>
#include <conio.h>
#include <stdlib.h>
#include <string>
#include <fstream>
using namespace std;

class persona {
	string nombre;
	int edad;
	char genero;
	string direccion;
	string telefono;
	string email;
	string muestra;
	string muestraGen() {
		if (genero == 'M')
			return "Hombre";
		else
			return "Mujer";
	}
public:
	string LeeTxt(string archivo);
	void LeeArchivo();
};


string persona::LeeTxt(string archivo) {
	string texto, linea;
	ifstream miArchivo(archivo);
	if (miArchivo.is_open()) {
		texto = "";
		while (getline(miArchivo, linea)) {
			texto += linea;
		}
		cout << texto;
		miArchivo.close();
	}
	return texto;



	string token, cadena;
	token = LeeTxt("C:\\Users\\JOSE ADAN\\Documents\\DATOS.txt");
	cout << texto << " ";
	string delimita = ",";
	size_t pos = 0;
	while ((pos = token.find(delimita)) != string::npos) {
		cadena = token.substr(0, pos);
		cout << cadena << endl;
		token.erase(0, pos + delimita.length());
	}
	cout << token << endl;
}



void persona::LeeArchivo() {
	cout << LeeTxt("C:\\Users\\JOSE ADAN\\Documents\\DATOS.txt");
}



int main()
{
	persona Adan;

	Adan.LeeArchivo();
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
