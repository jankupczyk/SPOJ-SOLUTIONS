reverse_number = int(input(""))
 
number = 0
 
while(reverse_number>0):
  tty = reverse_number % 10
  number = (number * 10) + tty
  reverse_number = reverse_number//10
 
print("{}".format(number))