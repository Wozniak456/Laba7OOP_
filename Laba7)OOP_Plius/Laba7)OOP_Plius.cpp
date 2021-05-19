using namespace std;
#include <iostream>
#include "Header.h"
int main()
{
	cout << "Vozniak Sofiia, is-01" << endl;
	Exept arr[3];
	arr[0] = Exept(5, 8, 9);
	arr[1] = Exept(8, -2, 3);
	arr[2] = Exept(3, 1, 3);
	for (int i = 0; i < 3; i++)
	{
		try
		{
			arr[i].Func();
			cout << "Result of equation[" << i << "]: " << arr[i].result << endl;
		}
		catch (const char* msg)
		{
			cout << "Result of equation[" << i << "]: " << msg << endl;
		}
	}
	return 0;
}
