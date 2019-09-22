# Python program to display the Fibonacci sequence up to n-th term using recursive functions

def recur_fibo(n):
   """Recursive function to
   print Fibonacci sequence"""
   if n <= 1:
       return n
   else:
       return(recur_fibo(n-1) + recur_fibo(n-2))

n=0
choice=input("Enter any other integer than 0 to continue")
while(choice!='0'):
     n = int(input("How many terms? "))
     # check if the number of terms is valid
     if n <= 0:
         print("Plese enter a positive integer")
     else:
         print("Fibonacci sequence:")
         for i in range(n):
             print(recur_fibo(i))
     choice=input("Enter any other integer than 0 to continue")
