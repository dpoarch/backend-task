function stringBinary(){
	document.getElementById("results").innerHTML = '';
	var goodBinary = document.getElementById("inputBinary").value;

	var results = document.getElementById("results");

	var bad = document.createTextNode("This is not a good Binary String!");
	var good = document.createTextNode("This is a good Binary String!");

	var count1 = 0;
	var count0 = 0;

	var access = true;

	if(goodBinary.length == 0){
		results.appendChild(document.createTextNode("Please insert a binaryNumber"));
		return false;
	}

	for(var i = 0; i < goodBinary.length; i++){
		if(goodBinary.charAt(i) == "1"){
			count1++;
		}else if(goodBinary.charAt(i) == "0"){
			count0++;
		}else{
			access = false;
		}
	}
		if(access == true){
			if(count0 < count1){
			results.appendChild(bad);
			}

			if(count1 < count0){
				results.appendChild(bad);
			}

			if(count1 == count0){
				results.appendChild(good);
			}
		}else{
			results.appendChild(bad);
		}
}
