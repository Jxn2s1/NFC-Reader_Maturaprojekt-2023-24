public class Main {
    public static void main(String[] args) {
        //Übergangsmäßige Datei welche den Output der NFC-Chips simuliert
        ExampleNfcData nfcData = new ExampleNfcData(1, "This is the first set of Data", "have fun using it", "just for test purposes");

        //Aufruf der Klasse Output und der Funktion welche die Daten formatiert in die Console ausgibt
        OutputData outputData = new OutputData(nfcData);
        outputData.output();
    }
}