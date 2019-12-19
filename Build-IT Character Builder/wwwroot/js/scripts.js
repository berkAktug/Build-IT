var TotalAttributePoints = 27;
var TotalLevelPoints = 19;

$(".AttribPlus").click(function () {
    //debugger;
    var plusBtn = $(this);
    var holder_attribute_scores = plusBtn.next();

    var attribute = parseInt(holder_attribute_scores.html());

    if (attribute < 15 && TotalAttributePoints >= 1) {
        if (attribute < 13) {
            TotalAttributePoints = TotalAttributePoints - 1;
            holder_attribute_scores.html(attribute + 1);
        }
        else if (attribute < 16 && TotalAttributePoints >= 2) {
            TotalAttributePoints = TotalAttributePoints - 2;
            holder_attribute_scores.html(attribute + 1);
        }
    }
    document.getElementById(plusBtn.attr('id').substring(0, 3).concat("Button")).style.width = String(parseInt(holder_attribute_scores.html()) * 100 / 15).concat("%");
});

$(".AttribMinus").click(function () {
    //debugger;
    var plusMinus = $(this);
    var holder_attribute_scores = plusMinus.prev();

    var attribute = parseInt(holder_attribute_scores.html());

    if (attribute > 8 && TotalAttributePoints <= 27) {
        if (attribute < 13) {
            TotalAttributePoints = TotalAttributePoints + 1;
            holder_attribute_scores.html(attribute - 1);
        }
        else if (attribute < 16) {
            TotalAttributePoints = TotalAttributePoints + 2;
            holder_attribute_scores.html(attribute - 1);
        }
    }

    document.getElementById(plusMinus.attr('id').substring(0, 3).concat("Button")).style.width = String(parseInt(holder_attribute_scores.html()) * 100 / 15).concat("%");
});




function openTab(evt, tabName) {
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }
    document.getElementById(tabName).style.display = "block";
    evt.currentTarget.className += " active";
}

function highlight(evt, type) {
    var activeButton = document.getElementsByClassName("button-normal" + type);
    if (activeButton[0]) {
        activeButton[0].className = activeButton[0].className.replace(type, "");
    }
    evt.currentTarget.className += type;
}

function highlight2Buttons(evt, type) {
    var edited = false;
    console.log(evt.currentTarget.className);
    if (evt.currentTarget.className.includes(type)) {
        console.log("SA");
        evt.currentTarget.className = "button-normal";
        edited = true;
    }
    var activeButtons = document.getElementsByClassName("button-normal".concat(type)).length;
    if (activeButtons < 2 && !edited)
        evt.currentTarget.className += type;

}

function createChar() {
	debugger;
	let name = "testName";
	let level = document.getElementById("lvlPoint").innerHTML;
	let race = document.getElementsByClassName("button-highlight-race")[0].innerHTML;
	let gender = document.getElementsByClassName("button-highlight-gender")[0].innerHTML;
	let background = document.getElementsByClassName("button-highlight-background")[0].innerHTML;
	let className = document.getElementsByClassName("button-highlight-class")[0].innerHTML;

	let profs = document.getElementsByClassName("button-highlight-prof");
	var proficiencies = [
		profs[0].innerHTML,
		profs[1].innerHTML
	];

	let attributes = [
                /*str: */parseInt(document.getElementById("strPoint").innerHTML),
                /*dex: */parseInt(document.getElementById("dexPoint").innerHTML),
                /*con: */parseInt(document.getElementById("conPoint").innerHTML),
                /*int: */parseInt(document.getElementById("intPoint").innerHTML),
                /*wis: */parseInt(document.getElementById("wisPoint").innerHTML),
                /*cha: */parseInt(document.getElementById("chaPoint").innerHTML)
	];

	let character = new CharacterBuilder()
		.setRace(race)
		.setName(name)
		//.setLevel(level)
		.setGender(gender)
        .setAttributes(attributes)
        .setBackground(background)
		.setClass(className)
		.setProficiency(proficiencies);

	console.log(character);

		$.ajax({
		headers: {
			'Accept': 'application/json',
			'Content-Type': 'application/json'
		},
		url: "/Character/SetupNewCharacter",
		type: "POST",
		dataType: 'json',
		contentType: "application/jsonrequest; charset=utf-8",
		data: JSON.stringify(character)
	}).done(function (excel) {

		var response = excel;
		window.location = '/Character/Download?fileName=' + response.fileName;
	});
}
