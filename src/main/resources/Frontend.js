var o = 1;

fetch('Output.json')
            .then(response => response.json())
            .then(data => {

                var arrayString = JSON.stringify(data);
                var CleanString = CleanJSON(arrayString);

                CreateDiv(CleanString);


                while(o < k){
                    CreateDiv(CleanString);
                    o++;
                }

            });

//number of Paragraphs in html
var k = 0;

//variable for assigning right string to html label/textfield
var l = 0;

function CleanJSON(Input){

var FirstLetter = Input.slice(1);
var LastLetter = FirstLetter.slice(0, this.length - 2);

var MultipleJSONStrings = LastLetter.split("}");
var NewMultipleJSONStringsLoop=[];
var NewMultipleJSONStrings=[];
var z = 0;

MultipleJSONStrings.forEach(element => {
    var u = 1;

    while(MultipleJSONStrings[0].charAt(u) != "{"){
        u++;
    }
    u++;

    NewMultipleJSONStringsLoop[z]=MultipleJSONStrings[z].slice(u);
    NewMultipleJSONStrings[z]=MultipleJSONStrings[z].slice(u);

    z++;
});

var SingleJSONStrings = [];
var RAM = [];
    var t = 0;
    var r = 0;

NewMultipleJSONStringsLoop.forEach(element => {

    RAM = NewMultipleJSONStrings[t].split(",");
    SingleJSONStrings[r] = RAM[0]
    r++;
    SingleJSONStrings[r] = RAM[1]
    r++;
    t++;
});

var Output = [];
var i =0;

SingleJSONStrings.forEach(element => {

    k++;

    var Data = element.split(":");

    console.log(Data);

    Data.forEach(element => {

        if(element.charAt(0) != '"' && element.charAt(0) != '{')
        {
            Output[i]=element;
            i++;

        }
        if(element.charAt(0) == '{'){
            var FirstLetterElement = element.slice(2);
            var LastLetterElement = FirstLetterElement.slice(0, this.length - 1);
            Output[i]=LastLetterElement;
            console.log(Output[i]);
            i++;
        }
        if(element.charAt(0) != '{' && element.charAt(0) == '"'){
            var FirstLetterElement = element.slice(1);
            var LastLetterElement = FirstLetterElement.slice(0, this.length - 1);
            Output[i]=LastLetterElement;
            i++;
        }

    })
});
console.log(Output);
return(Output);
}

function CreateDiv(Input){

    var div_header = document.createElement('div');
    div_header.setAttribute('class','header');

    var label = document.createElement('label');
    label.innerHTML = Input[l];
    l++;

    var input = document.createElement('input');
    input.value = Input[l];
    input.id = o;
    l++;

    div_header.appendChild(label);
    div_header.appendChild(input);
    document.body.appendChild(div_header);
}