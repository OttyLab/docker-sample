//
// Reference
//   http://nn-hokuson.hatenablog.com/entry/2017/05/31/210808
//   https://docs.opencv.org/3.1.0/d2/dcb/demhist_8cpp-example.html
//   http://answers.opencv.org/question/58078/reading-a-sequence-of-files-within-a-folder/
//
#include <iostream>
#include <vector> // glob
#include <algorithm> // for_each

//#include <opencv/cv.hpp> // includes some opencv2 headers (conveninent)
#include <opencv2/highgui.hpp> // imread, imwrite, glob
#include <opencv2/imgproc.hpp> // cvtColor, COLOR_RGB2GRAY, Sobel

int main() {
    std::cout << "opencv sample" << std::endl;

    // enumerate files in current directory
    std::vector<cv::String> files;
    cv::glob(".", files); 
    std::for_each(files.begin(), files.end(), [](cv::String file) {
        std::cout << file << std::endl;
    });

    // convert
    cv::Mat dst, gray;
    cv::Mat img = cv::imread("input.jpg");
    cv::cvtColor(img, gray, cv::COLOR_RGB2GRAY);
    cv::Sobel(gray, dst, -1, 1, 0);
    cv::imwrite("output.jpg", dst);

    return 0;
}
