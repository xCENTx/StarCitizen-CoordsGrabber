#include "stdafx.h"

//Process Info
HANDLE hProc;
uintptr_t moduleBase;
DWORD dwExit = 0;
m1 Memory;

int main()
{
	const wchar_t* PROCESS = L"StarCitizen.exe";
	DWORD ProcID = GetProcId(PROCESS);
	
	//Game Info
	uintptr_t posX = 0, posY = 0, posZ = 0;
	float x = 0, y = 0, z = 0;

	SetConsoleTitle(L"StarCitizen - Coords Grabber");
    start: cout << "Searching for Process . . ." << endl;
	Sleep(2000);
	if (ProcID)
	{
		cout << "Gathering Process Information . . ." << endl;
		hProc = OpenProcess(PROCESS_ALL_ACCESS, NULL, ProcID);
		moduleBase = GetModuleBaseAddress(ProcID, PROCESS);
		Memory = m1(hProc);
		system("cls");
		cout << "READY" << endl;
	}
	else
	{
		goto start;
	}

	while (GetExitCodeProcess(hProc, &dwExit) && dwExit == STILL_ACTIVE)
	{
		if (GetAsyncKeyState(VK_NUMPAD9) & 1)
		{
			//buggy
			posX = FindDMAAddy(hProc, moduleBase + pPOSptr, { 0x240, 0x168, 0x18, 0xB0, 0x8, 0x1C4 });
			posZ = FindDMAAddy(hProc, moduleBase + pPOSptr, { 0x240, 0x168, 0x18, 0xB0, 0x8, 0x1CC });
			posY = FindDMAAddy(hProc, moduleBase + pPOSptr, { 0x240, 0x168, 0x18, 0xB0, 0x8, 0x1D4 });

			//Store Current Coordinates
			x = Memory.Read<float>(posX);
			z = Memory.Read<float>(posZ);
			y = Memory.Read<float>(posY);
			cout << "COORDS" << endl;
			cout << x << endl;
			cout << y << endl;
			cout << z << endl;
			cout <<"\n" << endl;
		}
	}
}