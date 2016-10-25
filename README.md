# Quality Assurance-Engineer-Challenge

`version 1.0`
`challenge status: open`

Welcome! We've been expecting you. Holmusk is a big data based high tech company specializing in healthcare in Singapore.

If you're someone who bleeds code and aches to make a difference in the world, then you are at the right place. You will be part of a world‑class team working on the most exciting ground‑breaking technology in an inspiring and collaborative environment.


## Basics

This is the Holmusk Quality Assurance Engineer challenge. The rules of the challenge are very simple and are as follows

* You will be able to submit the challenge anytime you are ready provided the challenge is still open
* Your code should be commented
* Because we, at Holmusk, take code organization seriously, please do ensure your source files are organized when you submit
* You are required to fork this repo and submit a pull request
* If you wish to not make public, your submission, please complete the code in your local repository and email a patch file to careers@holmusk.com
* Please note that you will also be judged on the elegance of your code, level of abstraction and technical skills presented in the implementation. For more details, refer to the Judging Criteria section below.

## The Challenge 

### What You'll need to build

You will need to create a test script that tests the registration process of an app and generates a report at the end of the test. The test should be able to automatically register a new account and sign in the app and detects problems if any.

### Bits and Pieces to take note of
* You will test the apk file named "glyco_test.apk" found in this repository.
* You should create your own test specifications based on your experience with the registration flow in mobile app
* The test script should launch the emulator, deploy apk file and run the app, followed by new account registration with test credentials. The username must begin with "testchallenge".
* The script should be able to cover these paths:
* Success cases: register a new account successfully and verify that user has actually signed in with registered information.
* Failure cases: any case that leads to unsuccessful registration and sign in of a new account (the more the better).
* Other cases: cases that may lead to a suggestion in improvements of the app
* The test script should be able to be executed from local machine and generates a report at the end of the test.

## Judging Criteria
* What you have produced will determine your final outcome
* Test coverage of the script
* Because we love people who have a passion for expanding their horizons, your background with test frameworks do not matter so much provided you are able to demonstrate your learning ability!

## Bonus
* Usage of performance test, load test, traffic test...
* Usage of continuous integration frameworks: test script is triggered by a commit on the code or change in the APK file
* Testing on multiple devices and OS versions
* Usage the same code with minor modifications to test iOS app (Search "Glyco" on App Store)

** With that said we wish you good luck and look forward to receiving your submission!
