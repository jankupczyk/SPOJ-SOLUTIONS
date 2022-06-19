import math

def isPrime(n):
    if n%2==0 and n>2 or n==1:
        return False
    return all (n % i for i in range(3,int(math.sqrt(n))+1,2))

n=int(input())
if n<100000:
    for i in range(0,n):
        number=int(input())
        if isPrime(number):
            print('TAK')
        else:
            print('NIE')