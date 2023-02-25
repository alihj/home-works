#include <iostream>
using namespace std;

int main() {
  int arr[10] = {4, 2, 8, 5, 1, 6, 7, 9, 3, 0};

  cout << "Original array:" << endl;
  for(int i = 0; i < 10; i++) {
    cout << arr[i] << endl;
  }

  for(int i = 0; i < 10; i++) {
    for(int j = i+1; j < 10; j++) {
      if(arr[i] > arr[j]) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
      }
    }
  }

  cout << "Sorted array:" << endl;
  for(int i = 0; i < 10; i++) {
    cout << arr[i] << endl;
  }

  return 0;
}
