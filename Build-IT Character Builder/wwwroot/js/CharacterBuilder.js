let Character = function (race, gender, attributes, background, className, proficiencies) {

    this.CharacterName;
    this.CharacterRace = race;
    this.CharacterGender = gender;
    this.CharacterAttributes = attributes;
    this.CharacterBackground = background;
    this.CharacterClassName = className;
    this.CharacterProficiencies = proficiencies;
}

let CharacterBuilder = function () {

    let CharacterName;
    let CharacterRace;
    let CharacterGender;
    let CharacterAttributes;
    let CharacterBackground;
    let CharacterClassName;
    let CharacterProficiencies;

    return {
        setRace: function (race) {
            this.CharacterRace = race;
            return this;
        },
        setName: function (name) {
            this.CharacterName = name;
            return this;
        },
        setGender: function (gender) {
            this.CharacterGender = gender;
            return this;
        },
        setAttributes: function (attributes) {
            this.CharacterAttributes = attributes;
            return this;
        },
        setBackground: function (background) {
            this.CharacterBackground = background;
            return this;
        },
        setClass: function (className) {
            this.CharacterClassName  = className;
            return this;
        },
        setProficiency: function (proficiencies) {
            this.CharacterProficiencies = proficiencies;
            return this;
        },
        build: function () {
            return new Character(CharacterName, CharacterRace, CharacterGender, CharacterAttributes,
                CharacterBackground, CharacterClassName, CharacterProficiencies);
        }
    };
};

