#include <Windows.h>
#include <iostream>
#include <string>

bool run = true;

int result;

LPCSTR boxtxt = "Continue program?";

LPCSTR caption = "Created with MessageBoxIndirect";

using namespace std;

MSGBOXPARAMSA params{ 0, NULL, GetModuleHandle(NULL), boxtxt, caption, MB_OK | MB_SETFOREGROUND | MB_ICONQUESTION | MB_YESNOCANCEL | MB_SYSTEMMODAL, MAKEINTRESOURCEA(IDI_QUESTION), 1234};

VOID CALLBACK MsgBoxCallback(LPHELPINFO lpHelpInfo)
{
	POINT p;
	GetCursorPos(&p);
	cout << "This is help." << endl;
	cout << "Cursor position: \nX: " << p.x << endl << "Y: " << p.y << endl;
	cout << "Help ID: " << to_string((lpHelpInfo->dwContextId)) << endl;

	return;
}

int main()
{
	while (run)
	{
		params.cbSize = sizeof(params);

		params.lpfnMsgBoxCallback = MsgBoxCallback;

		result = MessageBoxIndirectA(&params);

		switch(result)
		{
		case 2:
			cout << "Message cancelled." << endl;
			break;
		case 7:
			cout << "Thanks for using the program!" << endl;
			run = false;
			break;
		case 6:
			cout << "Keep going." << endl;
			break;
		default:
			break;
		}
	}

	return 0;
}