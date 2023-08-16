import java.awt.Desktop;
import java.io.IOException;
import java.net.URI;
import java.net.URISyntaxException;

public class OpenWebInterface {

    //Gets the URL and feeds it to the java.awt.Desktop
    public static void openWebPage(String url) {
        try {
            URI uri = new URI(url);
            Desktop.getDesktop().browse(uri);
        } catch (IOException | URISyntaxException e) {
            e.printStackTrace();
        }
    }

    //Contains the Link of the Website
    public static void open() {
        String link = "https://maturaprojekt-nfc-reader.github.io/";
        openWebPage(link);
    }
}
