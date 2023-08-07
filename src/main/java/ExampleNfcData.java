public class ExampleNfcData {
    //Übergangsmäßige Daten zur simulation eines NFC-Chips

        //Nummer des NFC-Chips (1., 2., 3. Chip usw.)
        private int numberOfData;

        //Tatsächlicher Inhalt der NFC-Chips (Wird warscheinlich zu String geparst)
        private String textValue1, textValue2, textValue3;

        //Constructor der ExampleNfcDaten
        public ExampleNfcData(int numberOfData, String textValue1, String textValue2, String textValue3) {
            this.numberOfData = numberOfData;
            this.textValue1 = textValue1;
            this.textValue2 = textValue2;
            this.textValue3 = textValue3;
        }

        //Getter der einzelnen Felder der ExampleNfcData
        public int getNumberOfData() {
            return numberOfData;
        }

        public String getTextValue1() {
            return textValue1;
        }

        public String getTextValue2() {
            return textValue2;
        }

        public String getTextValue3() {
            return textValue3;
        }
}

