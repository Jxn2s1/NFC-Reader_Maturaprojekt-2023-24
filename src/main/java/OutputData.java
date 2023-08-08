import com.fasterxml.jackson.databind.ObjectMapper;
import java.io.File;
import java.io.IOException;
import java.util.HashMap;
import java.util.Map;

//Klasse zum ausgeben der formatierten Daten
public class OutputData {
    private ExampleNfcData data;
    private String outputString;
    private int numberOfData;

    //Constructor der OutputData Klasse
    public OutputData(ExampleNfcData data) {
        this.data = data;
        numberOfData = data.getNumberOfData();
        outputString = "Data number " + data.getNumberOfData() + " contains " + data.getTextValue1() + " and " +
                data.getTextValue2() + " and " + data.getTextValue3() + ".";

        System.out.println(outputString);
    }

    public void outputToJson() {
            //Puts the Content of the NFC-Chips in the Output.json
            ObjectMapper objectMapper = new ObjectMapper();

            File outputFile = new File("src/main/java/Output.json");

            Map<String, Object> jsonMap = new HashMap<>();
        jsonMap.put("outputString", outputString);
        jsonMap.put("numberOfData", numberOfData);

            try {
                objectMapper.writeValue(outputFile, jsonMap);
                System.out.println("Data written to Output.json successfully.");
            } catch (IOException e) {
                e.printStackTrace();
            }
        }

}
