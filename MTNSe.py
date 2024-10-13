

class MTNServices:
    #while True:
        def __init__(self):
            self.balance = 0
        def show_balance(self):
            print('your current balance is $',self.balance)
        def deposit(self):
            amount = float(input('enter amount to deposit:'))
            if amount > 0:
                self.balance += amount
                print(f'you have successful deposited ${amount}')
            else:
                print("you should enter valid amount! please enter positive number")
        def with_draw(self):
            amount = float(input('enter amount to withdraw:'))
            if 0 < amount <= self.balance :
                self.balance -= amount
                print(f'you have succeful withdraw ${amount} ')
            elif amount > self.balance:
                print('insufficiency balance please reload your balance')
            elif amount <= 0:
                print('you have entered negative number try positive')
            else:
                print()
        def main(self):
            while (True):
                print("________________\n")
                print('1.show balance')
                print('2.deposit')
                print('3.with draw')
                print('4.exit')
                
                choice = input("enter your choice:")
                if choice == '1':
                    self.show_balance()
                elif choice == '2':
                    self.deposit()
                elif choice == '3':
                    self.with_draw()
                elif choice == '4':
                    print('thank you for using our service!')
                    break
                else:
                    print("invalid input try [1,2,3 or 4]")
                    
if __name__ == "__main__":
        MTNServices().main()