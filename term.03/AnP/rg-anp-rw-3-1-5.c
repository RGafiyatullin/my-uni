
#include <stdio.h>
#include <math.h>

double milk_price_recursive( double p0, double d, int years ) {
	if ( years == 0 ) {
		return p0;
	}
	else {
		return milk_price_recursive( p0, d, years - 1 )
				 * (1.0 + d / 100.0) * (1.0 - d / 100.0);
	}
}

double milk_price_iterative( double p0, double d, int years ) {
	double p = p0;
	int i = 0;
	for (int i = 0; i < years; i++) {
		p = p * (1.0 + d / 100.0) * (1.0 - d / 100.0);
	}
	return p;
}

double milk_price_geometric_progression(
	double p0, double d, int years 
) {
	return p0 * pow( (1.0 + d / 100.0) * (1.0 - d / 100.0), (double)years );
}

void part_1() {
	int i = 0;
	double p0 = 100.0;
	double d = 6.76;
	printf("Initial price: %f\n", p0);
	printf("Percents: %f\n", d);

	for (i = 0; i <= 2000; i++) {
		if (
				(i < 20) || 
				(i < 200 && i % 10 == 0) ||
				(i % 100 == 0)
			)
		{
			double p_rec = milk_price_recursive(p0, d, i);
			double p_iter = milk_price_iterative(p0, d, i);
			double p_gp = milk_price_geometric_progression(p0, d, i);
			printf("Price in %d years:\t%f\t%f\t%f\n", i, p_rec, p_iter, p_gp );
		}
	}
}

/**
* Radix = 10 assumed
*/
int digits_count_10( int n ) {
	return ceil( log10l(n + 1) );
}
int least_significant_digits_10( int dc, int n ) {
	return n % (int)pow(10.0, (double)dc);
}
int part_2_test( int n ) {
	return n == least_significant_digits_10( digits_count_10(n), n * n);
}

void part_2() {
	int i = 0;
	for (i = 1; i <= 1000; i++) {
		if (part_2_test(i)) {
			printf("%d^2 = %d\n", i, i * i);
		}
	}
}

/**
* GCD - Greatest common divisor
* Euclid's algo implementation
*/
int gcd(int a, int b) {
	if (b > a) return gcd( b, a );
	if (b == 0) return a;
	return gcd( b, a % b );
}

void part_3() {
	int primes[] = {1,2,3,5,7,11,13,17,19,29};
	int ns[] = {1,2,4,5,9,12,14,35,95};
	int i = 0;
	for (i = 0; i < (sizeof(primes) / sizeof(int)) - 1; i++) {
		int a = primes[i];
		int b = primes[i + 1];
		printf("gcd(%d, %d) = %d\n", a, b, gcd(a, b));
	}
	for (i = 0; i < (sizeof(ns) / sizeof(int)) - 1; i++) {
		int a = ns[i];
		int b = ns[i + 1];
		printf("gcd(%d, %d) = %d\n", a, b, gcd(a, b));
	}
}

int main(int argc, char** argv) {
	printf("====== part 1 ======\n");
	part_1();
	printf("====== part 2 ======\n");
	part_2();
	printf("====== part 3 ======\n");
	part_3();
	return 0;
}

