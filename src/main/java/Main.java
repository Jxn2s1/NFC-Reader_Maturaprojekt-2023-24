import java.util.Scanner;
import java.util.HashSet;

public class Main {
    public static void main(String[] args) {

        // Clears the Output.json before starting
        OutputData justToClear = new OutputData();
        justToClear.clearJsonFile();
        StartInConsole.put();

        Scanner scanner = new Scanner(System.in);
        HashSet<String> scannedChips = new HashSet<>(); // Set to store scanned NFC chips
        boolean exit = false;
        int i = 0;

        // Runs until Exit-Chip is scanned
        while (!exit) {

            System.out.println("Please scan NFC-Chips");
            String inputData = scanner.nextLine();
            System.out.println(inputData);

            // Exits if the exit chip is scanned
            if (inputData.equals("9abc3c04")) {
                exit = true;
            } else {
                // Check if the chip has already been scanned
                if (!scannedChips.contains(inputData)) {
                    OutputData outputData = new OutputData(inputData, i);
                    outputData.outputToJson();
                    scannedChips.add(inputData); // Add scanned chip to the set
                    i++;
                } else {
                    System.out.println("Chip already scanned. Ignoring duplicate.");
                }
            }
        }
        scanner.close();

        // Opens the DataBaseController.exe and allows to access the Data from the Database
        DataBaseController.openController();

        // Opens the WebController.exe and allows to access the Data from the Database
        // WebController.openController();

        // Opens the WebPage with the Data
        // OpenWebInterface.open();
    }
}
