#include "life.h"
#include <cstdlib>
#include <time.h>
#include <iostream>
using namespace std;

Life::Life() {
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            space[i][j] = 0;
}

Life::~Life()
{
}

int Life::checkRule(int i, int j)
{
    return 0;
}

void Life::printSpace()
{
    for (int i = 0; i < a; i++) {
        for (int j = 0; j < b; j++)
            if (space[i][j] == 1)
                cout << "*";
            else
                cout << " ";
        cout << endl;
    }
}

void Life::generateLife()
{
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            space[i][j] = rand() % 2;
}


void Life::runLife() {
    generateLife();
    printSpace();
}