let Character = function (name, race, level, gender, attributes, background, className, proficiencies) {

    this.CharacterName = name;
    this.CharacterRace = race;
    this.CharacterLevel = level;
    this.CharacterGender = gender;
    this.CharacterAttributes = attributes;
    this.CharacterBackground = background;
    this.CharacterClassName = className;
    this.CharacterProficiencies = proficiencies;
}

let CharacterBuilder = function () {

    let CharacterName;
    let CharacterRace;
    let CharacterLevel;
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
        setLevel: function (level) {
            this.CharacterLevel = level;
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
            return new Character(CharacterName, CharacterRace, CharacterLevel, CharacterGender, CharacterAttributes,
                CharacterBackground, CharacterClassName, CharacterProficiencies);
        }
    };
};

