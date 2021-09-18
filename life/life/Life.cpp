#include "life.h"
#include <cstdlib>
#include <ctime>
#include <iostream>
#include <Windows.h>
using namespace std;

Life::Life() {
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
        {
            space[i][j] = 0;
        }
}

Life::~Life()
{
}

int Life::countNaightbours(int x, int y)
{
    int count = 0;

    for (int i = -1; i < 2; i++)
    {
        for (int j = -1; j < 2; j++)
        {
            int col = (x + i + spaceX) % spaceX;
            int row = (y + j + spaceY) % spaceY;
            bool isSelfChecking = col == x && row == y;
            if (!isSelfChecking && space[i][j] == 1)
                count++;
        }
    }
    return count;
}

int Life::checkRule(int i, int j)
{
    int lifeCount = countNaightbours(i,j);
 //   int newSpace[a][b];

    if ((lifeCount == 2 || lifeCount == 3) && space[i][j] == 0)
        space[i][j] = 1;
    if ((lifeCount < 2 || lifeCount > 3) && space[i][j] == 1)
        space[i][j] = 0;
    return 0;
}

void Life::printSpace()
{
    for (int i = 0; i < a; i++) {
        for (int j = 0; j < b; j++)
            if (space[i][j] == 1)
                cout << "* ";
            else
                cout << "  ";
        cout << endl;
    }
}

void Life::generateLife()
{
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            space[i][j] = (rand() + time(0)) % 2;
}

void Life::Planer()
{
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            space[i][j] = 0;
    space[5][5] = space[5][6] = space[5][7] = 1;

    //space[0][1] = space[1][2] = space[2][0] = space[2][1] = space[2][2] = 1;
}

void Life::Queen_bee()
{
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            space[i][j] = 0;

    space[5][5] = space[5][6] = space[6][7] = space[7][8] = space[8][8] = space[9][8] = space[10][7] = space[11][6] = space[11][5] = 1;
}

void Life::runLife() {
    int num_g;

    cout << endl << "enter ¹pattern";
    cout << endl << "1-Random; 2-Planer; 3-Queen bee;";
    
    cin >> num_g;
    
    switch (num_g)
    {
        case 1:generateLife(); break;
        case 2:Planer(); break;
        case 3:Queen_bee(); break;
    }
    system("cls");

    printSpace();
    Sleep(1000);

    system("cls");
    while (1) {
        for (int i = 0; i < a; i++)
            for (int j = 0; j < b; j++)
                checkRule(i, j);
        printSpace();
        Sleep(500);
        system("cls");
    }
}