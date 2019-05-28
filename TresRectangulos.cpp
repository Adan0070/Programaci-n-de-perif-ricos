// TresRectangulos.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//
/*********************************************************************************************
*                       Universidad Politecnica de Tulancingo                                *
*        	       Ingenieria en Electronica y Telecomunicaciones                            *
*                          ALUMNO: JOSE ADAN ISLAS VILLEDA                                   *
*                             Programacion De Periféricos                                    *
*                              Arturo Negrete Medellin                                       *
**********************************************************************************************
*            calcula tres diferentes rectangulos y el area del paralelepipedo                *
*********************************************************************************************/
#include "pch.h"
# include  < iostream >
using namespace  std;


 class Rectangulo {
	double alto;
	double ancho;
public:
	Rectangulo(void);
	Rectangulo(double, double);
	double Area();
}
 Rectangulo::Rectangulo() {
	 alto = 1;
	 ancho = 1;
 }
Rectangulo::Rectangulo(double h, double w) {
	alto = h;
	ancho = w;
}
Rectangulo::Area() {
	return alto * ancho;
}
class para {
	double prof;
	Rectangulo cara;
public:
	para();
	para(double, double, double);
	volumen();
}
para::para: cara() {
	prof = 1;
}
para::para(double h, double w, double p) : cara(h, w) {
	prof = p;
}
para::volumen() {
	return prof * cara.Area();
}

int main()
{
	Rectangulo base;
	Rectangulo cuadro(3, 4);
	para cosa(3, 4, 5);
	cout << cosa.volumen() << endl; 60
		cout << cuadro.Area() << endl; 12
		cout << base.Area() << endl;1
}


