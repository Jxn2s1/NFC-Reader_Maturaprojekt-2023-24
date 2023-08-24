//Number what Data which is displayed on the website | needed for the buttons in ChangeDiv* functions
var displayNum = 0;

//variables for Website creations | needed in CreateDiv function
var div_header = document.createElement('div');
var label1 = document.createElement('label');
var input1 = document.createElement('input');
var label2 = document.createElement('label');
var input2 = document.createElement('input');
var paragraph1 = document.createElement('p');
var paragraph2= document.createElement('p');
var newButton = document.createElement('button');
var newButton2 = document.createElement('button');
var RiseLogo = document.createElement('img');

//class with data for 1 set of labels and input boxes
class LastString{
    constructor(){
        this.OutputString = "";
        this.OutputText = "";
        this.NumberofData = "";
        this.DataNumber = "";
    }
}

//array class for all the data for the labels and input boxes
class AllLastStrings{
    constructor(){
        this.Strings = [];
    }
    newString(LastString)
    {
        this.Strings.push(LastString);
    }
    get allStrings()
    {
        return this.Strings;
    }
}

//creation of array needed for creating the website | needed in the fetch() function below
var allLastStrings = new AllLastStrings();

//reading out the data from the JSON file - will be replaced with database-reader in future
fetch('Output.json')
            .then(response => response.json())
            .then(data => {

                var arrayString = JSON.stringify(data);
                var CleanString = CleanJSON(arrayString);

                //The sorted String ready for display
                lastString = new LastString()

                //Count how many Strings get into one TestString
                var i = 0;

                //Count many Test Strings there are
                var j = 0;

                //puts every element in the right place for input into webpage
                CleanString.forEach(element => {

                    if(i==0){

                        lastString.OutputString = element;
                    }
                    if(i==1)
                    {
                        lastString.OutputText = element;

                    }
                    if(i==2)
                    {
                        lastString.NumberofData = element;
                    }
                    if(i==3)
                    {
                        lastString.DataNumber = element;

                        //new variable that gets created new with each set of data to minimize errors
                        var newlastString = new LastString();
                        newlastString.DataNumber = lastString.DataNumber;
                        newlastString.NumberofData = lastString.NumberofData;
                        newlastString.OutputString = lastString.OutputString;
                        newlastString.OutputText = lastString.OutputText;

                        allLastStrings.newString(newlastString);

                        j++;
                        i = -1;

                        //creates the html file when the first String is done
                        if(allLastStrings.allStrings.length == 1)
                        {
                        CreateDiv(allLastStrings.allStrings[0]);
                        }
                    }
                    i++;
                });
            });
//number of data sets in html | needed in SingleJSONStrings.forEach method
var k = 0;

//Cleans the JSON into an Array of "LastString" objects
function CleanJSON(Input){

//cuts of first "{" and last "}" from the raw String, read from the JSON
Input = Input.slice(1);
Input = Input.slice(0, this.length - 2);

//Splits the single raw String into multiple raw Strings
var MultipleJSONStrings = Input.split("}");
var NewMultipleJSONStringsLoop=[];
var NewMultipleJSONStrings=[];
var z = 0;

MultipleJSONStrings.forEach(element => {

    //number of digit's that are getting cut in front of the first string
    var u = 1;

    //chechs where the first "{" is to slice the String there
    while(MultipleJSONStrings[0].charAt(u) != "{"){
        u++;
    }
    u++;

    //if loop needed cause if a problem when the number of digit's is greater than 1
    if(u==10)
    {
    u++;
    }

    //slices String at the right point to clean it
    NewMultipleJSONStringsLoop[z]=MultipleJSONStrings[z].slice(u);
    NewMultipleJSONStrings[z]=MultipleJSONStrings[z].slice(u);

    z++;
});

//variables to sort the clean String's into the right place
var SingleJSONStrings = [];
var RAM = [];
    var t = 0;
    var r = 0;

NewMultipleJSONStringsLoop.forEach(element => {

    //cuts the String into 2 Strings and puts them onto an array
    RAM = NewMultipleJSONStrings[t].split(",");
    SingleJSONStrings[r] = RAM[0]
    r++;
    SingleJSONStrings[r] = RAM[1]
    r++;
    t++;
});

var Output = [];
var i =0;

//cleans the 2 String's on the array
SingleJSONStrings.forEach(element => {

    k++;

    //splits the 2 String's into the final raw form
    var Data = element.split(":");

    //checks every String and cleans them up to almost final form
    Data.forEach(element => {

        if(element.charAt(0) != '"' && element.charAt(0) != '{')
        {
            LastLetterElement=element;
        }
        if(element.charAt(0) == '{'){
            var FirstLetterElement = element.slice(2);
            var LastLetterElement = FirstLetterElement.slice(0, this.length - 1);
        }
        if(element.charAt(0) != '{' && element.charAt(0) == '"'){
            var FirstLetterElement = element.slice(1);
            var LastLetterElement = FirstLetterElement.slice(0, this.length - 1);
        }

        Output[i]=LastLetterElement;

        //last slice - after this every String is 100% clean
        for (let j = 0; j < LastLetterElement.length; j++) {
            if(LastLetterElement.charAt(j)=='"')
            {
                Output[i]=LastLetterElement.slice(0, this.length - 1);
            }
          }

        i++;
    })
});

//returns an array of 4 clean Strings ready for display
return(Output);
}

//creates the content for the index.html
function CreateDiv(Input){

    //sets the values for the  labels and buttons
    div_header.setAttribute('class','header');
    div_header.id = "center";
    label1.innerHTML = Input.OutputString;
    input1.value = Input.OutputText;

    label2.innerHTML = Input.NumberofData;
    input2.value = Input.DataNumber;

    newButton.addEventListener('click', ChangeDivNext);
    newButton.textContent = '->';
    newButton2.addEventListener('click', ChangeDivPrevious);
    newButton2.textContent = '<-';

    RiseLogo.src = "rise_logo.png";
    RiseLogo.id = "picture";

    //puts all objects into the div
    div_header.appendChild(label2);
    div_header.appendChild(input2);
    div_header.appendChild(label1);
    div_header.appendChild(input1);
    div_header.appendChild(paragraph1);
    div_header.appendChild(newButton2);
    div_header.appendChild(newButton);
    div_header.appendChild(paragraph2);
    div_header.appendChild(RiseLogo);

    //Instantiates all the objects in html in right order
    document.body.appendChild(div_header);
}

//changes data in the html to the next one saved on "allLastStrings" | or the the first one if on the last string
function ChangeDivNext(){
    if(displayNum == allLastStrings.allStrings.length-1)
    {
        displayNum = 0;
        input2.value = allLastStrings.allStrings[displayNum].DataNumber;
        input1.value = allLastStrings.allStrings[displayNum].OutputText;
    }
    else
    {
        displayNum++;
        input2.value = allLastStrings.allStrings[displayNum].DataNumber;
        input1.value = allLastStrings.allStrings[displayNum].OutputText;
    }
}
//changes data in the html to the previous one saved on "allLastStrings" | or to the last on if on the first string
function ChangeDivPrevious(){
    if(displayNum == 0)
    {
        displayNum = allLastStrings.allStrings.length-1;
        input2.value = allLastStrings.allStrings[displayNum].DataNumber;
        input1.value = allLastStrings.allStrings[displayNum].OutputText;
    }
    else{
        displayNum--;
        input2.value = allLastStrings.allStrings[displayNum].DataNumber;
        input1.value = allLastStrings.allStrings[displayNum].OutputText;
    }
}