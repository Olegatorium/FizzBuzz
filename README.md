## Setup Local Instructions

1. Clone the repository using the following command:
   ```sh
   git clone <repository-url>
   ```
2. Open the project in Visual Studio.
3. Unit tests can be run using the **Test Explorer**.

Now the project is set up locally and ready for testing.

## Logic

1. If a word contains non-alphanumeric characters (e.g., `Appleram!@Banana`), it is considered a single word, and the special characters are ignored.
2. If a word consists only of non-alphanumeric characters (e.g., `%?@`), it is not counted and is skipped.
3. The **Output String** retains all non-alphanumeric characters and whitespaces. According to the task conditions, they are ignored in processing but not removed from the output.

## Unit Tests

- Implemented **6 unit tests** to verify the correct functionality of the program.
- Used **xUnit** for testing.

