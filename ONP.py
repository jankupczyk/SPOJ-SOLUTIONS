for i in range(int(input())):
    _input=input()
    table=[]
    stout=""
    for iv in _input:
        if(iv== '(' ):
            pass
        elif(ord(iv)>=97 and ord(iv)<=123):
            stout=stout+str(iv)
        elif(iv== ')' ):
            if(len(table)!=0):
                stout=stout+str(table.pop())
        else:
            table.append(iv)
    print(stout)