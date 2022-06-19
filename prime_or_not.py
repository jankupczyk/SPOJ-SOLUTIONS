import sys
a=int(input())
for p in sys.stdin:
	s=int(p)
	if(pow(2,s-1,s)>1 or pow(3,s-1,s)>1 or s==1):
		print("NO")
	else:
		print("YES")