fetch('Output.json')
            .then(response => response.json())
            .then(data => {

                var newText = JSON.stringify(data,null,2);
                var oldText = document.getElementById('Test');
                oldText.innerHTML = newText;
            });