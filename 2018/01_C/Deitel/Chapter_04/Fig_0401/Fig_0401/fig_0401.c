// Fig. 4.1: Fig_0401.c
// Counter-conrolled repetition.
#include <stdio.h>

// function main begins program execution
int main(void)
{
	unsigned int counter = 1; // initialization

	while (counter <= 10) {
		printf("%u\n", counter); // display counter
		++counter; // increment
	} // end while
} // end funcion main