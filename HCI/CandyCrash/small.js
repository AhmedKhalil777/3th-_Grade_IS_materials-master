

function createTable()
{   document.getElementById("mainColumn").innerHTML="";

	var column=document.getElementById("mainColumn");
	var tab1=document.createElement("table");
	tab1.style.width="100%";
	tab1.setAttribute('border','2');

	var tbody=document.createElement("tbody");
    
	for(var i=0; i<8; i++){
	var tr=document.createElement("tr");
	for (var j = 0; j<8; j++) {
		var td=document.createElement("td");
		
		td.setAttribute('height','50');
		td.setAttribute('width','50');
        var txt = document.createTextNode("C"+(i+1)+(j+1));     // Create a text node
        td.appendChild(txt); 
        var cell_color=['red','lightgreen','blue','purple','yellow','orange','pink','cyan','magenta'];   
        var r= Math.round(Math.random()*8);

        td.setAttribute('bgcolor',cell_color[r]);
		tr.appendChild(td);
		
	}
	tbody.appendChild(tr);

	}
	tab1.appendChild(tbody);
	column.appendChild(tab1);	
	return tab1;

}