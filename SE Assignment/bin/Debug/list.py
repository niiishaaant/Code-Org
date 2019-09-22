choice=input("Enter any other number than 0 to continue")
while(choice != '0'):
    
    # creating an empty list 
    lst = [] 
  
    #  number of elemetns as input 
    n = int(input("Enter number of elements : ")) 
  
    # iterating till the range 
    for i in range(0, n): 
        ele = int(input()) 
  
        lst.append(ele) # adding the element 
      
    print(lst)
    choice=input("Enter any other number than 0 to continue")
