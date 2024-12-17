#include <iostream>
#include <vector>
#include <numeric>

namespace ConsoleAppCs {
    class Methods {
    public:
        static void SayHi(const std::string& firstName) {
            std::cout << "Hello " << firstName << "!" << std::endl;
            std::cout << "I hope you are having a good day." << std::endl;
        }

        static void Add(double x, double y) {
            std::cout << "The value of " << x << " + " << y << " = " << (x + y) << std::endl;
        }

        static void AddAll(const std::vector<double>& values) {
            double result = std::accumulate(values.begin(), values.end(), 0.0);
            std::cout << "The total is " << result << std::endl;
        }
    };
}

