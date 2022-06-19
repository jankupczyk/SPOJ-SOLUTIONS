import sys
import math

s = sys.stdin.readline()
s = int(s)

list = sys.stdin.readline()
list = list.split()

k = sys.stdin.readline()
k = int(k)

for i in range(k):
    n = sys.stdin.readline()
    n = int(n)
    l = 0
    p = s-1
    tekst = "NIEOBECNY"
    while p>=l:
        tb_ = int((l+p)/2)
        if int(list[tb_])== n:
            tekst = tb_ +1
            break
        if int(list[tb_])> n:
            p=tb_-1
        if int(list[tb_]) < n:
            l = tb_+1
    print(tekst)