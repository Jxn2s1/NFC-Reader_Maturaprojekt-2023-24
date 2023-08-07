public class Main {
    public static void main(String[] args) {
        //Übergangsmäßige Datei welche den Output der NFC-Chips simuliert
        ExampleNfcData nfcData = new ExampleNfcData(1, "This is the first set of Data", "have fun using it", "just for test purposes");

        //Aufruf der Klasse Output und der Funktion welche die Daten formatiert in die Console ausgibt
        OutputData outputData = new OutputData(nfcData);
        outputData.outputToJson();

        try {
            // Read the modified JSON content and output it
            String modifiedJsonContent = outputData.readJsonFromFile();
            System.out.println("Modified JSON content:\n" + modifiedJsonContent);

            Thread.sleep(15000);
            System.out.println("After waiting for 15 seconds!");
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

}