#include <iostream>
#include <vector>
#include <string>
#include "Methods.h"

int main() {
    std::cout << "What is your name: ";
    std::string name;
    std::getline(std::cin, name);

    ConsoleAppCs::Methods::SayHi(name);

    ConsoleAppCs::Methods::Add(5, 3);

    std::vector<double> vals = { 2, 5, 6, 21, 52, 98 };
    ConsoleAppCs::Methods::AddAll(vals);

    return 0;
}

