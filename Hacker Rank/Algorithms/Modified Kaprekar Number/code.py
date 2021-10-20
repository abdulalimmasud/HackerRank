#!/bin/python3

import math
import os
import random
import re
import sys


# Complete the 'kaprekarNumbers' function below.

# The function accepts following parameters:
#  1. INTEGER p
#  2. INTEGER q


def kaprekarNumbers(p, q):
    kp = []
    if(p == 1):
        kp.append(1)
        p = 9
    while(p <= q):
        sq_p = p * p
        count = 1
        while not sq_p == 0:
            count += 1
            sq_p = sq_p / 10
        sq_p = p * p
        r = 0
        while r < count:
            r += 1
            eq_parts = int(10**r)
            if eq_parts == p:
                continue
            sum = int(sq_p / eq_parts + sq_p % eq_parts)
            #Need to improve here
            if sum == p:
                kp.append(p)
        p += 1

    if(len(kp) == 0):
        print('INVALID RANGE')
    else:
        kp = sorted(set(kp))
        for i in kp:
            print (i, end=' ')
    
if __name__ == '__main__':
    p = int(input().strip())

    q = int(input().strip())

    kaprekarNumbers(p, q)
