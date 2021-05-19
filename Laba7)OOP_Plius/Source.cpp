#include "Header.h"
#include <math.h>
#include <iostream>
Exept::Exept(double a, double c, double d) 
{
	_a = a;
	_c = c;
	_d = d;
}
void Exept::Func()
{
	if (_a / 4 + _c == 0)
		throw "Devision by zero";
	if (2 * _c <= _a)
		throw "Wrong arguments";
	result = (log10(2 * _c - _a) + _d - 152) / (_a / 4 + _c);
}
Exept::Exept()
{

}