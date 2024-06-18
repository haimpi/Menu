# Menu System

This project provides a menu system implemented using interfaces and delegates in C#.

## Interfaces

### ActionMenuItem
- Represents a menu item that performs an action when selected.
- Inherits from `MenuItem`.
- Contains a reference to an `IExecute` instance that defines the action to be executed.

### IExecute
- Interface for executing an action.

### MainMenu
- Represents the main menu of the application.
- Contains a collection of menu items (`SubMenu`) and provides methods to add items and display the menu.

### MenuItem
- Abstract class representing a menu item.
- Contains the name of the menu item (`MenuItemName`) and an abstract method `Execute` to execute the menu item's action.

### SubMenu
- Represents a submenu within the main menu.
- Inherits from `MenuItem`.
- Contains a collection of menu items (`MenuItem`) and provides methods to add items, display the submenu, and handle user input.

## Delegates

### MainMenu
- Represents the main menu of the application using delegates.
- Contains a collection of menu items (`MenuItem`) and provides methods to add items and display the menu.

### MenuItem
- Abstract class representing a menu item using delegates.
- Contains the name of the menu item (`MenuItemName`) and an abstract method `Show` to display the menu item.

### SubMenu
- Represents a submenu within the main menu using delegates.
- Inherits from `MenuItem`.
- Contains a collection of menu items (`MenuItem`) and provides methods to add items, display the submenu, and handle user input.

### TaskMenu
- Represents a menu item that executes a task when selected using delegates.
- Inherits from `MenuItem`.
- Contains an event `ExecutedTask` that triggers the task execution when raised.

## Test Classes

### CountCapitals
- Implements `IExecute`.
- Contains a method `CountCapitalsLetters` to count the number of capital letters in a user-provided sentence.

### DelegateUsage
- Demonstrates the usage of the menu system with delegates.
- Creates and displays a main menu with submenus and tasks using delegates.

### InterfaceUsage
- Demonstrates the usage of the menu system with interfaces.
- Creates and displays a main menu with submenus and actions using interfaces.

### ShowDate
- Implements `IExecute`.
- Contains a method `ShowCurrentDate` to display the current date.

### ShowTime
- Implements `IExecute`.
- Contains a method `ShowCurrentTime` to display the current time.

### ShowVersion
- Implements `IExecute`.
- Contains a method `ShowVersionMethod` to display the current version.
