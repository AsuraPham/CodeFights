# CodeFights
Find the smallest integer not less than the given limit which is divisible by all integers from the given array.

Example

For divisors = [2, 3, 4] and start = 13, the output should be
firstMultiple(divisors, start) = 24.

//code
int firstMultiple(int[] divisors, int start) {
for (int answer = start;; answer++) {
			Boolean correct = true;
			for (int i = 0; i < divisors.Length; i++) {
				if (answer % divisors[i] != 0) {
					correct = false;
					break;
				}
			}
			if (correct) {
				return answer;
			}
		}
}
