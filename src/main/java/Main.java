import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        //Clears the Output.json before starting
        OutputData justToClear = new OutputData();
        justToClear.clearJsonFile();
        StartInConsole.put();

        Scanner scanner = new Scanner(System.in);
        boolean exit = false;
        int i = 0;

        //Runs until Exit-Chip is scanned
        while (!exit) {

            System.out.println("Please scan NFC-Chips");
            String inputData = scanner.nextLine();
            System.out.println(inputData);

            //Exits if the exit chip is scanned
            if (inputData.equals("9abc3c04"))
            {
                exit = true;
            }
            else {
                OutputData outputData = new OutputData(inputData, i);
                outputData.outputToJson();
                i++;
            }
        }
        scanner.close();

        //Opens the DataBaseController.exe and allows to access the Data from the Database
        DataBaseController.openController();

        //Opens the WebController.exe and allows to access the Data from the Database
        //WebController.openController();

        //Opens the WebPage with the Data
        //OpenWebInterface.open();

    }
}