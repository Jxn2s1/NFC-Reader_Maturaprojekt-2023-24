public class Main {
    public static void main(String[] args) {

        //Übergangsmäßige Datei welche den Output der NFC-Chips simuliert
        ExampleNfcData nfcData = new ExampleNfcData(1, "This is the first set of Data", "have fun using it", "just for test purposes");

        OutputData outputData = new OutputData(nfcData);

        outputData.outputToJson();

        //Pausiert das Programm für 15 Sekunden um die Output.json Datei einsehen zu können
        /*try {
            Thread.sleep(15000);
            System.out.println("After waiting for 15 seconds!");
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    */
    }
}