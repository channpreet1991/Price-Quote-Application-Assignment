#include <stdio.h>
int main() {
   float weight, width, height, length, quote;
   printf("Welcome to Package Express. Please follow the instructions below.\n");
   printf("Please enter the package weight:\n");
   scanf("%f", &weight);
   if(weight > 50) {
       printf("Package too heavy to be shipped via Package Express. Have a good day.");
       return 0;
   }
   printf("Please enter the package width:\n");
   scanf("%f", &width);
   printf("Please enter the package height:\n");
   scanf("%f", &height);
   printf("Please enter the package length:\n");
   scanf("%f", &length);
   if(width+height+length > 50) {
       printf("Package too big to be shipped via Package Express.");
       return 0;
   }
   quote = width*height*length*weight/100;
   printf("Your estimated total for shipping this package is: $%.2f\n Thank you.", quote);
   return 0;
}