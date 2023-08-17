import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        //Clears the Output.json before starting
        OutputData justToClear = new OutputData();
        StartInConsole startInConsole = new StartInConsole();
        justToClear.clearJsonFile();

        Scanner scanner = new Scanner(System.in);
        boolean exit = false;
        int i = 0;

        while (!exit) {
            //Gets the inputData from .txt file (Not used)
            //InputData inputData = new InputData();

            System.out.println("Please scan NFC-Chips or type exit to quit");
            String inputData = scanner.nextLine();
            startInConsole.put();
            //System.out.println(inputData);

            if (inputData.equals("exit")){
                exit = true;
            }
            else {
                OutputData outputData = new OutputData(inputData, i);
                outputData.outputToJson();
                i++;
            }
        }
        scanner.close();

        // Übergangsmäßige Dateien welche den Output der NFC-Chips simulieren (Not used)
        /*String nfcData[] = {"This is the first set of Data", "have fun using it", "just for test purposes", "just need a few more Datasets",
                "so here we go", "Test Test Test", "1 2 3", "4 5 6", "Test erfolgreich", "10ter Test schaut alles gut aus  "};*/

        //Takes everything in the nfcData array and puts it though the OutputData.java (Not used)
        /*int i = 0;
        for (String data : inputData.inputFromTxt()) {
            System.out.println(data + "\n");
            OutputData outputData = new OutputData(data, i);
            outputData.outputToJson();
            i++;
        }*/

        //Automatically opens the GitHub Pages site and shows the Web Interface
        OpenWebInterface openWebInterface = new OpenWebInterface();
        openWebInterface.open();

    }
}