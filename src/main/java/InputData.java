import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

public class InputData {
    private String data;

    public InputData() {

    }

    public String[] inputFromTxt() {
        String filePath = "exampleData.txt"; // Replace with the actual file path

        ArrayList<String> filteredLines = new ArrayList<>();

        try (BufferedReader reader = new BufferedReader(new FileReader(filePath))) {
            String line;
            while ((line = reader.readLine()) != null) {
                if (line.startsWith("2B")) {
                    filteredLines.add(line.substring(2)); // Remove the "2B" prefix and add to the list
                }
            }
        } catch (IOException e) {
            e.printStackTrace();
        }

        String[] filteredLinesArray = filteredLines.toArray(new String[0]);

        // Print the filtered lines
        for (String line : filteredLinesArray) {
            System.out.println(line);
        }

        return filteredLinesArray;
    }
}
