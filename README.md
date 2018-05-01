# RMVRTour
An Android VR House Tour of the Gainesville Ronald Mcdonald House
***How to Build the Unity Project to become an Android application***
You first need Unity to build/edit the project.
Install Unity and make sure to install Android/Ios support
*https://docs.unity3d.com/Manual/InstallingUnity.html
^This link will help you install Unity

**https://unity3d.com/learn/tutorials/topics/mobile-touch/building-your-unity-game-android-device-testing
**https://docs.unity3d.com/Manual/android-sdksetup.html
The two asterick(*)^ links above will help you set up your phone and unity for an Android app build.
!*!Warning the build might take as long as a couple of hours so be prepared for that.

For setting Up Google VR I recommend using the link below
***https://docs.unity3d.com/560/Documentation/Manual/VRDevices-GoogleVR.html
I recommend doing the bare minimum as Google Cardboard controls are limited and going the 
extra mile to install the controls is not worth it. Doing the above will at least run the
application in VR on an Android.

***How to run the apk(android package) file included in the Zip***
The apk file is an executable app you can run on your phone.
All you need to do is copy the apk file to your phone.
*https://airmore.com/install-apk-files-on-android.html
That ^ is a link to help you with the transfer process.
Find the RonaldMDRoom file on your phone.
**For finding the file i recommend going to your file manager and looking for it through 
**the "Local" tab if you put the file in the "Internal Storage" area. 
**Then navigate to the folder you downloaded it to.
Select it then it will ask it install. 
Say Yes to the install and you are done.

!*!Small note to move around in the project you look down. This could be changed.!*!
Also all triggers for the audio could be found in the following objects
iving room collider- floor object
big kitchen - BigKitchenFloor obj
hallway - HallwayCeiling
bedroom - Room/Floor(5) 
small kitchen - smallkitchenfloor
Click on the objects and look for the AudioPlay Script. 
It works off of Unity Trigger Colliders.
