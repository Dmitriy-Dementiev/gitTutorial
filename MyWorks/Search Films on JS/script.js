function getMovies(){
	//1 - создаем объект для запроса
	let xhr = new XMLHttpRequest();

	//2 - создаем ссылку для запроса 
	// и формируем соединение
    let URL="http://www.omdbapi.com/?i=tt3896198&apikey=2714bc69";
    let title= document.getElementById("title").value;
    let year= document.getElementById("year").value;

    xhr.open('GET', URL+"&s="+title+"&y="+year,true);
    console.log(URL+"&s="+title+"&y="+year);

    //3 - отсылаем запрос
    xhr.send();

    //4 - обработка ответа(Успешный ответ с кодом 200)
    xhr.onreadystatechange = function(){
    	console.log(xhr.readyState);
    		if(xhr.readyState == 4){
    			let arr = JSON.parse(xhr.responseText).Search;
    		console.log(arr);//массив из 10 объектов

    		let block = document.getElementsByClassName("movies")[0];
    		for(var i = 0; i < arr.length; i++) {
    			let item = document.createElement('div');
    			item.className ="movie";
    			item.innerHTML = "<img src="+arr[i]['Poster']+">";
    			item.innerHTML +="<h2> TITLE: " + arr[i]['Title']+"</h2>";
    			item.innerHTML +="<p> Type: " + arr[i]['Type']+"</p>";
    			item.id="item"+arr[i]['imdbID'];

    			let button = document.createElement('input');
    			button.type = "button";
    			button.id=""+arr[i]['imdbID'];
    			button.value = "More info";
    			button.addEventListener("click",function(){
    				let el = document.getElementById("item"+this.id);

    				let newRequest = new XMLHttpRequest();
    				let URL_n = "http://www.omdbapi.com/?apikey=2714bc69&i="+this.id; // вытаскиваем ссылку по айди
                    newRequest.open("POST",URL_n,true);
                    newRequest.send();
                    newRequest.onreadystatechange=function(){
                    	if(newRequest.readyState == 4){
                    		//объект с уточненной информацией выбранного фильма по id
                    		let info = JSON.parse(newRequest.responseText);
                    		el.innerHTML += "<p> <b>Writer: </b>" + info['Writer']+"</p>";
                    		el.innerHTML += "<p> <b>Genre: </b>" + info['Genre']+"</p>";
                    		el.innerHTML += "<p> <b>Country: </b>" + info['Country']+"</p>";
                    		el.innerHTML += "<p> <b>Year: </b>" + info['Year']+"</p>";

                    		el.innerHTML += "<p> <b>Actors: </b>" + info['Actors']+"</p>";
                             
                            
                    		

                    	}
                    }
                    this.style = "display:none";
    			}); // будет вытаскивать елемент по id

                item.appendChild(button);
    			block.appendChild(item);
    		}
    	}

    }
}