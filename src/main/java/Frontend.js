fetch('Output.json')
            .then(response => response.json())
            .then(data => {

                var newText = JSON.stringify(data);
                var oldText = document.getElementById('Test');
                oldText.innerHTML = newText;

                var arrayString = JSON.stringify(data);
                var arrayTest = JSON.parse(arrayString);
                var Array = [];

                Array = arrayTest.cards;

                var div_header = document.createElement('div');
                div_header.setAttribute('class','header');

                var elem2 = document.createElement('label');
                elem2.innerHTML = "something";

                div_header.appendChild(elem2);
                document.body.appendChild(div_header);

                console.log(CleanJSON(arrayString));
            });

function CleanJSON(Input){

var FirstLetter = Input.slice(1);
var LastLetter = FirstLetter.slice(0, this.length - 1);

var Output = [];

Output = LastLetter.split(",")

return(Output);
}