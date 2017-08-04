//
//
// Intents Technologies, Joshua Latusia, 2017-05-15

#include "opencv2/imgproc/imgproc.hpp" 
#include "opencv2/highgui/highgui.hpp"
#include "opencv2/opencv.hpp"
#include <iostream>
#include <string>
#include "blobdetectionavans.h"

// Global defines

#define RED_ID 1
#define RED_TRESHOLD_LOW 40
#define RED_TRESHOLD_HIGH 85

#define BLUE_ID 2
#define BLUE_TRESHOLD_LOW 28
#define BLUE_TRESHOLD_HIGH 39

#define BLACK_TRESHOLD_LOW 20
#define BLACK_TRESHOLD_HIGH 55

#define ALL_COLORS_ID 3
#define CARDS_TRESHOLD_LOW 30
#define CARDS_TRESHOLD_HIGH 85

#define BUILT_IN_CAM 0
#define EXTERNAL_CAM 1

// Area tresholds of figures

#define SQUARE_MAX_AREA 1000
#define SQUARE_MIN_AREA 850

#define ROUND_MAX_AREA 800
#define ROUND_MIN_AREA 680

#define HEART_MAX_AREA 380
#define HEART_MIN_AREA 300

#define STAR_MAX_AREA 250
#define STAR_MIN_AREA 170

#define ARROW_MAX_AREA 150
#define ARROW_MIN_AREA 50


using namespace cv;
using namespace std;



// Converts A image to greyImg
void imgTogrey(Mat &img)
{
	cvtColor(img, img, CV_BGR2GRAY);
}

// Tresholds an img between two values and doesn't overwrite the original image
// Vals between the treshold are marked 1, rest is 0
void imgTresholdBetween(int upperval, int lowerval, Mat originalimg, Mat &tresholdimg)
{
	if (upperval < lowerval)
	{
		int temp = upperval;
		upperval = lowerval;
		lowerval = temp;
	}
	inRange(originalimg, Scalar(lowerval), Scalar(upperval), originalimg);
	threshold(originalimg, tresholdimg, 250, 1, CV_THRESH_BINARY);

}


// Tresholds an img between two values but overwrites the original image
// Vals between the treshold are marked 1, rest is 0
void imgTresholdBetween(int upperval, int lowerval, Mat &img)
{
	if (upperval < lowerval)
	{
		int temp = upperval;
		upperval = lowerval;
		lowerval = temp;
	}
	inRange(img, Scalar(lowerval), Scalar(upperval), img);
	threshold(img, img, 250, 1, CV_THRESH_BINARY);
}

// Tresholds an img between two values, overwrites the original
// Valls in the treshold are marked 170 so they appear visible
void imgTresholdBetweenDebug(int upperval, int lowerval, Mat &img)
{
	inRange(img, Scalar(lowerval), Scalar(upperval), img);
	threshold(img, img, 250, 170, CV_THRESH_BINARY);
}

void initCamera(VideoCapture cap)
{
	// TODO check if 
	// Controle of de camera wordt herkend.
	if (cap.isOpened())
	{
		// width and heigt of frame get detirmined
		double dWidth = cap.get(CV_CAP_PROP_FRAME_WIDTH);
		double dHeight = cap.get(CV_CAP_PROP_FRAME_HEIGHT);
		cout << "Frame size : " << dWidth << " x " << dHeight << endl;

		// Window maken waarin de beelden "live" getoond worden
		//namedWindow("MyVideo", CV_WINDOW_AUTOSIZE);		
	}

	else
		cout << "Cannot open the video cam" << endl;

}

// A VideoCapture needs to be initialized
// Screencapture with a given camera and convert this automaticly to a grey img
void captureGreyImg(VideoCapture cap, Mat &greyImg)
{
	// Read a new frame
	bool bSuccess = cap.read(greyImg);

	// Check if frame is correct
	if (bSuccess)
	{
		imgTogrey(greyImg);
	}
	else
		cout << "Cannot read a frame from video stream" << endl;
}

// Detection of characters  by area (here you can instert extra functionality what happens with each card.
void detectCharacters(const vector<Point2d *> centerVec, const vector<int> areaVec, int &meleeUnits, int &bruteUnits, int &magicUnits, int &castle)
{
	// Sets all units to 0 to detect errors
	meleeUnits = 0;
	bruteUnits = 0;
	magicUnits = 0;
	castle = 0;

	// Determines what happens with each type of card
	// TODO put right unit with right type of card
	for (int i = 0; i < centerVec.size(); i++) 
	{
		if (areaVec[i] > ARROW_MIN_AREA && areaVec[i] < ARROW_MAX_AREA)
		{
			// makes it possible to add future functionality
		}
		if (areaVec[i] > STAR_MIN_AREA && areaVec[i] < STAR_MAX_AREA)
		{
			magicUnits++;
		}
		if (areaVec[i] > HEART_MIN_AREA && areaVec[i] < HEART_MAX_AREA)
		{
			castle++;
		}
		if (areaVec[i] > ROUND_MIN_AREA && areaVec[i] < ROUND_MAX_AREA)
		{
			meleeUnits++;
		}
		if (areaVec[i] > SQUARE_MIN_AREA && areaVec[i] < SQUARE_MAX_AREA)
		{
			bruteUnits++;
		}
	}


}




// Makes a screencapture (Grey) and counts the amount of cards using the black outline of the cards
// TODO define certain parameter values when setup is final
// TODO Delete the MAT parameter and uncomment the caputre camera code
void countAllCards(VideoCapture cap, int &cards, Mat greyImg, const int colorID)
{
	int uppertresholdval = 0;
	int lowertresholdval = 0;

	// Determines the treshold values 
	// TO lazy to convert code to a switch
	if (colorID < RED_ID || colorID > ALL_COLORS_ID)
	{
		cout << colorID << ": is invalid" << endl;
		cards = -1;
		return;
	}
	if (colorID == RED_ID)
	{
		uppertresholdval = RED_TRESHOLD_HIGH;
			lowertresholdval = RED_TRESHOLD_LOW;
	}

	if (colorID == BLUE_ID)
	{
		uppertresholdval = BLUE_TRESHOLD_HIGH;
		lowertresholdval = BLUE_TRESHOLD_LOW;
	}

	if (colorID == ALL_COLORS_ID)
	{
		uppertresholdval = CARDS_TRESHOLD_HIGH;
		lowertresholdval = CARDS_TRESHOLD_LOW;
	}

	// Captures img of board and convert to grey img
	//Mat greyImg;
	//captureGreyImg(cap, greyImg);

	imshow("Test2", greyImg);
	waitKey(1);

	// Makes img smaller for faster tresholding
	Mat smallerImg;
	resize(greyImg, smallerImg, Size(480, 270), 0, 0, INTER_CUBIC);
	imshow("Small img", smallerImg);

	// Tresholding and morphology to get needed colors
	// TODO define treshold values when setup is final
	imgTresholdBetween(uppertresholdval, lowertresholdval, smallerImg);
	
	// TODO define erode and dilate factors when setup is final
	erode(smallerImg, smallerImg, Mat(), Point(-1, -1), 1, 1, 1);
	erode(smallerImg, smallerImg, Mat(), Point(-1, -1), 1, 1, 1);
	dilate(smallerImg, smallerImg, Mat(), Point(-1, -1), 2, 1, 1);
	imshow("Dilation", smallerImg);

	
	//// converten to Mat obj with greater depth 16-bit signed
	Mat binary16S;
	smallerImg.convertTo(binary16S, CV_16S);

	show16SImageStretch(binary16S,"Test2");

	// Variables to save blob info 
	Mat labeledImage3;
	vector<Point2d *> firstpixelVec3;
	vector<Point2d *> posVec3;
	vector<int> areaVec3;
	labelBLOBsInfo(binary16S, labeledImage3,
		firstpixelVec3, posVec3, areaVec3, 60, 30000);
	show16SImageStretch(labeledImage3, "Labeled Image 3");
	
	int meleeUnits, bruteUnits, magicUnits, castle;

	// Determines the shape and thus the character of each card
	detectCharacters(posVec3, areaVec3, meleeUnits, bruteUnits, magicUnits, castle);

	cout << "Melee Cnt: " << meleeUnits << "  Brute Cnt: " << bruteUnits << "  Magic Cnt: " << magicUnits << "  Castle cnt : " << castle << endl;

	// print data to console 
	cout << "Aantal gevonden BLOBs = " << firstpixelVec3.size() << endl;
	for (int i = 0; i < firstpixelVec3.size(); i++) {
		cout << "BLOB " << i + 1 << endl;
		cout << "firstpixel = (" << firstpixelVec3[i]->x << "," << firstpixelVec3[i]->y << ")" << endl;
		cout << "centre = (" << posVec3[i]->x << "," << posVec3[i]->y << ")" << endl;
		cout << "area = " << areaVec3[i] << endl;
	}

	//// Amount of cards is equal to elements of amount of first pixels
	cards = firstpixelVec3.size();

}



int main(int argc, char *argv[])
{
	// Open camera
	VideoCapture cap(BUILT_IN_CAM);
	initCamera(cap);



	if (argc != 2)
	{
		cout << "NB! Geef als command argument volledige padnaam van de imagefile mee" << endl;
		return -1;
	}
	else cout << "De imagefile = " << argv[1] << endl;

	// Lees de afbeelding in
	Mat image;
	image = imread(argv[1], CV_LOAD_IMAGE_COLOR);

	if (!image.data)
	{
		cout << "Could not open or find the image" << std::endl;
		return -1;
	}

	imgTogrey(image);
	//imshow("Test", image);

	int cards = 0;
	countAllCards(cap, cards, image, RED_ID);
	//imgTresholdBetween(CARDS_TRESHOLD_HIGH, CARDS_TRESHOLD_LOW, image);
	Mat greyImg;
	

	while (1)
	{

		// If Space is pressed Cap screen
   		if (waitKey(1) == 32)
		{
			// Needs a active screen in order to cap more screens.
			captureGreyImg(cap, greyImg);
			imshow("Capture Grey", greyImg);
		}

		// If 1 is pressed Count cards
		if (waitKey(1) == 49)
		{
			// Needs a active screen in order to cap more screens.
			captureGreyImg(cap, greyImg);
			imshow("Capture Grey", greyImg);
		}

		//  Wacht 30 ms op ESC-toets. Als ESC-toets is ingedrukt verlaat dan de loop
		if (waitKey(1) == 27)
		{
			cout << "esc key is pressed by user" << endl;
			break;
		}
	}

	return 0;


}


