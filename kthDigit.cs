Given an integer, find its kth digit.

Example

For n = 578943 and k = 2, the output should be
kthDigit(n, k) = 7.
int kthDigit(int n, int k) {
 string s = ""+n;
    if(s.Length<k){
        return -1;
    }
    return int.Parse(""+s[k-1]);
}
