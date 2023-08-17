

//Not used in this version

import java.util.Scanner;

public class NfcInput {
    private boolean running = true;
    private String[] inputArray = new String[100]; // Adjust the size as needed
    private int currentIndex = 0;

    public void start() {
        Scanner scanner = new Scanner(System.in);

        while (running && currentIndex < inputArray.length) {
            System.out.print("Enter a command (type 'exit' to quit): ");
            String userInput = scanner.nextLine();

            if (userInput.equalsIgnoreCase("exit")) {
                running = false;
                System.out.println("Exiting...");
            } else {
                inputArray[currentIndex] = userInput;
                currentIndex++;
                System.out.println("You entered: " + userInput);
            }
        }

        scanner.close();
    }

    public String[] getInputArray() {
        return inputArray;
    }

    public static void main(String[] args) {
        NfcInput nfcInput = new NfcInput();
        nfcInput.start();

        String[] inputArray = nfcInput.getInputArray();
        System.out.println("Inputs (except 'exit'):");
        for (String input : inputArray) {
            if (input != null) {
                System.out.println(input);
            }
        }
    }
}
