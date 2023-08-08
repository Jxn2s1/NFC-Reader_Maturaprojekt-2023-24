import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.SerializationFeature;
import com.fasterxml.jackson.databind.node.ObjectNode;
import java.io.File;
import java.io.IOException;

//Klasse zum ausgeben der formatierten Daten
public class OutputData {
    private String outputString;
    private int numberOfData;

    //Constructor der OutputData Klasse
    public OutputData(String outputString, int numberOfData) {
        this.outputString = outputString;
        this.numberOfData = numberOfData;
    }

    //Just for clearing the Output.json
    public OutputData() {
    }

    public void outputToJson() {
        //Puts the Content of the NFC-Chips in the Output.json
        ObjectMapper objectMapper = new ObjectMapper();
        objectMapper.enable(SerializationFeature.INDENT_OUTPUT);

        File outputFile = new File("src/main/java/Output.json");

        try {
            ObjectNode jsonNode;
            if (outputFile.exists()) {
                jsonNode = (ObjectNode) objectMapper.readTree(outputFile);
            } else {
                jsonNode = objectMapper.createObjectNode();
            }

            numberOfData = numberOfData + 1;
            ObjectNode newDataNode = objectMapper.createObjectNode();
            newDataNode.put("outputString", outputString);
            newDataNode.put("numberOfData", numberOfData);

            jsonNode.set(String.valueOf("Data " + numberOfData), newDataNode);

            objectMapper.writeValue(outputFile, jsonNode);
            System.out.println("Data appended to Output.json successfully.\n");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public void clearJsonFile() {
        File outputFile = new File("src/main/java/Output.json");
        outputFile.delete(); // Delete the file if it exists
        System.out.println("\nJSON file cleared\n.");
}

}