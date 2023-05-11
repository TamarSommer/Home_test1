import tkinter as tk
import rectangular_tower
import round_building


# Create a function to handle button clicks


def main():
    # Create the main window and set its size
    window = tk.Tk()
    window.title("Button Window")
    window.geometry("400x300")

    # Create a grid to hold the buttons
    button_frame = tk.Frame(window)
    button_frame.pack(expand=True)

    # Create the buttons and add them to the grid
    button1 = tk.Button(button_frame, text="Button 1", command=rectangular_tower.add_two_numbers, height=3, width=10,
                        font=("Arial", 16))
    button1.grid(row=0, column=0, padx=10, pady=10)

    button2 = tk.Button(button_frame, text="Button 2", command=round_building.round_window, height=3, width=10,
                        font=("Arial", 16))
    button2.grid(row=0, column=1, padx=10, pady=10)

    button3 = tk.Button(button_frame, text="Button 3" ,command=window.destroy, height=3, width=10,
                        font=("Arial", 16))
    button3.grid(row=1, column=0, columnspan=2, padx=10, pady=10)

    # Start the event loop to display the window and handle user input
    window.mainloop()

if __name__ == "__main__":
    main()



