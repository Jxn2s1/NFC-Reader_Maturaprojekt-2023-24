var o = 1;

fetch('Output.json')
            .then(response => response.json())
            .then(data => {

                var arrayString = JSON.stringify(data);
                var CleanString = CleanJSON(arrayString);

                console.log(o);
                console.log(k);
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
var LastLetter = FirstLetter.slice(0, this.length - 1);

var SingleJSONStrings = [];

SingleJSONStrings = LastLetter.split(",");

var Output = [];
var i =0;

console.log(SingleJSONStrings);

SingleJSONStrings.forEach(element => {

    k++;

    var Data = element.split(":");
    Data.forEach(element => {

        if(element.charAt(0) != '"')
        {
            Output[i]=element;
            i++;
        }
        else{
            var FirstLetterElement = element.slice(1);
            var LastLetterElement = FirstLetterElement.slice(0, this.length - 1);
            Output[i]=LastLetterElement;
            i++;
        }

    })
});

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