public class Main {
    public static void main(String[] args) {
        //Clears the Output.json before starting
        OutputData justToClear = new OutputData();
        justToClear.clearJsonFile();

        // Übergangsmäßige Dateien welche den Output der NFC-Chips simulieren
        String nfcData[] = {"This is the first set of Data", "have fun using it", "just for test purposes", "just need a few more Datasets",
                "so here we go", "Test Test Test", "1 2 3", "4 5 6", "Test erfolgreich", "10ter Test schaut alles gut aus  "};

        //Takes everything in the nfcData array and puts it though the OutputData.java
        int i = 0;
        for (String data : nfcData) {
            OutputData outputData = new OutputData(nfcData[i], i);
            outputData.outputToJson();
            i++;
        }

    }
}