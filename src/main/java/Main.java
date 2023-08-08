public class Main {
    public static void main(String[] args) {
        OutputData justToClear = new OutputData();
        justToClear.clearJsonFile();

        // Übergangsmäßige Dateien welche den Output der NFC-Chips simulieren
        String nfcData[] = {"This is the first set of Data", "have fun using it", "just for test purposes"};

        int i = 0;
        for (String data : nfcData) {
            OutputData outputData = new OutputData(nfcData[i], i);
            outputData.outputToJson();
            i++;
        }

    }
}