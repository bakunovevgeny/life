#pragma once

#define spaceX 20
#define spaceY 20

const int a = spaceX + 2;
const int b = spaceY + 2;

class Life
{

    int space[a][b];

    int countNaightbours(int x, int y);
    int checkRule(int i, int j);
    void printSpace();
    void generateLife();
    void Planer();
    void Queen_bee();

public:
    Life();
    ~Life();

    void runLife();
};