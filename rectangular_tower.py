import tkinter as tk


def calc(height, width):
    if abs(height - width) > 5:
        return height * width
    else:
        return 2 * (height + width)


def add_two_numbers():
    def calculate_sum():
        try:
            num1 = float(num1_entry.get())
            num2 = float(num2_entry.get())
            result_dispaly.config(text=calc(num1, num2))
        except ValueError:
            result_label.config(text="Invalid input, please enter numbers only.")

    # Create the main window
    root = tk.Tk()
    root.title("rectangular")
    root.geometry("300x250")

    # Create the number input fields and labels
    num1_label = tk.Label(root, text="height:")
    num1_entry = tk.Entry(root)
    num2_label = tk.Label(root, text="width:")
    num2_entry = tk.Entry(root)

    # Create the calculate button and result label
    calculate_button = tk.Button(root, text="Calculate", command=calculate_sum)
    result_label = tk.Label(root, text="Result:")
    result_dispaly = tk.Label(root, text="")

    # Pack the widgets in the window
    num1_label.pack()
    num1_entry.pack()
    num2_label.pack()
    num2_entry.pack()
    calculate_button.pack()
    result_label.pack()
    result_dispaly.pack()

    # Start the main event loop
    root.mainloop()

# Call the add_two_numbers() function to run the program
