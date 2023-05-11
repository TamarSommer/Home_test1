import tkinter as tk


def calc(height, width):
    return 2 * height + width

def printable(h, w):
    if (w // 2) == 1 and w < 2*h:
        return true
    else:
        return false


def build_triangle(height, width):
    # Initialize the triangle string with the top row
    triangle = ' ' * (width // 2) + '*' + '\n'

    # Build the middle rows
    for i in range(2, height):
        row_width = 2 * i - 1
        row = ' ' * ((width - row_width) // 2) + '*' * row_width + '\n'
        triangle += row

    # Add the bottom row
    bottom_row = '*' * width + '\n'
    triangle += bottom_row

    # Return the triangle as a string
    return triangle


def round_window():
    def calculate_sum():
        try:
            num1 = float(num1_entry.get())
            num2 = float(num2_entry.get())
            result_dispaly.config(text=calc(num1, num2))
        except ValueError:
            result_label.config(text="Invalid input, please enter numbers only.")

    def print_tri_building():
        height = float(num1_entry.get())
        width = float(num2_entry.get())
        if printable(height, width):
            result_dispaly.config(text=build_triangle(height, width))
        else:
            result_label.config(
                text="This building is not printable.\nWidth must be an odd number and less than twice the height.")

    # Create the main window
    root = tk.Tk()
    root.title("round")
    root.geometry("300x250")

    # Create the number input fields and labels
    num1_label = tk.Label(root, text="height:")
    num1_entry = tk.Entry(root)
    num2_label = tk.Label(root, text="width:")
    num2_entry = tk.Entry(root)

    # Create the calculate button and result label
    calculate_width_button = tk.Button(root, text="Calculate triangle perimeter", command=calculate_sum)
    print_button = tk.Button(root, text="print triangle", command=print_tri_building)
    result_label = tk.Label(root, text="Result:")
    result_dispaly = tk.Label(root, text="")

    # Pack the widgets in the window
    num1_label.pack()
    num1_entry.pack()
    num2_label.pack()
    num2_entry.pack()
    calculate_width_button.pack()
    print_button.pack()
    result_label.pack()
    result_dispaly.pack()

    # Start the main event loop
    root.mainloop()
