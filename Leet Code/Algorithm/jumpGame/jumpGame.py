def canJump(nums) -> bool:
        n = len(nums)
        i = 0
        m = 0
        while i < n and i <= m:
            m = max(i + nums[i], m)
            i += 1
        
        return True if i == n else False
    
if __name__ == '__main__':
    h = list(map(int, input().rstrip().split()))
    r = canJump(h)
    print(r)
