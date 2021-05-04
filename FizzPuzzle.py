
def FizzBuzz(num):
    fizz = num %3 == 0
    buzz = num %5 == 0
    fizzbuzz = fizz and buzz
    
    if fizzbuzz:
        return "FizzBuzz"
    elif fizz:
        return "Fizz"
    elif buzz:
        return "Buzz"
    else:
        return num

for i in range(30):
    print(FizzBuzz(i))
    

