#!/bin/python3

import math
import os
import random
import re
import sys
import collections

#
# Complete the 'beautifulTriplets' function below.
#
# The function is expected to return an INTEGER.
# The function accepts following parameters:
#  1. INTEGER d
#  2. INTEGER_ARRAY arr
#

def beautifulTriplets(d, arr):    
    count = 0
    l = len(arr)
    i = 0
    while(i < l - 2):
        c = 0
        ni = 1
        j = i + 1
        while(arr[i] == arr[j] and j < l):
            j+=1
            ni +=1
        prev = arr[i]
        for k in range(j , l, 1):
            if(arr[k] - prev == d):
                c += 1   
                prev = arr[k]         
            if(c == 2):
                count += ni
                break
        i += ni
    return count

if __name__ == '__main__':
    #fptr = open(os.environ['OUTPUT_PATH'], 'w')

    first_multiple_input = input().rstrip().split()

    n = int(first_multiple_input[0])

    d = int(first_multiple_input[1])

    arr = list(map(int, input().rstrip().split()))

    result = beautifulTriplets(d, arr)

    print(result)
    #fptr.write(str(result) + '\n')

    #fptr.close()
